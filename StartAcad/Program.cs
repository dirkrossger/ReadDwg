using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;

using System.Runtime.InteropServices;


namespace StartAcad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Q to quit, C to continue...");
            var an = Console.ReadLine();
            if (an.ToUpper() != "Q")
            {
                string progId = "AutoCAD.Application";

                dynamic cadApp = null;

                try
                {
                    cadApp = Marshal.GetActiveObject(progId);
                    Console.WriteLine("Existing AutoCAD instance found.");
                    cadApp.Visible = true;
                    cadApp.ActiveDocument.SendCommand("(command " + (char)34 + "NETLOAD" + (char)34 + " " +
                                   (char)34 + "C:/temp/ListItems.dll" + (char)34 + ") ");
                    cadApp.ActiveDocument.SendCommand("(command " + (char)34 + "writela" + (char)34 + ")" + " ");
                    cadApp.Visible = false;
                }
                catch
                {
                    Console.WriteLine("No existing AutoCAD instance found - wait!");
                    try
                    {
                        Type t = Type.GetTypeFromProgID(progId);
                        cadApp = Activator.CreateInstance(t);
                        Console.WriteLine("New AutoCAD instance started.");
                    }
                    catch
                    {
                        Console.WriteLine("Cannot start AutoCAD!");
                    }
                }

                if (cadApp != null)
                {
                    cadApp.Visible = true;
                    cadApp.ActiveDocument.SendCommand("(command " + (char)34 + "NETLOAD" + (char)34 + " " +
                                   (char)34 + "C:/temp/ListItems.dll" + (char)34 + ") ");
                    cadApp.ActiveDocument.SendCommand("(command " + (char)34 + "writela" + (char)34 + ")" + " ");
                }

                Console.WriteLine("Press any key to exit...");
                //Console.ReadLine();
            }
        }
    }
}
