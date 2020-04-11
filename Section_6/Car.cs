using System;
namespace Section_6
{
    public class Car
    {
        private string _color;
        private int _numberOfDoors;
        private bool _isConvertable;


        public Car(string carColor,int doors,bool convertable)
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public bool IsConvertable { get; set; }

        public int NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }
            set
            {
                if(value <= 4)
                {
                    _numberOfDoors = value; 
                }
            }
        }

        public void Accelerate()
        {
            Console.WriteLine("I am accelerating");
        }

        public bool FamilyCar()
        {
            if(NumberOfDoors >= 4)
            {
                return true;
            }
            return false;
        }
    }
}
