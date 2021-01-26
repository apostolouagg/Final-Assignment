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
        private Case selectedCase;
        private int selectedResultIndex;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Context = new DatabaseContainer();
            Context = new DbManager(@"Data Source=../../../Ergasia3_Web/App_Data/Database.db;Version=3;");

            buttonAddD.Enabled = false;
            listBoxUD.ContextMenuStrip = null;

            panelSearch.Enabled = false;
            panelSearch.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Check textboxes if they are empty
            if (panelForm.Controls.OfType<TextBox>().Where(check => check.Name != "textBoxUD").Any(x=> string.IsNullOrWhiteSpace(x.Text)))
            {

                MessageBox.Show("All fields with * must be filled!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Check phoneNumber if its valid
                if (textBoxPhone.Text.Length < 10|| !textBoxPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Phone nubmer must consist of 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

            }

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

            foreach (var item in listBoxUD.Items)
            {
                newCase.UnderlyingDiseases.Add(new UnderlyingDisease() { Disease = item.ToString() });
            }

            // Save to dataBase
            Context.AddCase(newCase);

            // Reset textBoxes
            foreach (var textBox in panelForm.Controls.OfType<TextBox>()) textBox.Clear();
            foreach (var maskedTextBox in panelForm.Controls.OfType<MaskedTextBox>()) maskedTextBox.Clear();
            listBoxUD.Items.Clear();
            comboBoxGender.SelectedItem = null;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search(true);
        }

        private void Search(bool info)
        {
            List<Case> searchTime = new List<Case>();
            List<Case> searchName = new List<Case>();
            listBoxResult.Items.Clear();
            Console.WriteLine("test");
            foreach (var contextCase in Context.Cases)
            {
                Console.WriteLine("test2");

                Console.WriteLine(contextCase.FullName);
            }

            if (string.IsNullOrWhiteSpace(textBoxNameSearch.Text) && !maskedTextBoxDateSearch.MaskCompleted)
            {
                if(info)MessageBox.Show("Atleast 1 field must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxNameSearch.Text) && maskedTextBoxDateSearch.MaskCompleted)
            {
                searchTime = Context.Cases.Where(x => x.TimeOfCase.Contains(maskedTextBoxDateSearch.Text)).ToList();
            }
            else if (!maskedTextBoxDateSearch.MaskCompleted && !string.IsNullOrWhiteSpace(textBoxNameSearch.Text))
            {
                searchName = Context.Cases.Where(x => x.FullName == textBoxNameSearch.Text).ToList();
            }
            else
            {
                searchTime = Context.Cases.Where(x => x.TimeOfCase.Contains(maskedTextBoxDateSearch.Text) && x.FullName == textBoxNameSearch.Text).ToList();
            }

            var caseList = searchName.Union(searchTime).ToList(); // join them together keep only the uniques
            if (caseList.Count == 0)
            {
                if(info)MessageBox.Show("No records found!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var c in caseList)
            {
                listBoxResult.Items.Add($"ID:{c.ID} | Name:{c.FullName}");
            }
        }

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedResultIndex = listBoxResult.SelectedIndex;

            // When we delete the last item of the listbox it returns -1 as an index 
            if (selectedResultIndex == -1)
            {
                DisableInfo();
                return;
            }

            var id = int.Parse(listBoxResult.SelectedItem.ToString().Split('|')[0].Split(':')[1]);
            selectedCase = Context.Cases.First(x=> x.ID == id);

            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;


            textBoxEditName.Text = selectedCase.FullName;
            textBoxEditEmail.Text = selectedCase.Email;
            textBoxEditNumber.Text = selectedCase.PhoneNumber;
            comboBoxEditGender.Text = selectedCase.Gender;
            maskedTextBoxEditBirth.Text = selectedCase.BirthDay;
            textBoxEditHome.Text = selectedCase.Address;
            maskedTextBoxEditTime.Text = selectedCase.TimeOfCase;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
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
                    textBoxEditName.Text = selectedCase.FullName;
                    textBoxEditEmail.Text = selectedCase.Email;
                    textBoxEditNumber.Text = selectedCase.PhoneNumber;
                    textBoxEditHome.Text = selectedCase.Address;
                    return;
                }
                else
                {
                    // Check phoneNumber if its valid
                    if (textBoxEditNumber.Text.Length < 10 || !textBoxEditNumber.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Phone nubmer must consist of 10 numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        DateTime.ParseExact(maskedTextBoxEditBirth.Text, "dd/MM/yyyy", new DateTimeFormatInfo()); // format it like 24/10/2001 and not 10/24/2001 
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please put a valid Birth Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        maskedTextBoxEditBirth.Text = selectedCase.BirthDay;
                        return;
                    }
                    try
                    {
                        DateTime.ParseExact(maskedTextBoxEditTime.Text, "dd/MM/yyyy HH:mm", new DateTimeFormatInfo());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please put a valid Time of case!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        maskedTextBoxEditTime.Text = selectedCase.TimeOfCase;
                        return;
                    }

                }

                // Change and save
                selectedCase.FullName = textBoxEditName.Text;
                selectedCase.Email = textBoxEditEmail.Text;
                selectedCase.PhoneNumber = textBoxEditNumber.Text;
                selectedCase.Gender = comboBoxEditGender.Text;
                selectedCase.BirthDay = maskedTextBoxEditBirth.Text ;
                selectedCase.Address = textBoxEditHome.Text;
                selectedCase.TimeOfCase = maskedTextBoxEditTime.Text;

                Context.UpdateCase(selectedCase);

                MessageBox.Show("Edit successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search(false);
                if (listBoxResult.Items.Count == 0)
                {
                    DisableInfo();

                }
            }
        }
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
        private void buttonAddD_Click(object sender, EventArgs e)
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxUD.Items.Remove(listBoxUD.SelectedItem);
        }


        private void listBoxUD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxUD.SelectedItem == null)
            {
                listBoxUD.ContextMenuStrip = null;
            }
            else
            {
                listBoxUD.ContextMenuStrip = contextMenuStrip1;
            }
        }

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

        private void textBoxUD_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxUD.Text))
            {
                buttonAddD.Enabled = true;
            }
            else
            {
                buttonAddD.Enabled = false;
            }
        }
    }
}