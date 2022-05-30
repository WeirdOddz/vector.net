namespace vector.net
{
    partial class vector
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
            this.components = new System.ComponentModel.Container();
            this.TopStrip = new System.Windows.Forms.Panel();
            this.bt_theme = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_file = new System.Windows.Forms.Button();
            this.Frame = new System.Windows.Forms.Panel();
            this.dropdown_File = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.svgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bmpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TopStrip.SuspendLayout();
            this.dropdown_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopStrip
            // 
            this.TopStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopStrip.Controls.Add(this.bt_theme);
            this.TopStrip.Controls.Add(this.bt_edit);
            this.TopStrip.Controls.Add(this.bt_file);
            this.TopStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopStrip.Location = new System.Drawing.Point(0, 0);
            this.TopStrip.Name = "TopStrip";
            this.TopStrip.Size = new System.Drawing.Size(800, 36);
            this.TopStrip.TabIndex = 0;
            // 
            // bt_theme
            // 
            this.bt_theme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_theme.FlatAppearance.BorderSize = 0;
            this.bt_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_theme.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_theme.Location = new System.Drawing.Point(174, 7);
            this.bt_theme.Name = "bt_theme";
            this.bt_theme.Size = new System.Drawing.Size(75, 23);
            this.bt_theme.TabIndex = 2;
            this.bt_theme.Text = "Theme";
            this.bt_theme.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_edit.FlatAppearance.BorderSize = 0;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_edit.Location = new System.Drawing.Point(93, 7);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(75, 23);
            this.bt_edit.TabIndex = 1;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            // 
            // bt_file
            // 
            this.bt_file.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_file.FlatAppearance.BorderSize = 0;
            this.bt_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_file.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_file.Location = new System.Drawing.Point(12, 7);
            this.bt_file.Name = "bt_file";
            this.bt_file.Size = new System.Drawing.Size(75, 23);
            this.bt_file.TabIndex = 0;
            this.bt_file.Text = "File";
            this.bt_file.UseVisualStyleBackColor = false;
            this.bt_file.Click += new System.EventHandler(this.bt_file_Click);
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frame.Location = new System.Drawing.Point(0, 36);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(800, 414);
            this.Frame.TabIndex = 1;
            // 
            // dropdown_File
            // 
            this.dropdown_File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uToolStripMenuItem});
            this.dropdown_File.Name = "dropdown_File";
            this.dropdown_File.Size = new System.Drawing.Size(95, 48);
            this.dropdown_File.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upscaleToolStripMenuItem,
            this.changeSizeToolStripMenuItem});
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.uToolStripMenuItem.Text = "Size";
            // 
            // upscaleToolStripMenuItem
            // 
            this.upscaleToolStripMenuItem.Name = "upscaleToolStripMenuItem";
            this.upscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upscaleToolStripMenuItem.Text = "Upscale/Downscale";
            // 
            // changeSizeToolStripMenuItem
            // 
            this.changeSizeToolStripMenuItem.Name = "changeSizeToolStripMenuItem";
            this.changeSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeSizeToolStripMenuItem.Text = "Change Size";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pngToolStripMenuItem,
            this.svgToolStripMenuItem,
            this.bmpToolStripMenuItem,
            this.jpgToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pngToolStripMenuItem1,
            this.jpgToolStripMenuItem1,
            this.svgToolStripMenuItem1,
            this.bmpToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // pngToolStripMenuItem
            // 
            this.pngToolStripMenuItem.Name = "pngToolStripMenuItem";
            this.pngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pngToolStripMenuItem.Text = ".png";
            // 
            // svgToolStripMenuItem
            // 
            this.svgToolStripMenuItem.Name = "svgToolStripMenuItem";
            this.svgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.svgToolStripMenuItem.Text = ".svg";
            // 
            // bmpToolStripMenuItem
            // 
            this.bmpToolStripMenuItem.Name = "bmpToolStripMenuItem";
            this.bmpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bmpToolStripMenuItem.Text = ".bmp";
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jpgToolStripMenuItem.Text = ".jpg";
            // 
            // pngToolStripMenuItem1
            // 
            this.pngToolStripMenuItem1.Name = "pngToolStripMenuItem1";
            this.pngToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pngToolStripMenuItem1.Text = ".png";
            // 
            // jpgToolStripMenuItem1
            // 
            this.jpgToolStripMenuItem1.Name = "jpgToolStripMenuItem1";
            this.jpgToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jpgToolStripMenuItem1.Text = ".jpg";
            // 
            // svgToolStripMenuItem1
            // 
            this.svgToolStripMenuItem1.Name = "svgToolStripMenuItem1";
            this.svgToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.svgToolStripMenuItem1.Text = ".svg";
            // 
            // bmpToolStripMenuItem1
            // 
            this.bmpToolStripMenuItem1.Name = "bmpToolStripMenuItem1";
            this.bmpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bmpToolStripMenuItem1.Text = ".bmp";
            // 
            // vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frame);
            this.Controls.Add(this.TopStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "vector";
            this.Text = "vector.net";
            this.TopStrip.ResumeLayout(false);
            this.dropdown_File.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopStrip;
        private Button bt_theme;
        private Button bt_edit;
        private Button bt_file;
        private Panel Frame;
        private ContextMenuStrip dropdown_File;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem pngToolStripMenuItem;
        private ToolStripMenuItem svgToolStripMenuItem;
        private ToolStripMenuItem bmpToolStripMenuItem;
        private ToolStripMenuItem jpgToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem pngToolStripMenuItem1;
        private ToolStripMenuItem jpgToolStripMenuItem1;
        private ToolStripMenuItem svgToolStripMenuItem1;
        private ToolStripMenuItem bmpToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem uToolStripMenuItem;
        private ToolStripMenuItem upscaleToolStripMenuItem;
        private ToolStripMenuItem changeSizeToolStripMenuItem;
    }
}