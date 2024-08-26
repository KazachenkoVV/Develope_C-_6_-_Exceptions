using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<EventArgs>? GotResult;
        public double result = 0;
        Stack<double> history = new Stack<double>();
        /// <summary>
        /// Прибавляет аргумент к результату последней операции.
        /// </summary>
        /// <param name="arg">Аргумент прибавляемый к рузультату последенй операции.</param>
        /// <returns>Сумму.</returns>
        public void Add(int arg)
        {
            //Console.WriteLine("int");
            history.Push(result);
            result += arg;
            RaiseEvent();
        }

        public void Add(double arg)
        {
            //Console.WriteLine("double");
            history.Push(result);
            result += arg;
            RaiseEvent();
        }
        public void Div(int arg)
        {
            //Console.WriteLine("int");
            if (arg == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо!");
            else
            {
                history.Push(result);
                result /= arg;
                RaiseEvent();
            }
        }

        public void Div(double arg)
        {
            //Console.WriteLine("double");
            if (arg == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо!");
            else
            {
                history.Push(result);
                result /= arg;
                RaiseEvent();
            }
        }

        public void Mul(int arg)
        {
            //Console.WriteLine("int");
            history.Push(result);
            result *= arg;
            RaiseEvent();
        }

        public void Mul(double arg)
        {
            //Console.WriteLine("double");
            history.Push(result);
            result *= arg;
            RaiseEvent();
        }

        public void Sub(int arg)
        {
            //Console.WriteLine("int");
            history.Push(result);
            result -= arg;
            RaiseEvent();
        }

        public void Sub(double arg)
        {
            //Console.WriteLine("double");
            history.Push(result);
            result -= arg;
            RaiseEvent();
        }
        /// <summary>
        /// Отменяет последнюю операцию.
        /// </summary>
        public void CancelLast()
        {
            if (history.Count > 0)
                result = history.Pop();
            RaiseEvent();
        }
        private void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }
    }
}
