using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    class Passenger:Car
    {
        public int PropSeatsNumber { set { SeatsNumber = value; } get { return SeatsNumber; } }
        private int SeatsNumber;

        public string PropConditioner { set { Conditioner = value; } get { return Conditioner; } }
        private string Conditioner;

        public string PropHeatedSeat { set { HeatedSeat = value; } get { return HeatedSeat; } }
        private string HeatedSeat;

        private string Wifi;
        public string PropWifi
        {
            set
            {
                Wifi = value;
            }
            get
            {
                return Wifi;
            }
        }
        public override void OutputInfo()
        {
            base.OutputInfo();
            Console.Write($" Passenger {SeatsNumber} {Conditioner} {HeatedSeat} {Wifi}");
        }
    }
}
