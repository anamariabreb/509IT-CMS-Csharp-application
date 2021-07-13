
namespace contact_management_system
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManagePersonal = new System.Windows.Forms.Button();
            this.btnManageBusiness = new System.Windows.Forms.Button();
            this.labWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManagePersonal
            // 
            this.btnManagePersonal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManagePersonal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManagePersonal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManagePersonal.Location = new System.Drawing.Point(155, 194);
            this.btnManagePersonal.Name = "btnManagePersonal";
            this.btnManagePersonal.Size = new System.Drawing.Size(165, 79);
            this.btnManagePersonal.TabIndex = 0;
            this.btnManagePersonal.Text = "Manage Personal Contacts";
            this.btnManagePersonal.UseVisualStyleBackColor = false;
            this.btnManagePersonal.Click += new System.EventHandler(this.btnManagePersonal_Click);
            // 
            // btnManageBusiness
            // 
            this.btnManageBusiness.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManageBusiness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageBusiness.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageBusiness.Location = new System.Drawing.Point(468, 194);
            this.btnManageBusiness.Name = "btnManageBusiness";
            this.btnManageBusiness.Size = new System.Drawing.Size(165, 79);
            this.btnManageBusiness.TabIndex = 1;
            this.btnManageBusiness.Text = "Manage Business Contacts";
            this.btnManageBusiness.UseVisualStyleBackColor = false;
            this.btnManageBusiness.Click += new System.EventHandler(this.btnManageBusiness_Click);
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labWelcome.Location = new System.Drawing.Point(245, 75);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(330, 25);
            this.labWelcome.TabIndex = 2;
            this.labWelcome.Text = "Welcome! What would you like to do?";
            this.labWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labWelcome);
            this.Controls.Add(this.btnManageBusiness);
            this.Controls.Add(this.btnManagePersonal);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManagePersonal;
        private System.Windows.Forms.Button btnManageBusiness;
        private System.Windows.Forms.Label labWelcome;
    }
}

