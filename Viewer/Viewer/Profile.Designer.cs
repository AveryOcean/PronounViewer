namespace Viewer
{
    partial class Profile
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
            this.saveProfile = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.wordsList = new System.Windows.Forms.ListView();
            this.pronounsList = new System.Windows.Forms.ListView();
            this.namesList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.age = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.links = new System.Windows.Forms.ListView();
            this.flags = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveProfile
            // 
            this.saveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveProfile.Location = new System.Drawing.Point(920, 397);
            this.saveProfile.Name = "saveProfile";
            this.saveProfile.Size = new System.Drawing.Size(136, 41);
            this.saveProfile.TabIndex = 5;
            this.saveProfile.Text = "Save Profile";
            this.saveProfile.UseVisualStyleBackColor = true;
            this.saveProfile.Click += new System.EventHandler(this.saveProfile_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::Viewer.Properties.Resources.Default_Profile;
            this.profilePicture.Location = new System.Drawing.Point(12, 107);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(196, 111);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            // 
            // wordsList
            // 
            this.wordsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.wordsList.ForeColor = System.Drawing.Color.White;
            this.wordsList.HideSelection = false;
            this.wordsList.Location = new System.Drawing.Point(215, 224);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(531, 214);
            this.wordsList.TabIndex = 6;
            this.wordsList.UseCompatibleStateImageBehavior = false;
            // 
            // pronounsList
            // 
            this.pronounsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pronounsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.pronounsList.ForeColor = System.Drawing.Color.White;
            this.pronounsList.HideSelection = false;
            this.pronounsList.Location = new System.Drawing.Point(215, 107);
            this.pronounsList.Name = "pronounsList";
            this.pronounsList.Size = new System.Drawing.Size(531, 111);
            this.pronounsList.TabIndex = 7;
            this.pronounsList.UseCompatibleStateImageBehavior = false;
            // 
            // namesList
            // 
            this.namesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.namesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.namesList.ForeColor = System.Drawing.Color.White;
            this.namesList.HideSelection = false;
            this.namesList.Location = new System.Drawing.Point(12, 224);
            this.namesList.Name = "namesList";
            this.namesList.Size = new System.Drawing.Size(197, 217);
            this.namesList.TabIndex = 8;
            this.namesList.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.username);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 89);
            this.panel1.TabIndex = 12;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(2, 17);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 15);
            this.age.TabIndex = 1;
            this.age.Text = "[AGE]";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(82, 15);
            this.username.TabIndex = 0;
            this.username.Text = "[USERNAME]";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.description);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(215, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 89);
            this.panel2.TabIndex = 13;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(94, 15);
            this.description.TabIndex = 0;
            this.description.Text = "[DESCRIPTION]";
            // 
            // links
            // 
            this.links.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.links.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.links.ForeColor = System.Drawing.Color.White;
            this.links.HideSelection = false;
            this.links.Location = new System.Drawing.Point(752, 12);
            this.links.Name = "links";
            this.links.Size = new System.Drawing.Size(162, 426);
            this.links.TabIndex = 14;
            this.links.UseCompatibleStateImageBehavior = false;
            this.links.View = System.Windows.Forms.View.List;
            this.links.ItemActivate += new System.EventHandler(this.links_ItemActivate);
            // 
            // flags
            // 
            this.flags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.flags.ForeColor = System.Drawing.Color.White;
            this.flags.HideSelection = false;
            this.flags.Location = new System.Drawing.Point(920, 12);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(136, 379);
            this.flags.TabIndex = 15;
            this.flags.UseCompatibleStateImageBehavior = false;
            this.flags.View = System.Windows.Forms.View.List;
            this.flags.ItemActivate += new System.EventHandler(this.flags_ItemActivate);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.flags);
            this.Controls.Add(this.links);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.namesList);
            this.Controls.Add(this.pronounsList);
            this.Controls.Add(this.wordsList);
            this.Controls.Add(this.saveProfile);
            this.Controls.Add(this.profilePicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Name = "Profile";
            this.Text = "[USER] - pronouns.page";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button saveProfile;
        private System.Windows.Forms.ListView wordsList;
        private System.Windows.Forms.ListView pronounsList;
        private System.Windows.Forms.ListView namesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.ListView links;
        private System.Windows.Forms.ListView flags;
    }
}

