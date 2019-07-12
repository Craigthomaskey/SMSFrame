namespace SMSFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadingSplash = new System.Windows.Forms.Label();
            this.ErrorSplash = new System.Windows.Forms.Label();
            this.QuickSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingSplash
            // 
            this.LoadingSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingSplash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingSplash.Location = new System.Drawing.Point(0, 0);
            this.LoadingSplash.Name = "LoadingSplash";
            this.LoadingSplash.Size = new System.Drawing.Size(464, 792);
            this.LoadingSplash.TabIndex = 1;
            this.LoadingSplash.Text = "Loading...";
            this.LoadingSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorSplash
            // 
            this.ErrorSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorSplash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorSplash.Location = new System.Drawing.Point(0, 0);
            this.ErrorSplash.Name = "ErrorSplash";
            this.ErrorSplash.Size = new System.Drawing.Size(464, 792);
            this.ErrorSplash.TabIndex = 2;
            this.ErrorSplash.Text = "Load error.";
            this.ErrorSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorSplash.Visible = false;
            // 
            // QuickSettings
            // 
            this.QuickSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.QuickSettings.Name = "QuickSettings";
            this.QuickSettings.ShowImageMargin = false;
            this.QuickSettings.Size = new System.Drawing.Size(89, 54);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(85, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(464, 792);
            this.Controls.Add(this.ErrorSplash);
            this.Controls.Add(this.LoadingSplash);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SMSFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QuickSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoadingSplash;
        private System.Windows.Forms.Label ErrorSplash;
        private System.Windows.Forms.ContextMenuStrip QuickSettings;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

