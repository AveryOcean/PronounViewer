﻿namespace Viewer
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.username = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.names = new System.Windows.Forms.Label();
            this.pronouns = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.demoFetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.username.Location = new System.Drawing.Point(12, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(101, 18);
            this.username.TabIndex = 0;
            this.username.Text = "[USERNAME]";
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(12, 48);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(100, 96);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            // 
            // names
            // 
            this.names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.names.Location = new System.Drawing.Point(12, 147);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(101, 294);
            this.names.TabIndex = 2;
            this.names.Text = "Names:\r\n👍 [0]\r\n👎 [-1] \r\n♥ [1] \r\n😛 [2]\r\n💑 [3]";
            // 
            // pronouns
            // 
            this.pronouns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pronouns.Location = new System.Drawing.Point(119, 9);
            this.pronouns.Name = "pronouns";
            this.pronouns.Size = new System.Drawing.Size(227, 432);
            this.pronouns.TabIndex = 3;
            this.pronouns.Text = "Pronouns:\r\n👍 [0]\r\n👎 [-1] \r\n♥ [1] \r\n😛 [2]\r\n💑 [3]";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.age.Location = new System.Drawing.Point(12, 27);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(47, 18);
            this.age.TabIndex = 4;
            this.age.Text = "[AGE]";
            // 
            // demoFetch
            // 
            this.demoFetch.Location = new System.Drawing.Point(641, 379);
            this.demoFetch.Name = "demoFetch";
            this.demoFetch.Size = new System.Drawing.Size(147, 62);
            this.demoFetch.TabIndex = 5;
            this.demoFetch.Text = "Fetch Demo User";
            this.demoFetch.UseVisualStyleBackColor = true;
            this.demoFetch.Click += new System.EventHandler(this.demoFetch_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.demoFetch);
            this.Controls.Add(this.age);
            this.Controls.Add(this.pronouns);
            this.Controls.Add(this.names);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form";
            this.Text = "[USER] - pronouns.page";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label names;
        private System.Windows.Forms.Label pronouns;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Button demoFetch;
    }
}
