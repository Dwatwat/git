using System.Globalization;

namespace Calculator
{
    class CalculatorMemory
    {
        private double _current;

        public void Plus(double value)
        {
            _current += value;
        }

        public void Minus(double value)
        {
            _current -= value;
        }

        public void Multiply(double value)
        {
            _current *= value;
        }

        public void Divide(double value)
        {
            _current /= value;
        }

        public void Run(Operations operation, double value2)
        {
            switch (operation)
            {
                case Operations.PLUS:
                {
                    Plus(value2);
                    break;
                }
                case Operations.MINUS:
                {
                    Minus(value2);
                    break;
                }
                case Operations.MULTIPLY:
                {
                    Multiply(value2);
                    break;
                }
                case Operations.DIVIDE:
                {
                    Divide(value2);
                    break;
                }

            }
        }

        public void Set(double value)
        {
            _current = value;
        }

        public void Clear()
        {
            _current = 0;
        }

        public double GetValue()
        {
            return _current;
        }
    }
}
