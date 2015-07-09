using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AliensOnEarth.ExportFiles
{
    /*
    Author: Avinash
    Company:Multunus Software
    This Class is used to Check the Format and Load Class Dynamically using Reflections and Hence supports adding of new Format without modifying the Application Code
    */
    class ExportFile
    {

        public static void CheckFormat(AlienInformation alienDetails)
        {
            try
            {
                //Dynamically getting the Class name of the Format
                Type calledType = Type.GetType("AliensOnEarth.ExportFiles.ExportTo" + alienDetails.getDataFormat());
                MethodInfo mi = calledType.GetMethod("GenerateFile");

                calledType.InvokeMember(mi.Name, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, new Object[] { FormatAlienRecord.FormatAlienData(alienDetails) });


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid Format---Check Your Format Again");


            }

        }
    }
}
