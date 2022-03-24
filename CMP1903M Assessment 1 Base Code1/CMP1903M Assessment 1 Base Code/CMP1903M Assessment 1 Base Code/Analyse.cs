using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    { 
        
         
    
        int len;


        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {

 List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i <= 5; i++)
            {
                values.Add(0);
            }

            //List of integers to hold the first five measurements:
            len = input.Length;

            // Sentences are counted here
            for (int i = 0; i < len; i++)
            {
                if( input[i] == '.' )
                {
                    values[0]++;
                }



                // Vowels and Consonants are counted here.
                if (input[i] == 'a' || input[i] == 'i' || input[i] == 'u' || input[i] == 'o' || input[i] == 'e' || input[i] == 'A' || input[i] == 'I' || input[i] == 'U' || input[i] == 'E' || input[i] == 'O')
                    {
                    values[1]++;
                }
                    else if (input[i] >= 'a' && input[i] <= 'z' || input[i] >= 'A' && input[i] <= 'Z')
                    {
                    values[2]++;
                }

                    // Upper, lower case letters and Max characters are counted here.
                    if (char.IsUpper(input[i]))
                    {
                    values[3]++;
                    values[5]++;
                }
                    else if (char.IsLower(input[i]))
                    {
                    values[4]++;
                    values[5]++;

                }
                    

                
                
            }
            

           

            return values;
        }
    }
}
