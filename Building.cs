using System;

namespace planner
{
    public class Building
    {
        //Private Field
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //Constructor-special method in a class that is called when a new instance of the class is created. The role of a constructor is to make sure the new object is setup and ready for use immediately after it is created.

        public Building(string address)
        {
            _address = address;
        }

        //Public accessibility 
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public string Volume
        {
            get
            {
                return $"{Width * Depth* (3 * Stories)}";
            }
        }

        // Methods

        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }

        public void Purchase(string name)
        {
            _owner = name;
        }

    }
}