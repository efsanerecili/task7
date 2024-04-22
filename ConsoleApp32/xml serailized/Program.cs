using System.Xml.Serialization;

namespace ConsoleApp32
{
     class Program
    {
        
            static void Main(string[] args)
            {
                Person person = new Person { Name = "Fidan", Age = 30 };

                string xmlContent;
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (StringWriter writer = new StringWriter())
                {
                    serializer.Serialize(writer, person);
                    xmlContent = writer.ToString();
                }

                Console.WriteLine("Serialized XML:");
                Console.WriteLine(xmlContent);

                string xmlFilePath = "person.xml";
                File.WriteAllText(xmlFilePath, xmlContent);
                Console.WriteLine($"\nSerialized XML saved to file: {xmlFilePath}");
            }
        }

    }

