namespace advertisement
{
    partial class FormVideo
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDisplayList = new System.Windows.Forms.ComboBox();
            this.listVideo = new System.Windows.Forms.ListBox();
            this.btnPlayVideo = new FontAwesome.Sharp.IconButton();
            this.btnSelectFile = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(143)))), ((int)(((byte)(61)))));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.cmbDisplayList);
            this.panelDesktop.Controls.Add(this.btnPlayVideo);
            this.panelDesktop.Controls.Add(this.btnSelectFile);
            this.panelDesktop.Controls.Add(this.listVideo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(779, 469);
            this.panelDesktop.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(164, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Display";
            // 
            // cmbDisplayList
            // 
            this.cmbDisplayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDisplayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayList.FormattingEnabled = true;
            this.cmbDisplayList.Location = new System.Drawing.Point(155, 390);
            this.cmbDisplayList.Name = "cmbDisplayList";
            this.cmbDisplayList.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplayList.TabIndex = 11;
            // 
            // listVideo
            // 
            this.listVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listVideo.FormattingEnabled = true;
            this.listVideo.HorizontalScrollbar = true;
            this.listVideo.ItemHeight = 18;
            this.listVideo.Location = new System.Drawing.Point(105, 67);
            this.listVideo.Name = "listVideo";
            this.listVideo.Size = new System.Drawing.Size(570, 274);
            this.listVideo.TabIndex = 5;
            this.listVideo.SelectedIndexChanged += new System.EventHandler(this.listVideo_SelectedIndexChanged);
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayVideo.BackColor = System.Drawing.Color.Teal;
            this.btnPlayVideo.FlatAppearance.BorderSize = 0;
            this.btnPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayVideo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlayVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayVideo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlayVideo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPlayVideo.IconColor = System.Drawing.Color.Brown;
            this.btnPlayVideo.IconSize = 16;
            this.btnPlayVideo.Location = new System.Drawing.Point(502, 381);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Rotation = 0D;
            this.btnPlayVideo.Size = new System.Drawing.Size(109, 32);
            this.btnPlayVideo.TabIndex = 9;
            this.btnPlayVideo.Text = "Play Video";
            this.btnPlayVideo.UseVisualStyleBackColor = false;
            this.btnPlayVideo.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectFile.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelectFile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSelectFile.IconColor = System.Drawing.Color.Brown;
            this.btnSelectFile.IconSize = 16;
            this.btnSelectFile.Location = new System.Drawing.Point(335, 381);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Rotation = 0D;
            this.btnSelectFile.Size = new System.Drawing.Size(109, 32);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 469);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormVideo";
            this.Text = "FormVideo";
            this.Load += new System.EventHandler(this.FormVideo_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.ListBox listVideo;
        private FontAwesome.Sharp.IconButton btnSelectFile;
        private FontAwesome.Sharp.IconButton btnPlayVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDisplayList;
    }
}