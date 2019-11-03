using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    sealed class LiquidBigCargo:BigCargo
    {
        public string PropTypeCistern
        {
            set
            {
               TypeCistern = value;
            }
            get
            {
                return TypeCistern;
            }
        }
        private string TypeCistern;

        public string PropTypeBlower
        {
            set
            {
                TypeBlower = value;
            }
            get
            {
                return TypeBlower;
            }
        }
        private string TypeBlower;

        public double PropMaxPressure
        {
            set
            {
                MaxPressure = value;
            }
            get
            {
                return MaxPressure;
            }
        }
        private double MaxPressure;
        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($" LiquidBigCargo {TypeBlower} {MaxPressure}");
        }
    }
    
}
