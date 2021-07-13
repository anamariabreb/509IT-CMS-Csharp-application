using contact_management_system.dbConn;
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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }


        private void btnManagePersonal_Click(object sender, EventArgs e)
        {
            Close(); // close the current form
            PersonalForm PersonalForm = new();
            PersonalForm.Show();
        }

        private void btnManageBusiness_Click(object sender, EventArgs e)
        {
            Close(); // close the current form
            BusinessForm BusinessForm = new();
            BusinessForm.Show();
           
        }
    }
}
