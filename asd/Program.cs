
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using CalculationLib;

string eq = "(4*3) * (4+2) + (2+3)";
eq = Regex.Replace(eq, @"\s+", "");
var result = TranslateCalculation.SolveFinal(eq);
Console.WriteLine(result);
