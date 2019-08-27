using System.Diagnostics;
using System.Text;
using System.Xml;
//Создайте.xml файл, который соответствовал бы следующим требованиям: 
//· имя файла: TelephoneBook.xml 
//· корневой элемент: “MyContacts” 
//· тег “Contact”, и в нем должно быть записано имя контакта и атрибут 
//“TelephoneNumber” со значением номера телефона.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Относительный путь для файла
            string path = @"..\..\";
            string fileName = @"TelephoneBook.xml";
            //Открытие папки для наглядности
            Process.Start("explorer.exe",path);
            //Создание XML-файла с именем
            var xmlnewfile = new XmlTextWriter(path+fileName, Encoding.UTF8);
            xmlnewfile.WriteStartDocument();
            //Создание корневого тега(только один)
            xmlnewfile.WriteStartElement("MyContacts");
            //Добавление контактов
            xmlnewfile.AddContact("Eugene","+375445468555");
            xmlnewfile.AddContact("Dima", "+375441234567");

            xmlnewfile.WriteEndElement();
            //Закрытие файла
            xmlnewfile.Close();
        }
    }
}
