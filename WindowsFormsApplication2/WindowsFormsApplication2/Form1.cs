using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        The Deserialize function:

        CarCollection cars = null;
        string path = "cars.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(CarCollection));

        StreamReader reader = new StreamReader(path);
        cars = (CarCollection)serializer.Deserialize(reader);
        reader.Close();
    }
}
