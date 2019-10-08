namespace PC_05
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageHousekeeperSupervisor1 = new PC_05.PageHousekeeperSupervisor();
            this.pageHousekeeper1 = new PC_05.PageHousekeeper();
            this.pageFrontOffice1 = new PC_05.PageFrontOffice();
            this.pageAdmin1 = new PC_05.PageAdmin();
            this.SuspendLayout();
            // 
            // pageHousekeeperSupervisor1
            // 
            this.pageHousekeeperSupervisor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageHousekeeperSupervisor1.Location = new System.Drawing.Point(0, 0);
            this.pageHousekeeperSupervisor1.Name = "pageHousekeeperSupervisor1";
            this.pageHousekeeperSupervisor1.Size = new System.Drawing.Size(975, 652);
            this.pageHousekeeperSupervisor1.TabIndex = 3;
            // 
            // pageHousekeeper1
            // 
            this.pageHousekeeper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageHousekeeper1.Location = new System.Drawing.Point(0, 0);
            this.pageHousekeeper1.Name = "pageHousekeeper1";
            this.pageHousekeeper1.Size = new System.Drawing.Size(975, 652);
            this.pageHousekeeper1.TabIndex = 2;
            // 
            // pageFrontOffice1
            // 
            this.pageFrontOffice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageFrontOffice1.Location = new System.Drawing.Point(0, 0);
            this.pageFrontOffice1.Name = "pageFrontOffice1";
            this.pageFrontOffice1.Size = new System.Drawing.Size(975, 652);
            this.pageFrontOffice1.TabIndex = 1;
            // 
            // pageAdmin1
            // 
            this.pageAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageAdmin1.Location = new System.Drawing.Point(0, 0);
            this.pageAdmin1.Name = "pageAdmin1";
            this.pageAdmin1.Size = new System.Drawing.Size(975, 652);
            this.pageAdmin1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 652);
            this.Controls.Add(this.pageHousekeeperSupervisor1);
            this.Controls.Add(this.pageHousekeeper1);
            this.Controls.Add(this.pageFrontOffice1);
            this.Controls.Add(this.pageAdmin1);
            this.Name = "MainForm";
            this.Text = "Grand Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private PageAdmin pageAdmin1;
        private PageFrontOffice pageFrontOffice1;
        private PageHousekeeper pageHousekeeper1;
        private PageHousekeeperSupervisor pageHousekeeperSupervisor1;
    }
}