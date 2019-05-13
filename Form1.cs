using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using Autodesk.AutoCAD;
using System.IO;

namespace ReadDwgFile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private Autodesk.AutoCAD.Interop.AcadApplication app;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            // "AutoCAD.Application.17" uses 2007 or 2008,

            //  whichever was most recently run
            // "AutoCAD.Application.17.1" uses 2008, specifically
            const string progID = "AutoCAD.Application";

            AcadApplication acApp = null;
            try
            {
                acApp = (AcadApplication)Marshal.GetActiveObject(progID);
            }
            catch
            {
                try
                {
                    Type acType =
                      Type.GetTypeFromProgID(progID);
                    acApp =
                      (AcadApplication)Activator.CreateInstance(
                        acType,
                        true
                      );
                }
                catch
                {
                    MessageBox.Show(
                      "Cannot create object of type \"" +
                      progID + "\""
                    );
                }
            }

            if (acApp != null)
            {
                // By the time this is reached AutoCAD is fully
                // functional and can be interacted with through code
                acApp.Visible = true;
                //acApp.ActiveDocument.SendCommand("_MYCOMMAND ");
                acApp.ActiveDocument.SendCommand("(command " + (char)34 + "NETLOAD" + (char)34 + " " +
                                   (char)34 + "A:/Github/ListItems/bin/Debug/ListItems.dll" + (char)34 + ") ");
            }

           
        }
    }
}
