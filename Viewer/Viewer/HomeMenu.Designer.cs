namespace Viewer
{
    partial class HomeMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savedProfiles = new System.Windows.Forms.ListView();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getUserOnline = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pronoun Viewer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(87, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get Online Profile";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(590, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saved Profiles";
            // 
            // savedProfiles
            // 
            this.savedProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedProfiles.HideSelection = false;
            this.savedProfiles.Location = new System.Drawing.Point(523, 75);
            this.savedProfiles.MultiSelect = false;
            this.savedProfiles.Name = "savedProfiles";
            this.savedProfiles.Size = new System.Drawing.Size(265, 363);
            this.savedProfiles.TabIndex = 3;
            this.savedProfiles.UseCompatibleStateImageBehavior = false;
            this.savedProfiles.View = System.Windows.Forms.View.List;
            this.savedProfiles.ItemActivate += new System.EventHandler(this.savedProfiles_ItemActivate);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(51, 107);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(302, 20);
            this.username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(48, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // getUserOnline
            // 
            this.getUserOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.getUserOnline.Location = new System.Drawing.Point(51, 133);
            this.getUserOnline.Name = "getUserOnline";
            this.getUserOnline.Size = new System.Drawing.Size(302, 58);
            this.getUserOnline.TabIndex = 6;
            this.getUserOnline.Text = "Get User";
            this.getUserOnline.UseVisualStyleBackColor = true;
            this.getUserOnline.Click += new System.EventHandler(this.getUserOnline_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Made with ♥ by AveryOcean";
            // 
            // reload
            // 
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reload.Location = new System.Drawing.Point(382, 399);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(135, 39);
            this.reload.TabIndex = 9;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getUserOnline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.savedProfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeMenu";
            this.Text = "Pronoun Viewer";
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView savedProfiles;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getUserOnline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reload;
    }
}