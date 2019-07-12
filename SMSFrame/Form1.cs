using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SMSFrame
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            DirectoryCheck();
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = @"C:\KDM\SMSF\Cache";
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://messages.google.com/web");
            chromeBrowser.MenuHandler = new CustomMenuHandler { MainForm = this };
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            chromeBrowser.LoadError += ChromeBrowser_LoadError;
            chromeBrowser.MouseUp += ChromeBrowser_MouseUp;
            chromeBrowser.MouseClick += ChromeBrowser_MouseClick;
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void ChromeBrowser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                QuickSettings.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void ChromeBrowser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                QuickSettings.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void ChromeBrowser_LoadError(object sender, LoadErrorEventArgs e)
        {
            if (ErrorSplash.InvokeRequired) ErrorSplash.Invoke(new Action(() => ErrorSplash.Visible = true));
            else ErrorSplash.Visible = true;
        }
        System.Windows.Forms.Timer delayTimer;
        private bool IsLoading = false;
        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (e.IsLoading)
            {
                IsLoading = true;
                if (LoadingSplash.InvokeRequired) LoadingSplash.Invoke(new Action(() => LoadingSplash.Visible = true));
                else LoadingSplash.Visible = true;
            }
            else if (!e.IsLoading)
            {
                IsLoading = false;
                delayTimer = new System.Windows.Forms.Timer { Interval = 500 };
                delayTimer.Tick += DoneLoadingDelay;
                delayTimer.Start();
            }
        }
        private void DoneLoadingDelay(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading)
                {
                    delayTimer.Stop();
                    if (LoadingSplash.InvokeRequired) LoadingSplash.Invoke(new Action(() => LoadingSplash.Visible = false));
                    else LoadingSplash.Visible = false;
                }
            }
            catch { }
        }

        Properties.Settings AppSettings = Properties.Settings.Default;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                versionToolStripMenuItem.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

            Location = AppSettings.Location;
            Size = AppSettings.Size;

         
        }
        private void DirectoryCheck()
        {
            Directory.CreateDirectory(@"C:\KDM");
            Directory.CreateDirectory(@"C:\KDM\SMSF");
            Directory.CreateDirectory(@"C:\KDM\SMSF\Exports");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            delayTimer.Stop();
            AppSettings.Location = Location;
            AppSettings.Size = Size;
            AppSettings.Save();
            Cef.Shutdown();
            Hide();
            Application.Exit();
           // Environment.Exit(0);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        public void CallQuickSettings()
        {
            QuickSettings.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }
    }



    public class CustomMenuHandler : CefSharp.IContextMenuHandler
    {
      public  Form1 MainForm { get; set; }
        public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            MainForm.CallQuickSettings();
            model.Clear();
        }

        public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
