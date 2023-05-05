using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridSQLServerDemo
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            UpdateDataGridSQL();
        }

        private void UpdateDataGridSQL()
        {
            
            peopleListDataGrid.DataSource = people;
            peopleListDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            peopleListDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople();
            UpdateDataGridSQL();
        }
    }
}