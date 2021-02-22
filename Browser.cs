using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ChromiumBrowser
{
    public partial class Browser : Form
    {
        public ChromiumWebBrowser chromeBrowser = null;
        private string initialUrl = "https://datorium.eu";
        private bool lightmode = true;

        public Browser()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(initialUrl);
            // Add it to the form and fill it to the form window.
            AddressBar.Text = chromeBrowser.Address;
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
            AddressBar.Text = chromeBrowser.Address;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            chromeBrowser.Back();
            AddressBar.Text = chromeBrowser.Address;
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
            AddressBar.Text = chromeBrowser.Address;
        }

        private void AddresBar_KeyDown(object sender, KeyEventArgs e)
        {
            string url = AddressBar.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (url.Contains("http://www") || url.Contains("https://www"))
                {
                    chromeBrowser.Load(url);
                }
                else
                {
                    chromeBrowser.Load($"https://duckduckgo.com/?t=ffab&q= {url}");
                }
            }
            
        }

        private void ButtonDarkmode_Click(object sender, EventArgs e)
        {
            if (lightmode == true)
            {
                toolStrip.BackColor = Color.DarkBlue;
                AddressBar.BackColor = Color.DarkBlue;
                AddressBar.ForeColor = Color.White;
                lightmode = false;
            }
            else
            {
                toolStrip.BackColor = Color.White;
                AddressBar.BackColor = Color.White;
                AddressBar.ForeColor = Color.Black;
                lightmode = true;
            }
            
        }
    }
}
