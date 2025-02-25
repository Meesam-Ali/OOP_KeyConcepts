namespace OOP_KeyConcepts
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
       //Encapsulation (Hiding data using private fields & exposing methods)
   public class BankAccount
   {
       private decimal balance;  // Private field  

       public decimal GetBalance() => balance;  // Public method to access private data  

       public void Deposit(decimal amount)
       {
           if (amount > 0) balance += amount;
       }
   }

   // Inheritance (Reusing functionality from a base class)
   public class Animal
   {
       public string Name { get; set; }
       public virtual void Speak() => Console.WriteLine("Some sound");
   }

   public class Dog : Animal
   {
       public override void Speak() => Console.WriteLine("Bark");
   }
   public interface IShape
   {
       double GetArea();
   }


   // Polymorphism (Method overriding & interface implementation)
   public class Circle : IShape
   {
       public double Radius { get; set; }
       public double GetArea() => Math.PI * Radius * Radius;
   }

   // Abstraction (Hiding implementation details & showing only the necessary behavior)
   public abstract class Vehicle
   {
       public abstract void Drive();
   }

   public class Car : Vehicle
   {
       public override void Drive() => Console.WriteLine("Driving a car");
   }
}
// comment 