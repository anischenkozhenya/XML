using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//Из файла TelephoneBook.xml(файл создан в процессе выполнения 
//task1 задания) выведите на экран только номера телефонов.

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "TelephoneBook.xml";
            string path = @"..\..\..\Task1\";
            Process.Start("explorer.exe", path);
            var reader = new XmlTextReader(path+fileName);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name.Equals("TelephoneNumber"))
                            {
                                Console.WriteLine("{0}", reader.Value);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
