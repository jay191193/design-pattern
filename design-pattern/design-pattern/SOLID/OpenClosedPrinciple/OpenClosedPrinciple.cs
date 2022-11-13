using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification
/// </summary>
namespace design_pattern.OpenClosedPrinciple
{
    public interface ICalculate
    {
        void Calculate();
    }

    public class Summation : ICalculate
    {
        private int _firstNum;
        private int _secondNum;
        public Summation(int firstNum, int secondNum)
        {
            this._firstNum = firstNum;
            this._secondNum = secondNum;
        }
        public void Calculate()
        {
            Console.WriteLine(_firstNum + _secondNum);
        }
    }

    public class Subtraction : ICalculate
    {
        private int _firstNum;
        private int _secondNum;
        public Subtraction(int firstNum, int secondNum)
        {
            this._firstNum = firstNum;
            this._secondNum = secondNum;
        }
        public void Calculate()
        {
            Console.WriteLine(_firstNum - _secondNum);
        }
    }

    public class Multiplication : ICalculate
    {
        private int _firstNum;
        private int _secondNum;
        public Multiplication(int firstNum, int secondNum)
        {
            this._firstNum = firstNum;
            this._secondNum = secondNum;
        }
        public void Calculate()
        {
            Console.WriteLine(_firstNum * _secondNum);
        }
    }

    public class Division : ICalculate
    {
        private int _firstNum;
        private int _secondNum;
        public Division(int firstNum, int secondNum)
        {
            this._firstNum = firstNum;
            this._secondNum = secondNum;
        }
        public void Calculate()
        {
            Console.WriteLine(_firstNum / _secondNum);
        }
    }
    public class Calculator
    {
        private ICalculate _calculate;

        public Calculator(ICalculate calculate)
        {
            this._calculate = calculate;
        }

        public void Calculate()
        {
            this._calculate.Calculate();
        }
    }
}
