using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_management_system
{
    public partial class PersonalForm : Form
    {
        dbConn.personalDbConn mysqlConn;
        public PersonalForm()
        {
            InitializeComponent();
            mysqlConn = new dbConn.personalDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact`").Tables[0];
                dataGridView1.Columns[0].HeaderText = "Test";

               // string str = dataGridView1.Columns[i].HeaderText;
               // if (str == "Wednesday")
               // {
               //     dataGridView1.Columns[i].HeaderText = "fifth day of week";
                //}
            }
            mysqlConn.connClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                PersonalContact persCon = new PersonalContact(tbID.Text, tbFName.Text, tbLName.Text, tbTel.Text, tbHomeTel.Text, tbEmail.Text, tbAddr1.Text, tbAddr2.Text, tbCity.Text, tbPostcode.Text);

                mysqlConn.insertContact(persCon);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact`").Tables[0];
            }
            mysqlConn.connClose();
        }

        // UPDATE CODE HERE!!!
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            { 
            tbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                PersonalContact persCon = new PersonalContact(tbID.Text, tbFName.Text, tbLName.Text, tbTel.Text, tbHomeTel.Text, tbEmail.Text, tbAddr1.Text, tbAddr2.Text, tbCity.Text, tbPostcode.Text);

                mysqlConn.updateContact(persCon);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteContact(tbID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new Homepage()).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
