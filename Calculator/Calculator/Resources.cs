using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Resources
    {
        private readonly Image _operatorPlus;
        private readonly Image _operatorMinus;
        private readonly Image _operatorMultiply;
        private readonly Image _operatorDivide;

        public Resources()
        {
            _operatorPlus = Image.FromFile("C:\\Users\\dexte\\source\\repos\\Calculator\\Calculator\\Resources\\OperatorImages\\OperatorPlus.png");
            _operatorMinus = Image.FromFile("C:\\Users\\dexte\\source\\repos\\Calculator\\Calculator\\Resources\\OperatorImages\\OperatorMinus.png");
            _operatorMultiply = Image.FromFile("C:\\Users\\dexte\\source\\repos\\Calculator\\Calculator\\Resources\\OperatorImages\\OperatorMultiply.png");
            _operatorDivide = Image.FromFile("C:\\Users\\dexte\\source\\repos\\Calculator\\Calculator\\Resources\\OperatorImages\\OperatorDivide.png");
        }

        public Image GetImagePlus()
        {
            return _operatorPlus;
        }

        public Image GetImageMinus()
        {
            return _operatorMinus;
        }

        public Image GetImageMultiply()
        {
            return _operatorMultiply;
        }

        public Image GetImageDivide()
        {
            return _operatorDivide;
        }
    }
}
