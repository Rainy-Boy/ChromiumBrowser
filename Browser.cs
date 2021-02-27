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
        private string initialUrl = "https://github.com/Rainy-Boy";
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
            // Create the first browser tab
            BrowserTabs.TabPages.Clear();
            AddBrowserTab();
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
            if(e.KeyCode == Keys.Enter)
            {
                Navigate();
            }
        }

        private void Navigate()
        {
            string url = AddressBar.Text;
            

            if (url.Contains("http://") || url.Contains("https://") || url.Contains("www."))
            {
                chromeBrowser.Load(url);
                
            }
            else
            {
                chromeBrowser.Load($"https://duckduckgo.com/?q= {url}");
            }
            AddressBar.Text = chromeBrowser.Address;
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

        private void ButtonAddTab_Click(object sender, EventArgs e)
        {
            AddBrowserTab();
        }

        private void AddBrowserTab()
        {
            var tp = new TabPage();
            tp.Text = "Tab";
            BrowserTabs.TabPages.Add(tp);
            var browser = new ChromiumWebBrowser(initialUrl);
            tp.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            chromeBrowser = browser;
            BrowserTabs.SelectTab(tp);
        }

        private void BrowserTabs_Selected(object sender, TabControlEventArgs e)
        {
            chromeBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];
        }

        private void ButtonTabRemove_Click(object sender, EventArgs e)
        {
            RemoveBrowserTab();
        }

        private void RemoveBrowserTab()
        {
            var tp = BrowserTabs.TabPages[BrowserTabs.TabPages.Count - 1];

            if (BrowserTabs.TabPages.Count > 1)
            {
                BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                tp = BrowserTabs.TabPages[BrowserTabs.TabPages.Count - 1];
                BrowserTabs.SelectTab(tp);
            }
        }
    }
}
