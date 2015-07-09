using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AliensOnEarth.ExportFiles
{
    /*
    Author: Avinash
    Company:Multunus Software
    This Class is used to Write the Alien Records to a TXT file
    */
    class ExportToTXT 
    {

        public static void GenerateFile(Hashtable alienInfo)
        {
            Console.WriteLine("Exporting To TXT");
            StreamWriter objWriter;
            try
            {

                objWriter = new StreamWriter(FileNamePaths.filePath + FileNamePaths.fileName + ".txt");
                 objWriter.WriteLine("Alien Record Details");
                 objWriter.WriteLine("----------------------");
                 foreach (DictionaryEntry records in alienInfo)
                 {
                     objWriter.WriteLine(records.Key + " " + records.Value);
                 }
                 Console.WriteLine("Exporting To TXT Completed!");   
                 objWriter.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.WriteLine("Press Enter to Exit!");
                Console.ReadLine();
            }

        }
    }
}
