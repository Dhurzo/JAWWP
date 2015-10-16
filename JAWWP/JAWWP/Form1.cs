
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JAWWP
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Chromium browser
        /// </summary>
        CefSharp.WinForms.ChromiumWebBrowser cBrowser;

        CefSettings settings;
        /// <summary>
        /// Ctor Main Window
        /// 
        /// JAWWP: JUST ANOTHER WHATSAPP WEB PORT
        /// AUTHOR: JUAN ANGEL LOPEZ - DHURZO
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FIRED WHEN FORM IS LOAD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {

            settings = new CefSettings();
            settings.CachePath = "./Cookies";
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings);

            cBrowser = new CefSharp.WinForms.ChromiumWebBrowser("https://web.whatsapp.com")
            {
                Dock = DockStyle.Fill,
                ContextMenu = new ContextMenu(),
                ContextMenuStrip = new ContextMenuStrip(),
                MenuHandler =  new CustomMenuHandler(),
            };

            this.Controls.Add(cBrowser);
           
        }

    }
}
