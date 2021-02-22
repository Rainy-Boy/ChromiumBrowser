
namespace ChromiumBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ButtonBack = new System.Windows.Forms.ToolStripButton();
            this.ButtonForward = new System.Windows.Forms.ToolStripButton();
            this.AddressBar = new System.Windows.Forms.ToolStripTextBox();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.ButtonDarkmode = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonBack,
            this.ButtonForward,
            this.AddressBar,
            this.ButtonRefresh,
            this.ButtonDarkmode});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1033, 57);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ButtonBack
            // 
            this.ButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBack.Image")));
            this.ButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(36, 52);
            this.ButtonBack.Text = "🢀";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonForward
            // 
            this.ButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("ButtonForward.Image")));
            this.ButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonForward.Name = "ButtonForward";
            this.ButtonForward.Size = new System.Drawing.Size(36, 52);
            this.ButtonForward.Text = "🢂";
            this.ButtonForward.Click += new System.EventHandler(this.ButtonForward_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(600, 57);
            this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddresBar_KeyDown);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonRefresh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(48, 52);
            this.ButtonRefresh.Text = "⭮";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonDarkmode
            // 
            this.ButtonDarkmode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonDarkmode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonDarkmode.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDarkmode.Image")));
            this.ButtonDarkmode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDarkmode.Name = "ButtonDarkmode";
            this.ButtonDarkmode.Size = new System.Drawing.Size(41, 52);
            this.ButtonDarkmode.Text = "🌓";
            this.ButtonDarkmode.Click += new System.EventHandler(this.ButtonDarkmode_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 529);
            this.Controls.Add(this.toolStrip);
            this.Name = "Browser";
            this.Text = "Form1";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ButtonRefresh;
        private System.Windows.Forms.ToolStripTextBox AddressBar;
        private System.Windows.Forms.ToolStripButton ButtonBack;
        private System.Windows.Forms.ToolStripButton ButtonForward;
        private System.Windows.Forms.ToolStripButton ButtonDarkmode;
    }
}

