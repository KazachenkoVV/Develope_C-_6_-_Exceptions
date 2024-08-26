// Доработайте класс  калькулятора способным работать как с целочисленными так и с дробными 
// числами. (возможно стоит задействовать перегрузку операций)


using System.Text;

namespace CalculatorInterface
{
    internal class Program
    {
        static void Calculator_GotResult(object sender, EventArgs e)
        {
            Console.WriteLine(((Calculator)sender).result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ПРОГРАММА - КАЛЬКУЛЯТОР");

            Calculator calc = new Calculator();
            calc.GotResult += Calculator_GotResult;
            int arg = 0;
            Console.WriteLine("\n" + arg);
            calc.Add(10);
            calc.Mul(2);
            calc.Sub(7.4);
            calc.Div(3);
            calc.Mul(2);
            calc.CancelLast();
            calc.Mul(2.3);
            calc.Add(2);
        }
    }
}