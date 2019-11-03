using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Taxopark
{
    class Taxopark
    {
        private List<Car> Cars = new List<Car>();
        private List<FrozenBigCargo> FrozenBigCargoCars = new List<FrozenBigCargo>();
        private List<LiquidBigCargo> LiquidBigCargoCars = new List<LiquidBigCargo>();
        private List<BigCargo> BigCargoCars = new List<BigCargo>();
        private List<SmallCargo> SmallCargoCars = new List<SmallCargo>();
        private List<Passenger> PassengerCars = new List<Passenger>();

        public Taxopark()
        {

            string[] Path = new string[]
            {
               @"C:\!C#\Taxopark\Passenger.txt",@"C:\!C#\Taxopark\SmallCargo.txt",@"C:\!C#\Taxopark\LiquidBigCargo.txt",@"C:\!C#\Taxopark\FrozenBigCargo.txt",@"C:\!C#\Taxopark\BigCargo.txt"
            };
            InitializationTaxopark(Path);
        }

        private void InitializationTaxopark(string[] Path)
        {

            Passenger passenger = new Passenger();
            SmallCargo smallCargo = new SmallCargo();
            BigCargo bigCargo = new BigCargo();
            FrozenBigCargo frozenBigCargo = new FrozenBigCargo();
            LiquidBigCargo liquidBigCargo = new LiquidBigCargo();
            InitializationPassenger(passenger, Path[0]);
            InitializationSmallCargo(smallCargo, Path[1]);
            InitializationBigCargo(bigCargo, Path[4]);
            InitializationLiquidBigCargo(liquidBigCargo, Path[2]);
            InitializationFrozenBigCargo(frozenBigCargo, Path[3]);
            //using (StreamReader stream = new StreamReader(Path[i], System.Text.Encoding.Default))
            //{
            //    while (!stream.EndOfStream)
            //    {
            //        string Buffer = stream.ReadLine();
            //        string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //        InitializationAbstractCarsInformation(passenger, CarInformation);
            //        InitializationPassenger(passenger, CarInformation);
            //        PassengerCars.Add(passenger);
            //        passenger = new Passenger();
            //    }
            //}








        }
        private void InitializationAbstractCarsInformation(Car HeirCar, string[] AbstactCarInformation)
        {

            HeirCar.PropProducer = AbstactCarInformation[0];
            HeirCar.PropNameModel = AbstactCarInformation[1];
            HeirCar.PropNameBody = AbstactCarInformation[2];
            HeirCar.PropYear = Convert.ToInt32(AbstactCarInformation[3]);
            HeirCar.PropPrice = Convert.ToDouble(AbstactCarInformation[4]);
            HeirCar.PropMaxSpeed = Convert.ToInt32(AbstactCarInformation[5]);
            HeirCar.PropConsumption = Convert.ToDouble(AbstactCarInformation[6]);
           
        }
        private void InitializationPassenger(Passenger passenger, string Path)
        {
            using (StreamReader stream = new StreamReader(Path, System.Text.Encoding.Default))
            {
                while (!stream.EndOfStream)
                {
                    string Buffer = stream.ReadLine();
                    string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    InitializationAbstractCarsInformation(passenger, CarInformation);
                    passenger.PropSeatsNumber = Convert.ToInt32(CarInformation[7]);
                    passenger.PropConditioner = CarInformation[8];
                    passenger.PropHeatedSeat = CarInformation[9];
                    passenger.PropWifi = CarInformation[10];
                    PassengerCars.Add(passenger);
                    Cars.Add(passenger);
                    passenger = new Passenger();
                }
            }
        }
        private void InitializationBigCargo(BigCargo bigCargo, string Path)
        {
            using (StreamReader stream = new StreamReader(Path, System.Text.Encoding.Default))
            {
                while (!stream.EndOfStream)
                {
                    string Buffer = stream.ReadLine();
                    string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    InitializationAbstractCarsInformation(bigCargo, CarInformation);
                    bigCargo.PropLoadCapacity = Convert.ToDouble(CarInformation[7]);
                    bigCargo.PropTotalVolum = Convert.ToInt32(CarInformation[8]);
                    bigCargo.PropAmountTrailer = Convert.ToInt32(CarInformation[9]);
                    bigCargo.PropAmountEuroPalet = Convert.ToInt32(CarInformation[10]);
                    bigCargo.PropTypeTrailer = CarInformation[11];
                    BigCargoCars.Add(bigCargo);
                    Cars.Add(bigCargo);
                    bigCargo = new BigCargo();
                }
            }
        }
        private void InitializationLiquidBigCargo(LiquidBigCargo liquidBigCargo, string Path)
        {
            using (StreamReader stream = new StreamReader(Path, System.Text.Encoding.Default))
            {
                while (!stream.EndOfStream)
                {
                    string Buffer = stream.ReadLine();
                    string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    InitializationAbstractCarsInformation(liquidBigCargo, CarInformation);
                    liquidBigCargo.PropLoadCapacity = Convert.ToDouble(CarInformation[7]);
                    liquidBigCargo.PropTotalVolum = Convert.ToInt32(CarInformation[8]);
                    liquidBigCargo.PropAmountTrailer = Convert.ToInt32(CarInformation[9]);
                    liquidBigCargo.PropAmountEuroPalet = Convert.ToInt32(CarInformation[10]);
                    liquidBigCargo.PropTypeTrailer = CarInformation[11];
                    liquidBigCargo.PropTypeCistern = CarInformation[12];
                    liquidBigCargo.PropTypeBlower = CarInformation[13];
                    liquidBigCargo.PropMaxPressure = Convert.ToDouble(CarInformation[14]);
                    LiquidBigCargoCars.Add(liquidBigCargo);
                    Cars.Add(liquidBigCargo);
                    liquidBigCargo = new LiquidBigCargo();
                }
            }
        }
        private void InitializationFrozenBigCargo(FrozenBigCargo frozenBigCargo, string Path)
        {
            using (StreamReader stream = new StreamReader(Path, System.Text.Encoding.Default))
            {
                while (!stream.EndOfStream)
                {
                    string Buffer = stream.ReadLine();
                    string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    InitializationAbstractCarsInformation(frozenBigCargo, CarInformation);
                    frozenBigCargo.PropLoadCapacity = Convert.ToDouble(CarInformation[7]);
                    frozenBigCargo.PropTotalVolum = Convert.ToInt32(CarInformation[8]);
                    frozenBigCargo.PropAmountTrailer = Convert.ToInt32(CarInformation[9]);
                    frozenBigCargo.PropAmountEuroPalet = Convert.ToInt32(CarInformation[10]);
                    frozenBigCargo.PropTypeTrailer = CarInformation[11];
                    frozenBigCargo.PropTypeFridge = CarInformation[12];
                    frozenBigCargo.PropMinTemperature = Convert.ToDouble(CarInformation[13]);
                    FrozenBigCargoCars.Add(frozenBigCargo);
                    Cars.Add(frozenBigCargo);
                    frozenBigCargo = new FrozenBigCargo();
                }
            }
        }

        private void InitializationSmallCargo(SmallCargo smallCargo, string Path)
        {
            using (StreamReader stream = new StreamReader(Path, System.Text.Encoding.Default))
            {
                while (!stream.EndOfStream)
                {
                    string Buffer = stream.ReadLine();
                    string[] CarInformation = Buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    InitializationAbstractCarsInformation(smallCargo, CarInformation);
                    smallCargo.PropLoadCapacity = Convert.ToDouble(CarInformation[7]);
                    smallCargo.PropTotalVolum = Convert.ToInt32(CarInformation[8]);
                    smallCargo.PropDelicateStaff = CarInformation[9];
                    smallCargo.PropTypeFixator = CarInformation[10];
                    SmallCargoCars.Add(smallCargo);
                    Cars.Add(smallCargo);
                    smallCargo = new SmallCargo();
                }
            }
        }


        public double CostTaxopark()
        {
            double CountCost = 0;
            for (int i = 0; i < Cars.Count; i++)
            {
                CountCost += Cars[i].PropPrice;
            }
            return CountCost;
        }

        public void SortTaxopark()
        {
            //object CarTemp;
            //for (int i = 0; i < Cars.Count - 1; i++)
            //{
            //    bool f = false;
            //    for (int j = 0; j < Cars.Count - i - 1; j++)
            //    {
            //        if (Cars[j + 1].PropConsumption > Cars[j].PropConsumption)
            //        {
            //            CarTemp = Cars[j + 1].PropConsumption;
            //            Cars[j + 1].PropConsumption = Cars[j].PropConsumption;
            //            Cars[j].PropConsumption =Convert.ToDouble(CarTemp);
            //        }
            //    }
            //}
            CompareCar compare = new CompareCar();
            Cars.Sort(compare);
            for (int j = 0; j < Cars.Count; j++)
            {
                Cars[j].OutputInfo();
            }
        }
        public void OutputNeedSpeed(int MinNecessarySpeed ,int MaxNecessarySpeed)
        {
            bool NoEntry=false;
            for (int i = 0; i < Cars.Count; i++)
            {
                if(MinNecessarySpeed<Cars[i].PropMaxSpeed&&MaxNecessarySpeed> Cars[i].PropMaxSpeed)
                {
                    Cars[i].OutputInfo();
                    NoEntry = true;
                }
            }
            if (NoEntry == false) Console.WriteLine("No cars with needed speed!");
        }
    }
}
