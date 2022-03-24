using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
       
        List<int> Parameters;
       

        public Report (string text,  List<int> parameters)
        {
            Parameters = parameters;
            Parameters.ToString();

        }

        public void OutputConsole()
        { 
            
            List<string> report = new List<string>() { "Sentences: " + Parameters[0], "Vowels: " + Parameters[1], "Consantants: " + Parameters[2], "Upper case letters: " + Parameters[3], "Lower case letters: " + Parameters[4], "Max characters: " + Parameters[5] };
           foreach(string reports in report)
            {
                Console.WriteLine(reports);
            }
           
        }
            
    }
}
