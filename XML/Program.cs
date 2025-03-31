using System;
using System.Xml;

namespace FileHandlingProject
{
    internal class Program
    {
        static string filePath = @"C:\Users\mcs58\source\repos\XML\sample.xml";

        static void Main()
        {
            Console.WriteLine("Reading all XML nodes:");
            ReadAllNodes();

            Console.WriteLine("\nReading a single XML node (Id=2):");
            ReadSingleNode("2");

            Console.WriteLine("\nInserting a new XML node:");
            InsertNewNode("3", "Charlie", "21");

            Console.WriteLine("\nUpdating XML file with new node:");
            UpdateNode("3", "Charlie Brown", "23");

            Console.WriteLine("\nFinal XML content:");
            ReadAllNodes();
        }

        static void ReadAllNodes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList students = doc.SelectNodes("//Student");
            foreach (XmlNode student in students)
            {
                Console.WriteLine($"ID: {student["Id"].InnerText}, Name: {student["Name"].InnerText}, Age: {student["Age"].InnerText}");
            }
        }

        static void ReadSingleNode(string id)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode student = doc.SelectSingleNode($"//Student[Id='{id}']");
            if (student != null)
            {
                Console.WriteLine($"ID: {student["Id"].InnerText}, Name: {student["Name"].InnerText}, Age: {student["Age"].InnerText}");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void InsertNewNode(string id, string name, string age)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode root = doc.DocumentElement;

            XmlElement newStudent = doc.CreateElement("Student");

            XmlElement newId = doc.CreateElement("Id");
            newId.InnerText = id;
            newStudent.AppendChild(newId);

            XmlElement newName = doc.CreateElement("Name");
            newName.InnerText = name;
            newStudent.AppendChild(newName);

            XmlElement newAge = doc.CreateElement("Age");
            newAge.InnerText = age;
            newStudent.AppendChild(newAge);

            root.AppendChild(newStudent);
            doc.Save(filePath);

            Console.WriteLine("New node inserted successfully.");
        }

        static void UpdateNode(string id, string newName, string newAge)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode student = doc.SelectSingleNode($"//Student[Id='{id}']");
            if (student != null)
            {
                student["Name"].InnerText = newName;
                student["Age"].InnerText = newAge;
                doc.Save(filePath);

                Console.WriteLine("XML node updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}
