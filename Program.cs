using Operator_as_is;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point();

        point.Print();
    }



    public void WriteToFile(List<Person> people, string filePath)
    {
        try
        {
            using(StreamWriter writer = new StreamWriter(filePath))
            {
                foreach(Person person in people)
                {
                    writer.WriteLine($"{person.Id} {person.Name} {person.LastName} {person.Birthday.ToShortDateString()}");
                }
                Console.WriteLine($"The data is written to a file {filePath}");
            }
        }catch (Exception ex)
        {
            Console.WriteLine($"error writing data {ex.Message}");
        }
    }
}