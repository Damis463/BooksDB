using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksDB
{
    public partial class frmtitles : Form
    {
        OleDbConnection conn;
        public frmtitles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\DB\Books.accdb; 
                                 Persist Security Info = False;";

            conn = new OleDbConnection(connString);
            conn.Open();
            txtConn.Text = conn.State.ToString();

        }
    }
}