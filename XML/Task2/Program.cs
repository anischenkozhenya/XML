using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
//Создайте приложение,которое выводит 
//на экран всю информацию об указанном.xml файле.
//(файл создан в процессе выполнения
//task1 задания)

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "TelephoneBook.xml";
            string path = @"..\..\..\Task1\";
            Process.Start("explorer.exe", path);
            var file = new XmlDocument();
            file.Load(path+fileName);
            Console.WriteLine(file.InnerText);
            Console.WriteLine(file.InnerXml);
            FileStream stream = new FileStream(path+fileName, FileMode.Open);
            XmlTextReader xmlTextReader = new XmlTextReader(stream);
            while (xmlTextReader.Read())
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-10}", xmlTextReader.NodeType, xmlTextReader.Name, xmlTextReader.Value);
            }
            xmlTextReader.Close();
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
