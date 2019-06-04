using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AXDBLib;
using AutoCAD;

namespace ObjDbx
{
    //'=================================================================================================
    //' Purpose   : Create an object class for access Autocad via the ObjectDBX
    //'
    //' Date      : 01/19/18
    //' Updated   :
    //'=================================================================================================
    //' Need code to differentiate the various versions of ACAD?
    //' 2018-01-19
    //' Replaced AXDBLib with AXDBLib
    //'=================================================================================================
    //' References Requires
    //' AutoCAD    C:\Program Files\Common Files\Autodesk Shared\acax22enu.tlb
    //' AXDBLib    C:\Program Files\Common Files\Autodesk Shared\axdb22enu.tlb
    //' Scripting  C:\Windows\SysWOW64\scrrun.dll
    //'=================================================================================================

    class Program
    {
        static void Main(string[] args)
        {
            // Start an AutoCAD instance
            AcadApplication acad = new AcadApplication();
            Console.WriteLine("AutoCAD started!");

            //Open an AxDbDocument
            object obj = acad.GetInterfaceObject("ObjectDBX.AxDbDocument.22"); //Acad2018
            AxDbDocument doc = obj as AxDbDocument;

            if (doc == null)
            {
                Console.WriteLine("Cannot open AxDbDocument for some reason!");
                return;
            }
            else
            {
                doc.Open(@"a:\Dropbox\Infratools\2_Presentation\4.0 Automation\Dictionary\test.dwg");
                List<string> dicts = AcDictToList(doc.Database);
                //Console.WriteLine(dicts.Count + " Dictionaries found.");
                //foreach (string s in dicts)
                //    Console.WriteLine(s);

            }
            //Get drawing information
            //Console.WriteLine("Entities in ModelSpace: " + doc.ModelSpace.Count);

            //You can make changes to the entities in AxDbDocument and save the changes back to the drawing file.

            //doc.Save();

            doc = null;
            acad.Quit();
            Console.Read();
        }

        private static List<string> AcLayersToList(AXDBLib.AcadDatabase database)
        {
            List<string> lstlay = new List<string>();

            foreach(AXDBLib.AcadLayer lay in database.Layers)
            {
                lstlay.Add(lay.Name);
            }
            return lstlay;
        }

        private static List<string> AcDictToList(AXDBLib.AcadDatabase database)
        {
            List<string> lstDict = new List<string>();

            AXDBLib.AcadDictionary dict = null;
            Console.WriteLine(database.Dictionaries.Count + " Dictionaries found."); 

            //dict.Name = "ProjektManager";
            //foreach (var dict in database.Dictionaries)
            //{
            //    lstDict.Add(dict..Application);
            //}
            return lstDict;
        }
    }
}
