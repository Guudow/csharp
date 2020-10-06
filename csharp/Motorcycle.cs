using System;

namespace csharp
{
    public class Motorcycle
    {
        public int driverIntensity;
        // new members to represent the name of the driver. 
        public string drivename;

        public void SetDriverName(string name)
        {
            
            drivename = name; 
        }

        public void PopAwheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("yeeeea Haaaeew!");
            }
        }
        // put back the default constructor, which will 
        // set all data members to default values 
        public Motorcycle() {}
        
        // Our custom constructor
        public Motorcycle(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10; 
            }

            driverIntensity = intensity;
            drivename = name;
            {
                
            }
        }
    }
}