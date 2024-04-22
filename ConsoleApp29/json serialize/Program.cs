using System.Text.Json;

namespace ConsoleApp29
{
    class Program
    {
        static void Main()
        {
            var person = new Person
            {
                Name = "Eliyeva Fidan",
                Age = 30,
                IsMarried = true
            };

            string jsonString = JsonSerializer.Serialize(person);

            Console.WriteLine(jsonString);
        }
    }
}

