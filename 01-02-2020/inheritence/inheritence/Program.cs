using System;

namespace inheritence
{
    class vehicle
    {
        public string brand = "Ford";
        public void hunk()
        {
            Console.WriteLine("Tutt, tutt");
        }
    }
    class car : vehicle
    {
        public string modelname = "Mustang";
    }
    class program
    {
        static void Main(String [] args)
        {
            car mycar = new car();
            mycar.hunk();
            Console.WriteLine(mycar.brand + " " + mycar.modelname);
        }
    }
}
