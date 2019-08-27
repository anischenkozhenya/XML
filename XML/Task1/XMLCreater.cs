using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1
{
    public static class XMLCreater
    {
        /// <summary>
        /// Добавление нового контакта(Метод расширения)
        /// </summary>
        /// <param name="xmlfile">объект XmlTextWriter</param>
        /// <param name="name">Имя</param>
        /// <param name="phoneNumber">Номер телефона</param>
        public static void AddContact(this XmlTextWriter xmlfile, string name,string phoneNumber)
        {            
            xmlfile.WriteStartElement("Contact");
            xmlfile.WriteStartAttribute("TelephoneNumber");
            xmlfile.WriteString(phoneNumber);
            xmlfile.WriteEndAttribute();
            xmlfile.WriteString(name);
            xmlfile.WriteEndElement();            
        }
    }
}
