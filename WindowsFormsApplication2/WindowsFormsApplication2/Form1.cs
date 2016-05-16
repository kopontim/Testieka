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

        public class TeeSerialisointi
        {
            //The Deserialize function:

            CarCollection cars = null;
            string path = "cars.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(CarCollection));

            StreamReader reader = new StreamReader(path);
            cars = (CarCollection)serializer.Deserialize(reader);
            reader.Close();
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class doc
        {

            private docAssembly assemblyField;

            private docMember[] membersField;

            /// <remarks/>
            public docAssembly assembly
            {
                get
                {
                    return this.assemblyField;
                }
                set
                {
                    this.assemblyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("member", IsNullable = false)]
            public docMember[] members
            {
                get
                {
                    return this.membersField;
                }
                set
                {
                    this.membersField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class docAssembly
        {

            private string nameField;

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class docMember
        {

            private docMemberSummary summaryField;

            private string nameField;

            /// <remarks/>
            public docMemberSummary summary
            {
                get
                {
                    return this.summaryField;
                }
                set
                {
                    this.summaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class docMemberSummary
        {

            private docMemberSummarySee seeField;

            private string[] textField;

            /// <remarks/>
            public docMemberSummarySee see
            {
                get
                {
                    return this.seeField;
                }
                set
                {
                    this.seeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class docMemberSummarySee
        {

            private string crefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string cref
            {
                get
                {
                    return this.crefField;
                }
                set
                {
                    this.crefField = value;
                }
            }
        }



    }
}
