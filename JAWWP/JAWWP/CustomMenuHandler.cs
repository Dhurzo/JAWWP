using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JAWWP
{
    public class CustomMenuHandler : IContextMenuHandler
    {   
        /// <summary>
        /// Clear context (right mouse click) Menu.
        /// </summary>
        /// <param name="browserControl">-</param>
        /// <param name="browser">-</param>
        /// <param name="frame">-</param>
        /// <param name="parameters">-</param>
        /// <param name="model">-</param>
        void IContextMenuHandler.OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            bool result = model.Clear();
        }
        /// <summary>
        /// Do something when menu command detected.
        /// </summary>
        /// <param name="browserControl"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        /// <param name="parameters"></param>
        /// <param name="commandId"></param>
        /// <param name="eventFlags"></param>
        /// <returns></returns>
        bool IContextMenuHandler.OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }
        /// <summary>
        /// Do nothing
        /// </summary>
        /// <param name="browserControl"></param>
        /// <param name="browser"></param>
        /// <param name="frame"></param>
        void IContextMenuHandler.OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

    }
}
