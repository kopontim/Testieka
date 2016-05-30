using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication2
{
    class Class1
    {
    }

    [Serializable()]
    public class Car
    {
        [System.Xml.Serialization.XmlElement("StockNumber")]
        public string StockNumber { get; set; }

        [System.Xml.Serialization.XmlElement("Make")]
        public string Make { get; set; }

        [System.Xml.Serialization.XmlElement("Model")]
        public string Model { get; set; }
    }


    [Serializable()]
    [System.Xml.Serialization.XmlRoot("CarCollection")]
    public class CarCollection
    {
        [XmlArray("Cars")]
        [XmlArrayItem("Car", typeof(Car))]
        public Car[] Car { get; set; }
    }

    public class TeeSerialisointi
    {
        //The Deserialize function:

        CarCollection cars = null;
        string path = "cars.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(CarCollection));

        //            System.IO.StreamReader reader = new StreamReader(path);
        StreamReader reader = new StreamReader("cars.xml");
        CarCollection cars = (CarCollection)serializer.Deserialize(reader);
        reader.Close();
        }



}
