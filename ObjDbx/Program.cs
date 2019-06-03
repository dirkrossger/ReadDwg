using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AXDBLib;
using AutoCAD;

namespace ObjDbx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start an AutoCAD instance
            AcadApplication acad = new AcadApplication();
            Console.WriteLine("AutoCAD started!");

            //Open an AxDbDocument
            object obj = acad.GetInterfaceObject("ObjectDBX.AxDbDocument.17"); //Acad2018
            AxDbDocument doc = obj as AxDbDocument;


            if (doc == null)
            {
                Console.WriteLine("Cannot open AxDbDocument for some reason!");
                return;
            }


            //Get drawing information
            Console.WriteLine("Entities in ModelSpace: " + doc.ModelSpace.Count);

            //You can make changes to the entities in AxDbDocument and save the changes back to the drawing file.


            doc.Save();
        }
    }
}
