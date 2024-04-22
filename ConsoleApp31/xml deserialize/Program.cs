using System.Xml.Serialization;

namespace ConsoleApp31
{
    

class Program
       
        {
            static void Main(string[] args)
            {
                string xmlFilePath = "person.xml";
                string xmlContent = File.ReadAllText(xmlFilePath);
                Console.WriteLine("XML File Content:");
                Console.WriteLine(xmlContent);

                Person deserializedPerson;
                using (StringReader reader = new StringReader(xmlContent))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Person));
                    deserializedPerson = (Person)serializer.Deserialize(reader);
                }

                Console.WriteLine("\nDeserialized Person:");
                Console.WriteLine("Name: " + deserializedPerson.Name);
                Console.WriteLine("Age: " + deserializedPerson.Age);
            }
        }

    }



