using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    internal interface ICalculator
    {
        event EventHandler<EventArgs> GotResult;
        void Add(int i);
        void Sub(int i);
        void Div(int i);
        void Mul(int i);
        void CancelLast();
    }
}
