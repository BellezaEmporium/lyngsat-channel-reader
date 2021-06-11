using System.Collections.Generic;
using System.IO;
using System.Text;
using Metier.Entities;

namespace Metier
{
    public class Controller
    {
        // Takes care of the multithreaded file reading execution.
        public static List<LyngSatStructure> ReadFile(string filePath)
        {
            var fichierATraiter = File.ReadAllLines(filePath, Encoding.UTF8);
            List<LyngSatStructure> lsfile = new List<LyngSatStructure>();
            foreach (string s in fichierATraiter)
            {
                string[] splittedString = s.Split('/');
                lsfile.Add(new LyngSatStructure(splittedString[0], splittedString[1]));
            };
            // Reorder the lists before sending them to the view.
            return lsfile;
        }

        public static void SendResults(List<LyngSatStructure> list) => Model.WriteChannels(list);
    }
}
