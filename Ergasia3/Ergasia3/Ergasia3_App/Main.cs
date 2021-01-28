using Ergasia3_Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Ergasia3_App
{
    public partial class Main : Form
    {
        private DbManager Context { get; set; }

        private Case selectedCase; // Used in Search/Edit tab

        private bool showAll;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Context = new DbManager(@"Data Source=../../../Ergasia3_Web/App_Data/Database.db;Version=3;");

            // Hide & Disable search tab
            panelSearch.Enabled = false;
            panelSearch.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Check if any textBox is empty. Not including textBoxUD
            if (panelForm.Controls.OfType<TextBox>().Any(x=> string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("All fields with * must be filled!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check phoneNumber if its valid
            if (textBoxPhone.Text.Length < 10|| !textBoxPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone nubmer must consist of 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check gender option if empty
            if (comboBoxGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check dates
            try
            {
                DateTime.ParseExact(maskedTextBoxBirthday.Text, "dd/MM/yyyy", new DateTimeFormatInfo()); // format it like 24/10/2001 and not 10/24/2001 
            }
            catch (Exception)
            {
                MessageBox.Show("Please put a valid Birth Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DateTime.ParseExact(maskedTextBoxCaseTime.Text, "dd/MM/yyyy HH:mm", new DateTimeFormatInfo());
            }
            catch (Exception)
            {
                MessageBox.Show("Please put a valid Time of case!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new case
            Case newCase = new Case()
            {
                FullName = textBoxName.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhone.Text,
                Gender = comboBoxGender.Text,
                BirthDay = maskedTextBoxBirthday.Text,
                Address = textBoxAddress.Text,
                TimeOfCase = maskedTextBoxCaseTime.Text
            };

            // Add underlying diseases to that new case
            foreach (var item in listBoxUD.Items)
            {
                newCase.UnderlyingDiseases.Add(new UnderlyingDisease() { Disease = item.ToString() });
            }

            // Save the new case to the dataBase
            Context.AddCase(newCase);

            // Reset textBoxes
            foreach (var textBox in panelForm.Controls.OfType<TextBox>()) textBox.Clear();
            foreach (var maskedTextBox in panelForm.Controls.OfType<MaskedTextBox>()) maskedTextBox.Clear();
            listBoxUD.Items.Clear();
            comboBoxGender.SelectedItem = null;

            MessageBox.Show("Successfully added case!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showAll = false;
            Search(true); // With info
        }

        /*
         * Searches for users.
         * If info = true then it will throw error messageBoxes if it didn't find anything
         */
        private void Search(bool info)
        {
            List<Case> caseList;
            listBoxResult.Items.Clear();

            // If search textBoxes are empty then don't search.
            if (string.IsNullOrWhiteSpace(textBoxNameSearch.Text) && !maskedTextBoxDateSearch.MaskCompleted)
            {
                if(info)MessageBox.Show("Atleast 1 field must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check what input the user gave and make the search.
            if (string.IsNullOrWhiteSpace(textBoxNameSearch.Text) && maskedTextBoxDateSearch.MaskCompleted) // TimeOfCase based search.
            {
                // we split at ' ' so we can take only the date. we don't search time.
                caseList = Context.Cases.Where(x => x.TimeOfCase.Split(' ')[0].Equals(maskedTextBoxDateSearch.Text)).ToList();
            }
            else if (!maskedTextBoxDateSearch.MaskCompleted && !string.IsNullOrWhiteSpace(textBoxNameSearch.Text)) // Name based search.
            {
                // we split at ' ' so we can take only the date. we don't search time.
                caseList = Context.Cases.Where(x => x.FullName == textBoxNameSearch.Text).ToList();
            }
            else // TimeOfCase && Name based search.
            {
                caseList = Context.Cases.Where(x => x.TimeOfCase.Split(' ')[0].Equals(maskedTextBoxDateSearch.Text) && x.FullName == textBoxNameSearch.Text).ToList();
            }

            // If caseList is empty after the search then no users where found.
            if (caseList.Count == 0)
            {
                // A message box with Ok option and yellow triangle (warning) icon.
                if(info)MessageBox.Show("No records found!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If caseList is not empty then add it to the listBox
            foreach (var c in caseList)
            {
                listBoxResult.Items.Add($"ID:{c.ID} | Name:{c.FullName}");
            }
        }
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            showAll = true;
            listBoxResult.Items.Clear();
            foreach (var c in Context.Cases)
            {
                listBoxResult.Items.Add($"ID:{c.ID} | Name:{c.FullName}");
            }
        }

        /*
         * Disables and Clears the info panel.
         */
        public void DisableInfo()
        {
            foreach (var textBox in panelEdit.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            comboBoxEditGender.SelectedItem = null;
            maskedTextBoxEditBirth.Clear();
            maskedTextBoxEditTime.Clear();

            buttonDelete.Enabled = false;
            buttonEdit.Enabled = false;
        }

        /*
         * Lists all the cases found by search
         */
        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            // When we delete the last item of the listbox it returns -1 as an index 
            if (listBoxResult.SelectedIndex == -1)
            {
                DisableInfo();
                return;
            }

            /*
             * ListBox's items are shown like this: "ID:xxxx | Name:xxxx". (Line:146)
             * So we split 1 time with '|' which returns: [ID:xxxx],[Name:xxxx]
             * Then we take the first part [0] -> ID:xxxx  and we split it with ':' which returns: [ID],[xxxx]
             * Then we take the second part [1] -> xxxx which is the case's id we are looking for.
             */
            // Find case
            var caseid = int.Parse(listBoxResult.SelectedItem.ToString().Split('|')[0].Split(':')[1]); // comment above
            selectedCase = Context.Cases.First(x=> x.ID == caseid);

            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;

            // Show selected user's info
            textBoxEditName.Text = selectedCase.FullName;
            textBoxEditEmail.Text = selectedCase.Email;
            textBoxEditNumber.Text = selectedCase.PhoneNumber;
            comboBoxEditGender.Text = selectedCase.Gender;
            maskedTextBoxEditBirth.Text = selectedCase.BirthDay;
            textBoxEditHome.Text = selectedCase.Address;
            maskedTextBoxEditTime.Text = selectedCase.TimeOfCase;

            // Show underlying diseases
            listBoxEditUD.Items.Clear();
            foreach (var selectedCaseUnderlyingDisease in selectedCase.UnderlyingDiseases)
            {
                listBoxEditUD.Items.Add(selectedCaseUnderlyingDisease.Disease);
            }

            // Disable UD save changes button
            buttonChangeUD.Enabled = false;
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // When the user presses the button it changes its text and its function.
            if (buttonEdit.Text == "Edit")
            {
                buttonEdit.Text = "Save Changes";
                buttonDelete.Text = "Cancel";
                panelEdit.Enabled = true;
            }
            else
            {
                buttonEdit.Text = "Edit";
                buttonDelete.Text = "Delete";
                panelEdit.Enabled = false;
                
                // Check for mistakes. in case of a mistake revert changes
                // Check textboxes if they are empty
                if (panelEdit.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
                {

                    MessageBox.Show("All fields with * must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Revert changes
                    textBoxEditName.Text = selectedCase.FullName;
                    textBoxEditEmail.Text = selectedCase.Email;
                    textBoxEditNumber.Text = selectedCase.PhoneNumber;
                    textBoxEditHome.Text = selectedCase.Address;
                    return;
                }

                // Check phoneNumber if its valid
                if (textBoxEditNumber.Text.Length < 10 || !textBoxEditNumber.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Phone nubmer must consist of 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Revert changes
                    textBoxEditNumber.Text = selectedCase.PhoneNumber;
                    return;
                }

                if (comboBoxEditGender.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check dates
                try
                {
                    // Check if valid date and format it like 24/10/2001 and not 10/24/2001 
                    DateTime.ParseExact(maskedTextBoxEditBirth.Text, "dd/MM/yyyy", new DateTimeFormatInfo());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please put a valid Birth Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Revert Changes
                    maskedTextBoxEditBirth.Text = selectedCase.BirthDay;
                    return;
                }
                try
                {
                    // Check if valid date and format it like 24/10/2001 03:20
                    DateTime.ParseExact(maskedTextBoxEditTime.Text, "dd/MM/yyyy HH:mm", new DateTimeFormatInfo());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please put a valid Time of case!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    // Revert Changes
                    maskedTextBoxEditTime.Text = selectedCase.TimeOfCase;
                    return;
                }

                // If the user input is valid then change Cases info
                selectedCase.FullName = textBoxEditName.Text;
                selectedCase.Email = textBoxEditEmail.Text;
                selectedCase.PhoneNumber = textBoxEditNumber.Text;
                selectedCase.Gender = comboBoxEditGender.Text;
                selectedCase.BirthDay = maskedTextBoxEditBirth.Text ;
                selectedCase.Address = textBoxEditHome.Text;
                selectedCase.TimeOfCase = maskedTextBoxEditTime.Text;

                // Save changes to the database
                Context.UpdateCase(selectedCase);

                MessageBox.Show("Edit successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // We update the case listBox panel by doing a search again
                if (showAll)
                {
                    // Update the list by calling the buttonShowAll_Click.
                    buttonShowAll_Click(null,null);
                }
                else
                {
                    //Redo the search to get the updated list
                    Search(false);
                }

                if (listBoxResult.Items.Count == 0) // If no cases left then disable edit/info panel
                {
                    DisableInfo();
                    listBoxEditUD.Items.Clear();
                }
            }
        }
        /*
         * Deletes the selected case
         */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (buttonDelete.Text == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this case?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Context.DeleteCase(selectedCase); // Delete case

                    listBoxResult.Items.Remove(listBoxResult.SelectedItem); // Delete from listbox

                    // Clear textboxes
                    DisableInfo();
                }
            }
            else
            {
                buttonEdit.Text = "Edit";
                buttonDelete.Text = "Delete";
                panelEdit.Enabled = false;
            }
        }

        /*
         * Saves UD changes
         */
        private void buttonChangeUD_Click(object sender, EventArgs e)
        {
            var newDiseases = new List<UnderlyingDisease>();
            foreach (var disease in listBoxEditUD.Items)
            {
                newDiseases.Add(new UnderlyingDisease(){Disease = disease.ToString()});
            }

            // Give the selected case the edited disease list and update the database
            selectedCase.UnderlyingDiseases = newDiseases;
            Context.UpdateUnderlyingDiseases(selectedCase);
            buttonChangeUD.Enabled = false;
        }

        /*
         * If disease already in listBox then show message.
         * If NOT already in listBox then add it to that listBox.
         */
        private void buttonAddD_Click(object sender, EventArgs e) // ADD
        {
            if (listBoxUD.Items.Contains(textBoxUD.Text))
            {
                MessageBox.Show($"Disease '{textBoxUD.Text}' Already Added!");
            }
            else
            {
                listBoxUD.Items.Add(textBoxUD.Text);
                textBoxUD.Clear();
            }
        }
        private void buttonAddNewUD_Click(object sender, EventArgs e) // EDIT
        {
            if (listBoxEditUD.Items.Contains(textBoxEditUD.Text))
            {
                MessageBox.Show($"Disease '{textBoxEditUD.Text}' Already Added!");
            }
            else
            {
                buttonChangeUD.Enabled = true;
                listBoxEditUD.Items.Add(textBoxEditUD.Text);
                textBoxEditUD.Clear();
            }
        }

        /*
         * If textBox is empty then disable button.
         */
        private void textBox_TextChanged(object sender, EventArgs e) // ADD & EDIT
        {
            var textbox = (TextBox) sender;
            if (textbox.Name == "textBoxUD")
            {
                if (!String.IsNullOrWhiteSpace(textBoxUD.Text)) buttonAddD.Enabled = true;
                else buttonAddD.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(textBoxEditUD.Text)) buttonAddNewUD.Enabled = true;
                else buttonAddNewUD.Enabled = false;
            }
        }

        // DISEASE SELECTION
        /*
         * If a case isn't selected then remove ContextMenuStrip to that ListBox.
         * If a case IS selected then add a ContextMenuStrip to that ListBox.
         */
        private void listBox_SelectedValueChanged(object sender, EventArgs e) // EDIT & ADD
        {
            var listBox = (ListBox)sender;
            if (listBox.Name == "listBoxUD")
            {
                if (listBoxUD.SelectedItem == null) listBoxUD.ContextMenuStrip = null;
                else listBoxUD.ContextMenuStrip = contextMenuStripAdd;
            }
            else
            {
                if (listBoxEditUD.SelectedItem == null) listBoxEditUD.ContextMenuStrip = null;
                else listBoxEditUD.ContextMenuStrip = contextMenuStripEdit;
            }
        }

        // RIGHT CLICKS
        /*
         * Remove Selected Item.
         */
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) // ADD
        {
            listBoxUD.Items.Remove(listBoxUD.SelectedItem);
        }
        private void toolStripMenuItemEDITdelete_Click(object sender, EventArgs e) // EDIT
        {
            listBoxEditUD.Items.Remove(listBoxEditUD.SelectedItem);
            buttonChangeUD.Enabled = true;
        }
        
        // Change Tabs (ADD NEW / SEARCH-EDIT-DELETE)
        private void searchCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAddNew.Enabled = false;
            panelAddNew.Visible = false;

            panelSearch.Enabled = true;
            panelSearch.Visible = true;
            panelSearch.BringToFront();
        }

        private void addNewCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSearch.Enabled = false;
            panelSearch.Visible = false;

            panelAddNew.Enabled = true;
            panelAddNew.Visible = true;
            panelAddNew.BringToFront();
        }
    }
}