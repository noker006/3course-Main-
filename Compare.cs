using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    class CompareCar: IComparer<Car>
    {
         public int Compare(Car i, Car j)
         {
            return i.PropConsumption.CompareTo(j.PropConsumption);
         }
    }
}
