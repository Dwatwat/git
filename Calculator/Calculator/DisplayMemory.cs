using System;
using System.Collections.Generic;

namespace Calculator
{
    class DisplayMemory
    {
        private readonly List<string> _input = new List<string>();

        public void AddInput(string value)
        {
            _input.Add(value);
        }

        public void ClearInput()
        {
            _input.Clear();
        }

        public string GetInput()
        {
            return string.Join("", _input);
        }
    }
}
