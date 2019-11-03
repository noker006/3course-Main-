using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    sealed class SmallCargo:Cargo
    {
        private string DelicateStaff;
        public string PropDelicateStaff
        {
            set
            {
                DelicateStaff = value;
            }
            get
            {
                return DelicateStaff;
            }
        }

        private string TypeFixator;
        public string PropTypeFixator 
        {
            set
            {
                TypeFixator = value;
            }
            get
            {
                return TypeFixator;
            }
        }
        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($" SmallCargo {DelicateStaff} {TypeFixator}");
        }
    }
}
