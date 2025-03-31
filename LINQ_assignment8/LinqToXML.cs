using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqDemo
{
    public class LinqToXml
    {
        public static void Run()
        {
            string xmlData = @"<Students>
                                    <Student>
                                        <Name>Alice</Name>
                                        <Age>20</Age>
                                    </Student>
                                    <Student>
                                        <Name>Bob</Name>
                                        <Age>22</Age>
                                    </Student>
                               </Students>";

            XDocument doc = XDocument.Parse(xmlData);

            var studentNames = from student in doc.Descendants("Student")
                               select student.Element("Name").Value;

            Console.WriteLine("Student Names from XML:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
