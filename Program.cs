namespace MyProject;

class NormalCalculator {
    public int Sum(int a,int b,int c = 0)
    {
        return a + b + c;
    }
    public int Difference(int a, int b, int c = 0)
    {
        return a - b - c;
    }

}
class SpecialCalculator : NormalCalculator {

    public int SplSum(int a,int b,int c=0)
    {
        return a - b - c;
    }
    public int SplDifference(int a, int b, int c = 0)
    {
        return a + b + c;
    }

}

class Program
{
    static void Main(string[] args)
    {
       SpecialCalculator calculator = new SpecialCalculator();
       //int ans = calculator.SplSum(3, 2);
       //int ans = calculator.SplDifference(3, 2);
        int ans = calculator.Sum(3, 2,1);
       // int ans = calculator.Difference(3, 2);
       Console.WriteLine(ans);
    }
}