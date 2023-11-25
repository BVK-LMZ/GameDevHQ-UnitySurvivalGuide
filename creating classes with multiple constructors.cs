using System;

namespace Coding.Exercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;
        
        // Place for your constructors
             public Phone(string company, string model,string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }
               public Phone(string company, string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unknown";
        }
        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }
        
        
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }
        
    }
    
  
}
