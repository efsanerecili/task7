using System.Text.Json;

namespace ConsoleApp30
{
    
class Program
        {
            static void Main()
            {
                string jsonString = "{\"Name\":\"Fidan Eliyeva\",\"Age\":30,\"IsMarried\":true}";

                Person person = JsonSerializer.Deserialize<Person>(jsonString);

                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Is Married: {person.IsMarried}");
            }
        }

    
    
}
