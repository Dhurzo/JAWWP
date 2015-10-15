
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JAWWP
{
    public partial class MainForm : Form
    {
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
            InitializeComponent();
           
            CefSettings settings = new CefSettings();
            settings.CachePath = "./Cookies";
            settings.PersistSessionCookies = true;

            Cef.Initialize(settings);


            CefSharp.WinForms.ChromiumWebBrowser cBrowser = new CefSharp.WinForms.ChromiumWebBrowser("https://web.whatsapp.com")
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
