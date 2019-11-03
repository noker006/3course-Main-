using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
   sealed class FrozenBigCargo:BigCargo
    {
        private string TypeFridge;
        public string PropTypeFridge
        {
            set
            {
               TypeFridge = value;
            }
            get
            {
                return TypeFridge;
            }
        }

        private double MinTemperature;
        public double PropMinTemperature
        {
            set
            {
                MinTemperature = value;
            }
            get
            {
                return MinTemperature;
            }
        }

        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($" FrozenBigCargo {TypeFridge} {MinTemperature}");
        }
    }
}
