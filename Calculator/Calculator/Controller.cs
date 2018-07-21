namespace Calculator
{
    enum Operations
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    class Controller
    {
        private Operations _currentOperation;
        private readonly CalculatorMemory _calculatorMemory = new CalculatorMemory();
        private readonly DisplayController _displayController;
        public readonly Resources Resources = new Resources();

        public Controller(FormCalculator form)
        {
            _displayController = new DisplayController(form, this);
        }

        public void UpdateOperation(Operations operation)
        {
            _currentOperation = operation;
            _calculatorMemory.Set(_displayController.GetInput());
            _displayController.UpdateOperatorImage(operation);
            _displayController.ClearInput();
        }

        public void UpdateInput(string value)
        {
            _displayController.UpdateInput(value);
        }

        public double GetMemoryValue()
        {
            return _calculatorMemory.GetValue();
        }

        public void Clear()
        {
            _calculatorMemory.Clear();
            _displayController.ClearInput();
        }

        public void Go()
        {
            _calculatorMemory.Run(_currentOperation, _displayController.GetInput());
            _displayController.SetInput(_calculatorMemory.GetValue());
            _displayController.RefreshDisplay();
        }
    }
}
