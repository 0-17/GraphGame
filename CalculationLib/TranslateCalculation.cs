using System.Collections.Generic;

namespace CalculationLib
{
    public static class TranslateCalculation
    {
        private static double stringToCalc(string str, double x)
        {
            string cHandledString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    for (int j = i; j < str.Length; j++)
                    {
                        if (str[j] != ')')
                        {
                            cHandledString += str[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private static string[] seperateBrackets(string term)
        {
            List<int> open = new List<int>();
            List<int> closed = new List<int>();
            for (int i = 0; i < term.Length; i++)
            {
                if (term[i] == '(')
                {
                    open.Add(i);
                }
                else if (term[i] == ')')
                {
                    closed.Add(i);
                }
            }

            if (closed[0] <= open[0])
            {
                return 
            }
            for (int i = 0; i < open.Length(); i++)
            {
                
            }
            
        }      
    }
    
}