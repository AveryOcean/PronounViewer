namespace Viewer
{
    partial class Options
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
            this.profileSaveLocLabel = new System.Windows.Forms.Label();
            this.changeSaveLoc = new System.Windows.Forms.Button();
            this.useLightTheme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile Saving Directory";
            // 
            // profileSaveLocLabel
            // 
            this.profileSaveLocLabel.AutoSize = true;
            this.profileSaveLocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.profileSaveLocLabel.Location = new System.Drawing.Point(14, 74);
            this.profileSaveLocLabel.Name = "profileSaveLocLabel";
            this.profileSaveLocLabel.Size = new System.Drawing.Size(199, 15);
            this.profileSaveLocLabel.TabIndex = 2;
            this.profileSaveLocLabel.Text = "Current: [PROFILESAVELOCATION]";
            // 
            // changeSaveLoc
            // 
            this.changeSaveLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeSaveLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(161)))), ((int)(((byte)(191)))));
            this.changeSaveLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSaveLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeSaveLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.changeSaveLoc.Location = new System.Drawing.Point(17, 102);
            this.changeSaveLoc.Name = "changeSaveLoc";
            this.changeSaveLoc.Size = new System.Drawing.Size(514, 49);
            this.changeSaveLoc.TabIndex = 3;
            this.changeSaveLoc.Text = "Change Save Location";
            this.changeSaveLoc.UseVisualStyleBackColor = false;
            this.changeSaveLoc.Click += new System.EventHandler(this.changeSaveLoc_Click);
            // 
            // useLightTheme
            // 
            this.useLightTheme.AutoSize = true;
            this.useLightTheme.Location = new System.Drawing.Point(17, 157);
            this.useLightTheme.Name = "useLightTheme";
            this.useLightTheme.Size = new System.Drawing.Size(107, 17);
            this.useLightTheme.TabIndex = 4;
            this.useLightTheme.Text = "Use Light Theme";
            this.useLightTheme.UseVisualStyleBackColor = true;
            this.useLightTheme.CheckedChanged += new System.EventHandler(this.useLightTheme_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(541, 274);
            this.Controls.Add(this.useLightTheme);
            this.Controls.Add(this.changeSaveLoc);
            this.Controls.Add(this.profileSaveLocLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label profileSaveLocLabel;
        private System.Windows.Forms.Button changeSaveLoc;
        private System.Windows.Forms.CheckBox useLightTheme;
    }
}