using System;
using System.Globalization;

namespace Calculator
{
    class DisplayController
    {
        private readonly DisplayMemory _displayMemory = new DisplayMemory();
        private readonly Controller _controller;
        private readonly FormCalculator _form;

        public DisplayController(FormCalculator form, Controller controller)
        {
            _form = form;
            _controller = controller;
        }

        public void UpdateInput(string value)
        {
            _displayMemory.AddInput(value);
            RefreshDisplay();
        }

        public void UpdateOperatorImage(Operations operation)
        {
            switch (operation)
            {
                case Operations.PLUS: _form.UpdateOperatorImage(_controller.Resources.GetImagePlus()); break;
                case Operations.MINUS: _form.UpdateOperatorImage(_controller.Resources.GetImageMinus()); break;
                case Operations.MULTIPLY: _form.UpdateOperatorImage(_controller.Resources.GetImageMultiply()); break;
                case Operations.DIVIDE: _form.UpdateOperatorImage(_controller.Resources.GetImageDivide()); break;
            }
        }

        public void ClearInput()
        {
            _displayMemory.ClearInput();
            RefreshDisplay();
        }

        public void SetInput(double value)
        {
            _displayMemory.ClearInput();
            _displayMemory.AddInput(value.ToString(CultureInfo.InvariantCulture));
        }

        public double GetInput()
        {
            string inputString = _displayMemory.GetInput();
            return Convert.ToDouble(inputString == "" ? "0" : inputString);
        }

        public void Display(double displayValue)
        {
            _form.UpdateTextBox(displayValue);
        }

        public void Display(double displayValue, double memoryValue)
        {
            _form.UpdateTextBox(displayValue);
            _form.UpdateTextBoxMemory(memoryValue);
        }

        public void RefreshDisplay()
        {
            Display(GetInput(), _controller.GetMemoryValue());
        }
    }
}
