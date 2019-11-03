using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    class BigCargo : Cargo
    {
        private int AmountTrailer;
        public int PropAmountTrailer {
            set
            {
                AmountTrailer = value;
            }
            get
            {
                return AmountTrailer;
            }
        }

        private int AmountEuroPalet;
        public int PropAmountEuroPalet
        {
            set
            {
                AmountEuroPalet = value;
            }
            get
            {
                return AmountEuroPalet;
            }
        }

        string TypeTrailer;
        public string PropTypeTrailer
        {
            set
            {
                TypeTrailer = value;
            }
            get
            {
                return TypeTrailer;
            }
        }
        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($"BigCargo {AmountTrailer} {AmountEuroPalet} {TypeTrailer}");
        }
    }
}
