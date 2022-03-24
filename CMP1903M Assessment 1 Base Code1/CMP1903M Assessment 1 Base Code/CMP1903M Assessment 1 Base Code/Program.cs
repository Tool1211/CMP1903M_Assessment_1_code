//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            
            Input input = new Input();
            
            Console.WriteLine("Do you want to enter the text via the keyboard?\r\nDo you want to read in the text from a file?\r\nEnter the words: User or Computer");
            bool UserChecker = true;
            
            // UserInput is used for the user to pick between User or computer. The while loop and switch makes sure the user has inputted the correct infomation.
            while(UserChecker == true)
            {   String UserInput = Console.ReadLine();
                Console.WriteLine("You have selected: " + UserInput);
                
                switch (UserInput)
                {
                    case "User":
                        UserChecker = false;
                        input.manualTextInput(UserInput);
                        break;

                    case "Computer":
                        UserChecker = false;
                        input.fileTextInput(UserInput);
                        break;
                    
                    default:
                        Console.WriteLine("Try again, make sure to have a capital letter at the start!!!");
                        UserChecker = true;
                        break;
                }
            }
            

            


           
            Analyse analyse = new Analyse();
            //Pass the text input to the 'analyseText' method
            analyse.analyseText(input.text);
            
            //Receive a list of integers back
            parameters = analyse.analyseText(input.text);
            
            Report report = new Report(input.text,parameters);
            
            //Report the results of the analysis
            report.OutputConsole();

            


        }
        
        
    
    }
}
