using System;
using System.Collections.Generic;
using System.Text;

namespace Taxopark
{
    abstract class Car
    {
        //private int TimeRecharging;
        //private int CapacityBattery;
        //private string TypeBattery;
        //public int PropTimeRecharging
        //{
        //    set
        //    {
        //        TimeRecharging = value;
        //    }
        //    get
        //    {
        //        return TimeRecharging;
        //    }
        //}
        //public int PropСapacityBattery
        //{
        //    set
        //    {
        //        CapacityBattery = value;
        //    }
        //    get
        //    {
        //        return CapacityBattery;
        //    }
        //}
        //public string PropTypeBattery
        //{
        //    set
        //    {
        //        TypeBattery = value;
        //    }
        //    get
        //    {
        //        return TypeBattery;
        //    }
        //}


        //private int AmountFuelTank;
        //private string TypeFuel;
        //private double ConsumptionFuel;
        //public int PropAmountFuelTank
        //{
        //    set
        //    {
        //        AmountFuelTank = value;
        //    }
        //    get
        //    {
        //        return AmountFuelTank;
        //    }
        //}
        //public string PropTypeFuel
        //{
        //    set
        //    {
        //        TypeFuel = value;
        //    }
        //    get
        //    {
        //        return TypeFuel;
        //    }
        //}
        //public double PropConsumptionFuel
        //{
        //    set
        //    {
        //        ConsumptionFuel = value;
        //    }
        //    get
        //    {
        //        return ConsumptionFuel;
        //    }
        //}

        public string PropProducer { set { Producer = value; } get { return Producer; } }
        private string Producer;

        public string Property { get; set; }  

        public string PropNameModel { set { NameModel = value; } get { return NameModel; } }
        private string NameModel;

        public string PropNameBody { set { NameBody = value; } get { return NameBody; } }
        private string NameBody;

        public int PropYear { set { Year = value; } get { return Year; } }
        private int Year;

        public double PropPrice { set { Price = value; } get { return Price; } }
        private double Price;

        public double PropMaxSpeed { set { MaxSpeed = value; } get { return MaxSpeed; } }
        private double MaxSpeed;

        private double Consumption;
        public double PropConsumption
        {
            set
            {
                Consumption = value;
            }
            get
            {
                return Consumption;
            }

        }
        public virtual void OutputInfo()
        {
            Console.Write($"\n{Producer} {NameModel} {NameBody} {Year} {Price} | Speed: {MaxSpeed} | Consumption:{Consumption}");
        } 

    }
}
