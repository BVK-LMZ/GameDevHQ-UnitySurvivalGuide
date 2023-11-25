using System;

class Program
{
    static void Main()
    {
        car myCar = new car("Jeep", 0);
        myCar.drive();
    }



} 


--------------------------
using System;

class car
{
    public string _make { get; set; }
    public int _speed { get; set; }

    
    public car(string make, int speed)
    {
        _make = make;
        _speed = speed;
    }
    
    public void Accelerate(int amount)
    {
        _speed += amount;
    }

    public void Brake(int amount)
    {
        _speed -= amount;
        if (_speed < 0) _speed = 0;
    }


    public void  drive()
    {
        Console.WriteLine("The car is a " + _make + " and is going " + _speed + " mph.");
    }
} 
