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
            [System.Xml.Serialization.XmlElementAttribute("StockNumber")]
            public string StockNumber { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Make")]
            public string Make { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Model")]
            public string Model { get; set; }
        }
.

[System.Xml.Serialization.XmlRootAttribute("Cars", Namespace = "", IsNullable = false)]
        public class Cars
        {
            [XmlArrayItem(typeof(Car))]
            public Car[] Car { get; set; }

        }
.

        public class CarSerializer
        {
            public Cars Deserialize()
            {
                Cars[] cars = null;
                string path = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/") + "cars.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(Cars[]));

                StreamReader reader = new StreamReader(path);
                reader.ReadToEnd();
                cars = (Cars[])serializer.Deserialize(reader);
                reader.Close();

                return cars;
            }
        }
    }
}
