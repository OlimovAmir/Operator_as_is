using Operator_as_is;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point();

        point.Print(25, 23);

        object obj = new Point { X = 11, Y = 22 };
        Foo(obj);
        Bar(obj);

    }

    static void Foo(object obj)
    {
        Point point = obj as Point;

        if (point != null)
        {
            point.Print(12, 36);
        }
    }

    static void Bar(object obj)
    {
        if (obj is Point point)
        {
            //Point point = (Point)obj;

            point.Print(point.X = 2, point.Y = 3);
        }
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