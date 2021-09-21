using System;

class Program {
  public static void Main (string[] args) {
    double total = 0;
    int car = 1;
    Console.WriteLine("Please provide number of cars");
    int numcar = Convert.ToInt32(Console.ReadLine());
    while (car <= numcar)
    {
    Console.WriteLine("Enter distance covered by car #"+ car);
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter time taken by car #" + car);
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = (distance / time);
    Console.WriteLine("The speed of this car is " + speed + " miles per hour");
    total = total + speed;
    if (car == numcar)
      {
        break;
      }
    car++;
    }
    double average = (total/car);
    Console.WriteLine("The average speed of the cars is " + average + " miles per hour");
  }
}