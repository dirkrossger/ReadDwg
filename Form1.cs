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
        private AcadApplication a;//声明AutoCAD对象
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new AcadApplicationClass();
            a.Visible = true;
            string strFileName = "C:\\G4P4-S01.dwg";
            a.Application.Update();
            a.Application.Documents.Open(strFileName, false, 1);
            //Autodesk.AutoCAD.Interop.AcadDocument aDocument;
            //Autodesk.AutoCAD.Interop.Common.AcadLayers acDoc;



            //a.ActiveDocument.Layers.Item("IN_SWGEAR_CAB_USED").LayerOn=false;

            //AcadDocument acDocComObj;
            //acDocComObj = acAppComObj.ActiveDocument;

            // Optionally, load your assembly and start your command or if your assembly
            // is demandloaded, simply start the command of your in-process assembly.

            a.ActiveDocument.SendCommand("(command " + (char)34 + "NETLOAD" + (char)34 + " " +
                                    (char)34 + "c:/myapps/mycommands.dll" + (char)34 + ") ");
            TurnLayerOff.Class1.TurnLayerOff(textBox2.Text);
            a.ActiveDocument.SendCommand("TurnLayerOff");
        }
    }
}
