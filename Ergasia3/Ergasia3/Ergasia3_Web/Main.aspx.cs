using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
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
            ContextDb = new DbManager(@"Data Source=|DataDirectory|\Database.db;Version=3;");
        }
    }
}