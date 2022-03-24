using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        private string filetext = File.ReadAllText(@"C:\Users\ryana\Downloads\CMP1903M Assessment 1 Base Code1\CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code\Sample.txt");



        public string text = "nothing";

       
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput(string Text)
        {
            Console.WriteLine("write text here");
            
            text = Text;
            
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {


            text = filetext;
            Console.WriteLine("Files content:\r\n{0}", filetext);
            
            return text;
        }

    }
}
