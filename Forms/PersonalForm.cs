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
            // Open the database connection
            InitializeComponent();
            mysqlConn = new dbConn.personalDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                // Populate the table with data from the Database
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact`").Tables[0];
                // Update table headings for a better UX
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[3].HeaderText = "Tel";
                dataGridView1.Columns[4].HeaderText = "Home Tel";
                dataGridView1.Columns[5].HeaderText = "Email";
                dataGridView1.Columns[6].HeaderText = "Address 1";
                dataGridView1.Columns[7].HeaderText = "Address 2";
                dataGridView1.Columns[8].HeaderText = "City";
                dataGridView1.Columns[9].HeaderText = "Postcode";
            }
            mysqlConn.connClose();
        }

        // Add button
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

        // Update button
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

        // Populate the form fields when double clicking on a table entry
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbHomeTel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbEmail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tbAddr1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbAddr2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                tbCity.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                tbPostcode.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        // Delete button
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

        // Main Menu button - return to Homepage
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new Homepage()).Show();
        }

        // Exit application button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Search by email address
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `PersonalContact` where contactEmail='" + tbEmail.Text + "'").Tables[0];
            }
            mysqlConn.connClose();
        }


        //
        // Validation
        // 

        // Simple string fields validation to ensure only letters are inserted - used for FName, LName and City
        private void tbFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Number and + character validation for telephone fields
        private void tbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars and + sign
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }
        }

        

        // Postcode validation to ensure only letters or digits are inserted and no more than 8 characters
        private void tbPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Count the digits already in the text
            if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 8)
            {
                e.Handled = true;
            }
        }

        // String fields validation to ensure only letters, digits and special char ., are inserted - used for Addr1 and Addr2
        private void tbAddr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }         
        }
    }
}
