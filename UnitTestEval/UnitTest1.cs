using CalculationLib;
using Xunit;

namespace UnitTestEval;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string equation = "7*4-2";
        Calc calc = new Calc();
        double result = calc.Solve(equation); 
        Assert.Equal(26.0, result);
    }
}