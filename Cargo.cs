using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    abstract class Cargo:Car
    {       
        public double PropLoadCapacity{
            set
            {
                LoadCapacity =value;
            }
            get
            {
                return LoadCapacity;
            }
        }
        private double LoadCapacity;

        public int PropTotalVolum {
            set
            {
                TotalVolum = value;
            }
            get
            {
                return TotalVolum;
            }
        }
        private int TotalVolum;

        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($" Cargo {LoadCapacity} {TotalVolum}");
        }
    }
}
