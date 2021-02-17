using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ergasia3_Database;

namespace Ergasia3_Web
{
    public partial class Main : System.Web.UI.Page
    {
        private DbManager ContextDb { get; set; } 

        protected void Page_Load(object sender, EventArgs e)
        {
            // Connect to dataBase
            ContextDb = new DbManager(@"Data Source=|DataDirectory|\Database.db;Version=3;");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Show total cases
            LabelTotalCases.Text = $"Total Cases: {ContextDb.Cases.Count}";

            // Calculate and show average case age
            var birthdayList = ContextDb.Cases.Select(x => x.BirthDay);
            List<int> ageList = new List<int>();
            foreach (var var in birthdayList)
            {
                var timeSpan = DateTime.Today - DateTime.ParseExact(var, "dd/MM/yyyy", new DateTimeFormatInfo());
                ageList.Add(((int)timeSpan.TotalDays) / 365);
            }
            LabelAge.Text = $"Average Age: {ageList.Sum() / ageList.Count}";

            // Calculate gender info
            LabelMale.Text = $"Male: {(int)((float) ContextDb.Cases.Count(x => x.Gender.Equals("Male")) / ContextDb.Cases.Count() * 100f)}% ({ContextDb.Cases.Count(x => x.Gender.Equals("Male"))}) ";
            LabelFemale.Text = $"Female: {(int)((float) ContextDb.Cases.Count(x => x.Gender.Equals("Female")) / ContextDb.Cases.Count() * 100f)}% ({ContextDb.Cases.Count(x => x.Gender.Equals("Female"))}) ";
        }
    }
}