using System;

namespace Section_6
{
    public class Trip
    {
        private string _destination;
        private double _distance;
        private double _totalCostOfGasoline;
        private double _numberOfLittersConsumed;


        public double Distance
        {
            get => _distance;
            set
            {
                if (value > 0)
                {
                    _distance = value;
                }
                else
                {
                    throw new ArgumentException("Argument can't be less than '0' ");
                }
            }
        }

        public double TotalCostOfGasoline
        {
            get => _totalCostOfGasoline;
            set
            {
                if (value > 0)
                {
                    _totalCostOfGasoline = value;
                }
                else
                {
                    throw new ArgumentException("Argument can't be less than '0' ");
                }
            }
        }

        public double NumberOfLittersConsumed
        {
            get => _numberOfLittersConsumed;
            set
            {
                if (value > 0)
                {
                    _numberOfLittersConsumed = value;
                }
                else
                {
                    throw new ArgumentException("Argument can't be less than '0' ");
                }
            }
        }

        public string Destination
        {
            get => _destination;
            set => _destination = value;
        }

        public Trip()
        {
        }

        public Trip(string destination, double distance, double totalCostOfGasoline, double numberOfLittersConsumed)
        {
            Destination = destination;
            Distance = distance;
            TotalCostOfGasoline = totalCostOfGasoline;
            NumberOfLittersConsumed = numberOfLittersConsumed;
        }

        public double KilometersPerLiter()
        {
            return Distance / NumberOfLittersConsumed;
        }

        public double CostPerKilometer()
        {
            return TotalCostOfGasoline / Distance;
        }

        public override string ToString()
        {
            return $"Trip destination: '{Destination}'\n" +
                   $"Trip distance: '{Distance}'\n" +
                   $"Total cost of gasoline: '{TotalCostOfGasoline}'\n" +
                   $"Number of litters consumed: '{NumberOfLittersConsumed}'\n" +
                   $"Kilometers per liter: '{KilometersPerLiter()}'\n" +
                   $"Cost per kilometer: '{CostPerKilometer():F}'";
        }
    }
}