using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bentley.MicroStation.InteropServices;
using BCOM = Bentley.Interop.MicroStationDGN;

namespace csAddins
{
    //internal表示该类只能在本程序集中使用，sealed表示该类不可被继承
    [Bentley.MicroStation.AddInAttribute
                 (KeyinTree = "csAddins.commands.xml", MdlTaskID = "CSADDINS")]
    internal sealed class MyAddin : Bentley.MicroStation.AddIn
    {
        public static MyAddin s_addin = null;
        private MyAddin(System.IntPtr mdlDesc)
            : base(mdlDesc)
        {
            s_addin = this;
        }
        protected override int Run(string[] commandLine)
        {
            BCOM.Application app = Utilities.ComApp;
            app.CadInputQueue.SendKeyin("csAddins DemoForm Toolbar");
            return 0;
        }
    }
}
