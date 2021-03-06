﻿using System;
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


        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class xml
        {

            private xmlContentInstance[] contentInstanceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("contentInstance")]
            public xmlContentInstance[] contentInstance
            {
                get
                {
                    return this.contentInstanceField;
                }
                set
                {
                    this.contentInstanceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class xmlContentInstance
        {

            private xmlContentInstanceContent contentField;

            private string resourceNameField;

            private string resourceUnitField;

            private string creationTimeField;

            /// <remarks/>
            public xmlContentInstanceContent content
            {
                get
                {
                    return this.contentField;
                }
                set
                {
                    this.contentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string resourceName
            {
                get
                {
                    return this.resourceNameField;
                }
                set
                {
                    this.resourceNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string resourceUnit
            {
                get
                {
                    return this.resourceUnitField;
                }
                set
                {
                    this.resourceUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string creationTime
            {
                get
                {
                    return this.creationTimeField;
                }
                set
                {
                    this.creationTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class xmlContentInstanceContent
        {

            private decimal textContentField;

            /// <remarks/>
            public decimal textContent
            {
                get
                {
                    return this.textContentField;
                }
                set
                {
                    this.textContentField = value;
                }
            }
        }



    }
}
