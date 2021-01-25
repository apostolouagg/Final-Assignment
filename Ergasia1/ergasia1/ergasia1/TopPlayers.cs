using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ergasia1
{
    public partial class TopPlayers : Form
    {
        /* sto design exw balei 2 listboxes. To 1o listbox tha einai gia na deixnei ta onomata twn paiktwn kai o xrhsths na mporei na 
           ta epilegei. Otan epilegei 1 onoma paikth, tote sto 2o listbox tha emfanizontai o xronos kai o arithmos ths prospatheias tou
           paikth apo thn kaluterh pros th xeiroterh. */

        // To do list
        // 1. sto kommati me to sxolio "//NEEDS WORK" uparxei ekshghsh

        string name;
        List<string> playerInfo;
        private string connectionstring = "Data Source=c:DB1.db;Version=3;";
        SQLiteConnection conn;

        public TopPlayers(List<string> playersName) // lista me ta onomata
        {
            InitializeComponent();
            playerInfo = playersName;
        }

        private void TopPlayers_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionstring);

            listBox1.DataSource = playerInfo; // Auth h entolh dinei oloklhrh lista sto listbox
        }

        // NEEDS WORK
        /* Theloume na briskei to onoma apo to listbox1, na to sugkrinei me thn database kai sto listbox2 na emfanizei ta 10 kalutera time
           kai attemp tou paikth pou epilexthhke */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*using (SQLiteConnection conn = new SQLiteConnection(connectionstring)) //(automatically closes the connection)
            {
                conn.Open();
                string selectQuery = "Select Name FROM Users";
                SQLiteCommand cmd1 = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    if (listBox1.SelectedIndex.ToString().Equals(reader1.GetValue(0).ToString()))
                    {
                        MessageBox.Show("dfsh");
                        string select2Query = "Select Time, Attemps from Users Order by Time ASC";
                        SQLiteCommand cmd2 = new SQLiteCommand(select2Query, conn);
                        SQLiteDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.Read())
                        {
                            listBox2.Items.Add(reader2.GetValue(0).ToString() + "  " + reader2.GetValue(1).ToString());
                        }
                    }
                }
            }*/
        }
    }
}
