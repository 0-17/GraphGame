using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace CalculationLib
{
    public static class TranslateCalculation
    {
        public static string[] seperateBrackets(string term)
        {
            var result = term.Split().Where(x => x.StartsWith("(") && x.EndsWith(")")).ToList();
            return result.ToArray();
        }

        public static List<TempBracketHelper> seperateBracketsWell(string term)
        {
            term = Regex.Replace(term, @"\s+", "");
            List<TempBracketHelper> br = new List<TempBracketHelper>();
            int onum = 0;
            int cnum = 0;
            for (int i = 0; i < term.Length; i++)
            {
                if (term[i] == '(')
                {
                    for (int j = i+1; j < term.Length; j++)
                    {
                        if (term[j] == '(')
                        {
                            onum += 1;
                        }
                        else if (term[j] == ')')
                        {
                            cnum += 1;
                            if (cnum > onum)
                            {
                                TempBracketHelper tempbr = new TempBracketHelper();
                                tempbr.Open = i;
                                tempbr.Closed = j;
                                br.Add(tempbr);
                                onum = 0;
                                cnum = 0;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var item in br)
            {
                item.Eq = (term.Substring(item.Open+1, (item.Closed-item.Open)));
            }

            return br;
        }

        public static double SolveFinal(string term)
        {
            Evaluation eval = new Evaluation();
            term = Regex.Replace(term, @"\s+", "");
            var sepBr = seperateBracketsWell(term);
            foreach (var item in sepBr)
            {
                eval.Parse(item.Eq);
                double result = eval.Solve();
                term.Remove(item.Open, item.Closed + 1);
                term.Insert(item.Open, result.ToString());
            }
            eval.Parse(term);
            double fresult = eval.Solve();
            return fresult;
        }
        
    }
}