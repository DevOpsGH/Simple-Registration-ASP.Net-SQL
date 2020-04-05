namespace Registration_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.activeTab = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.moveForm = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateRecord1 = new Registration_Form.updateRecord();
            this.searchRecord1 = new Registration_Form.searchRecord();
            this.helpMe1 = new Registration_Form.helpMe();
            this.emergencyTab1 = new Registration_Form.emergencyTab();
            this.addRecord1 = new Registration_Form.addRecord();
            this.leftPanel.SuspendLayout();
            this.moveForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.button4);
            this.leftPanel.Controls.Add(this.activeTab);
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.insert);
            this.leftPanel.Controls.Add(this.search);
            this.leftPanel.Location = new System.Drawing.Point(0, 31);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(180, 489);
            this.leftPanel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Registration_Form.Properties.Resources.icons8_help_30;
            this.button4.Location = new System.Drawing.Point(147, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // activeTab
            // 
            this.activeTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.activeTab.Location = new System.Drawing.Point(0, 120);
            this.activeTab.Name = "activeTab";
            this.activeTab.Size = new System.Drawing.Size(5, 40);
            this.activeTab.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Emergency Tab";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(0, 120);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(180, 40);
            this.insert.TabIndex = 3;
            this.insert.Text = "Add Record";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(0, 160);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 40);
            this.search.TabIndex = 4;
            this.search.Text = "Search Record";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveForm
            // 
            this.moveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moveForm.Controls.Add(this.exit);
            this.moveForm.Controls.Add(this.minimize);
            this.moveForm.Location = new System.Drawing.Point(0, 0);
            this.moveForm.Name = "moveForm";
            this.moveForm.Size = new System.Drawing.Size(780, 30);
            this.moveForm.TabIndex = 0;
            this.moveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm_MouseDown);
            this.moveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveForm_MouseMove);
            this.moveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveForm_MouseUp);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(740, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 30);
            this.exit.TabIndex = 1;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(700, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 30);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateRecord1);
            this.panel2.Controls.Add(this.searchRecord1);
            this.panel2.Controls.Add(this.helpMe1);
            this.panel2.Controls.Add(this.emergencyTab1);
            this.panel2.Controls.Add(this.addRecord1);
            this.panel2.Location = new System.Drawing.Point(185, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 480);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Registration_Form.Properties.Resources.demo_exhibition_demonstration_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 100);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // updateRecord1
            // 
            this.updateRecord1.Location = new System.Drawing.Point(0, 0);
            this.updateRecord1.Name = "updateRecord1";
            this.updateRecord1.Size = new System.Drawing.Size(590, 480);
            this.updateRecord1.TabIndex = 4;
            // 
            // searchRecord1
            // 
            this.searchRecord1.Location = new System.Drawing.Point(0, 0);
            this.searchRecord1.Name = "searchRecord1";
            this.searchRecord1.Size = new System.Drawing.Size(590, 480);
            this.searchRecord1.TabIndex = 3;
            // 
            // helpMe1
            // 
            this.helpMe1.Location = new System.Drawing.Point(0, 0);
            this.helpMe1.Name = "helpMe1";
            this.helpMe1.Size = new System.Drawing.Size(590, 480);
            this.helpMe1.TabIndex = 2;
            // 
            // emergencyTab1
            // 
            this.emergencyTab1.Location = new System.Drawing.Point(0, 0);
            this.emergencyTab1.Name = "emergencyTab1";
            this.emergencyTab1.Size = new System.Drawing.Size(590, 480);
            this.emergencyTab1.TabIndex = 1;
            // 
            // addRecord1
            // 
            this.addRecord1.Location = new System.Drawing.Point(0, 0);
            this.addRecord1.Name = "addRecord1";
            this.addRecord1.Size = new System.Drawing.Size(590, 480);
            this.addRecord1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.moveForm);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.moveForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel moveForm;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel activeTab;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private updateRecord updateRecord1;
        private searchRecord searchRecord1;
        private helpMe helpMe1;
        private emergencyTab emergencyTab1;
        private addRecord addRecord1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

