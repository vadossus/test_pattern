using System;

namespace PrototypePattern
{

    public interface IPrototype<T>
    {
        T Clone();
    }

    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
        public Person Clone()
        {
            return new Person(Name, Age);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Оригинальный объект
            Person original = new Person("Alice", 30);
            Console.WriteLine("Original: " + original);

            // Клон
            Person clone = original.Clone();
            Console.WriteLine("Clone: " + clone);

            // Изменение клона
            clone.Name = "Bob";
            clone.Age = 25;

            Console.WriteLine("\nAfter modifying the clone:");
            Console.WriteLine("Original: " + original);
            Console.WriteLine("Clone: " + clone);
        }
    }
}
