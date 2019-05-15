using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Autodesk libraries
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
#endregion

[assembly: CommandClass(typeof(ListItems.Commands))]

namespace ListItems
{
    class Commands
    {
        [CommandMethod("DisplayLayers", "displa", CommandFlags.Modal)]
        public void DisplayLayers()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            List<string> info = LayersToList(db);
            foreach (string lname in info)
                ed.WriteMessage("\nLayer Name: \t{0}", lname);

        }

        [CommandMethod("WriteLayers", "writela", CommandFlags.Modal)]
        public void WriteLayersToFile()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            List<string> info = LayersToList(db);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\temp\WriteLayers.txt"))
            {
                foreach (string lname in info)
                {
                    file.WriteLine(lname);
                }
            }
        }


        public List<string> LayersToList(Database db)
        {
            List<string> lstlay = new List<string>();

            LayerTableRecord layer;
            using (Transaction tr = db.TransactionManager.StartOpenCloseTransaction())
            {
                LayerTable lt = tr.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (ObjectId layerId in lt)
                {
                    layer = tr.GetObject(layerId, OpenMode.ForWrite) as LayerTableRecord;
                    lstlay.Add(layer.Name);
                }

            }
            return lstlay;
        }
    }
}


