using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace _11.ChapterEleven
{
    [Serializable]
    public class Customer
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Address { get; set; }
        [XmlAttribute]
        public string City { get; set; }
        [XmlAttribute]
        public string Country { get; set; }
        [XmlAttribute]
        public string DocumentNumber { get; set; }
        [XmlAttribute]
        public DateTime BirthDay { get; set; }
    }
}
