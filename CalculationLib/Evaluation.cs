using System;
using System.Text.RegularExpressions;

namespace CalculationLib;

public class Evaluation
{
    public Evaluation LHSToken { get; set; }
    public string Operator { get; set; }
    public Evaluation RHSToken { get; set; }

    private Regex additionSubtraction = new Regex("[+-]", RegexOptions.RightToLeft);
    private Regex multiplicationDivision = new Regex("[*/]", RegexOptions.RightToLeft);

    public void Parse(string equation)
    {
        if (equation.Contains("("))
        {
            
        }
        var operatorLocation = additionSubtraction.Match(equation);
        if (!operatorLocation.Success)
        {
            operatorLocation = multiplicationDivision.Match(equation);
        }

        if (operatorLocation.Success)
        {
            Operator = operatorLocation.Value;

            LHSToken = new Evaluation();
            LHSToken.Parse(equation.Substring(0, operatorLocation.Index));
                
            RHSToken = new Evaluation();
            RHSToken.Parse(equation.Substring(operatorLocation.Index + 1));
        }
        else
        {
            Operator = "v";
            result = double.Parse(equation);
        }
    }
    

    private double result;

    public double Solve()
    {
        switch (Operator)
        {
            case "v":
                break;
            case "+":
                result = LHSToken.Solve() + RHSToken.Solve();
                break;
            case "-":
                result = LHSToken.Solve() - RHSToken.Solve();
                break;
            case "*":
                result = LHSToken.Solve() * RHSToken.Solve();
                break;
            case "/":
                result = LHSToken.Solve() / RHSToken.Solve();
                break;
            default:
                throw new Exception("not parsed");
        }

        return result;
    }
}
