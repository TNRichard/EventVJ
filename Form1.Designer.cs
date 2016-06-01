namespace EventVJ
{
    partial class EventVJ_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkbVideoList = new System.Windows.Forms.CheckedListBox();
            this.chkbChapterlist = new System.Windows.Forms.CheckedListBox();
            this.chkbMediaDeviceList = new System.Windows.Forms.CheckedListBox();
            this.chkbPictureList = new System.Windows.Forms.CheckedListBox();
            this.cmsAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMediaDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMedia = new System.Windows.Forms.Button();
            this.openVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.openMediaDevice = new System.Windows.Forms.OpenFileDialog();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmsAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbVideoList
            // 
            this.chkbVideoList.FormattingEnabled = true;
            this.chkbVideoList.Location = new System.Drawing.Point(3, 48);
            this.chkbVideoList.Name = "chkbVideoList";
            this.chkbVideoList.Size = new System.Drawing.Size(120, 94);
            this.chkbVideoList.TabIndex = 1;
            // 
            // chkbChapterlist
            // 
            this.chkbChapterlist.FormattingEnabled = true;
            this.chkbChapterlist.Location = new System.Drawing.Point(129, 48);
            this.chkbChapterlist.Name = "chkbChapterlist";
            this.chkbChapterlist.Size = new System.Drawing.Size(120, 94);
            this.chkbChapterlist.TabIndex = 3;
            // 
            // chkbMediaDeviceList
            // 
            this.chkbMediaDeviceList.FormattingEnabled = true;
            this.chkbMediaDeviceList.Location = new System.Drawing.Point(3, 148);
            this.chkbMediaDeviceList.Name = "chkbMediaDeviceList";
            this.chkbMediaDeviceList.Size = new System.Drawing.Size(120, 94);
            this.chkbMediaDeviceList.TabIndex = 4;
            // 
            // chkbPictureList
            // 
            this.chkbPictureList.FormattingEnabled = true;
            this.chkbPictureList.Location = new System.Drawing.Point(3, 248);
            this.chkbPictureList.Name = "chkbPictureList";
            this.chkbPictureList.Size = new System.Drawing.Size(120, 94);
            this.chkbPictureList.TabIndex = 5;
            // 
            // cmsAdd
            // 
            this.cmsAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVideoToolStripMenuItem,
            this.addMediaDeviceToolStripMenuItem,
            this.addPictureToolStripMenuItem});
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(166, 70);
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addVideoToolStripMenuItem.Text = "add Video";
            this.addVideoToolStripMenuItem.Click += new System.EventHandler(this.cmsAddVideo_Click);
            // 
            // addMediaDeviceToolStripMenuItem
            // 
            this.addMediaDeviceToolStripMenuItem.Name = "addMediaDeviceToolStripMenuItem";
            this.addMediaDeviceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addMediaDeviceToolStripMenuItem.Text = "add MediaDevice";
            this.addMediaDeviceToolStripMenuItem.Click += new System.EventHandler(this.cmsAddMediaDevice_Click);
            // 
            // addPictureToolStripMenuItem
            // 
            this.addPictureToolStripMenuItem.Name = "addPictureToolStripMenuItem";
            this.addPictureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addPictureToolStripMenuItem.Text = "add Picture";
            this.addPictureToolStripMenuItem.Click += new System.EventHandler(this.cmsAddPicture_Click);
            // 
            // btnAddMedia
            // 
            this.btnAddMedia.Image = global::EventVJ.Properties.Resources.comments_32x32;
            this.btnAddMedia.Location = new System.Drawing.Point(3, 0);
            this.btnAddMedia.Name = "btnAddMedia";
            this.btnAddMedia.Size = new System.Drawing.Size(44, 42);
            this.btnAddMedia.TabIndex = 2;
            this.btnAddMedia.UseVisualStyleBackColor = true;
            this.btnAddMedia.Click += new System.EventHandler(this.btnAddMedia_Click);
            // 
            // openVideoDialog
            // 
            this.openVideoDialog.FileName = "openVideoDialog";
            // 
            // openMediaDevice
            // 
            this.openMediaDevice.FileName = "openMediaDevice";
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPicture";
            // 
            // EventVJ_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 725);
            this.Controls.Add(this.chkbPictureList);
            this.Controls.Add(this.chkbMediaDeviceList);
            this.Controls.Add(this.chkbChapterlist);
            this.Controls.Add(this.btnAddMedia);
            this.Controls.Add(this.chkbVideoList);
            this.Name = "EventVJ_main";
            this.Text = "EventVJ";
            this.cmsAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkbVideoList;
        private System.Windows.Forms.Button btnAddMedia;
        private System.Windows.Forms.CheckedListBox chkbChapterlist;
        private System.Windows.Forms.CheckedListBox chkbMediaDeviceList;
        private System.Windows.Forms.CheckedListBox chkbPictureList;
        private System.Windows.Forms.ContextMenuStrip cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem addVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMediaDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPictureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openVideoDialog;
        private System.Windows.Forms.OpenFileDialog openMediaDevice;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
    }
}

