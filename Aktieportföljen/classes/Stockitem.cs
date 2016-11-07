using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Aktieportföljen.classes
{
    [Serializable, XmlRoot("aktier")]
    public class Stockitem
    {
        [XmlIgnore]
        public string id { get; set; }
        [XmlAttribute("stocklist")]
        public string Stocklist { get; set; }
        [XmlAttribute("stocktype")]
        public string Stocktype { get; set; }
        [XmlElement("stockname")]
        public string stockname { get; set; }
        [XmlElement("buy")]
        public string buy { get; set; }
        [XmlElement("sell")]
        public string sell { get; set; }


        //public List<Stockitem> LoadXmlFile(string fileName)
        //{
        //    using (var stream = new FileStream(fileName, FileMode.Open))
        //    {
        //        var XmlFile = new XmlSerializer(typeof(List<Stockitem>));
        //        return (List<Stockitem>)XmlFile.Deserialize(stream);
        //    }
        //}

        public List<Stockitem> LoadXmlFile(string fileName)
        {
            var XmlFile = new XmlSerializer(typeof(List<Stockitem>));
            List<Stockitem> myStocks;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                myStocks = (List<Stockitem>)XmlFile.Deserialize(stream);
                
            }
            return myStocks;
        }
    }
}