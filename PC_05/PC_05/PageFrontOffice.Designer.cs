namespace PC_05
{
    partial class PageFrontOffice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.masterRoom1 = new PC_05.MasterRoom();
            this.masterRoomType1 = new PC_05.MasterRoomType();
            this.masterItem1 = new PC_05.MasterItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 487);
            this.panel1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 57);
            this.button7.TabIndex = 6;
            this.button7.Text = "Master Item";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Master Room";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Master Room Type";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Check Out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Request Additional Items";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reservation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Front Office";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 46);
            this.panel2.TabIndex = 3;
            // 
            // masterRoom1
            // 
            this.masterRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterRoom1.Location = new System.Drawing.Point(135, 46);
            this.masterRoom1.Name = "masterRoom1";
            this.masterRoom1.Size = new System.Drawing.Size(715, 487);
            this.masterRoom1.TabIndex = 5;
            // 
            // masterRoomType1
            // 
            this.masterRoomType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterRoomType1.Location = new System.Drawing.Point(135, 46);
            this.masterRoomType1.Name = "masterRoomType1";
            this.masterRoomType1.Size = new System.Drawing.Size(715, 487);
            this.masterRoomType1.TabIndex = 4;
            this.masterRoomType1.Load += new System.EventHandler(this.masterRoomType1_Load);
            // 
            // masterItem1
            // 
            this.masterItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterItem1.Location = new System.Drawing.Point(135, 46);
            this.masterItem1.Name = "masterItem1";
            this.masterItem1.Size = new System.Drawing.Size(715, 487);
            this.masterItem1.TabIndex = 6;
            // 
            // PageFrontOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.masterItem1);
            this.Controls.Add(this.masterRoom1);
            this.Controls.Add(this.masterRoomType1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PageFrontOffice";
            this.Size = new System.Drawing.Size(850, 533);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MasterRoomType masterRoomType1;
        private MasterRoom masterRoom1;
        private MasterItem masterItem1;
    }
}
