using System;

namespace Heritaaage
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person("Leopold", 6);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            Person person2 = new Person("Molly", 16);
            Console.WriteLine("person Name = {0} Age = {1}", person2.Name, person2.Age);
            
            person2.Name = "Jeremi";
            person2.Age = 20;

            Console.WriteLine("person Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);
            Console.ReadKey();
        }
    }
}
