using System;
using System.Xml.Serialization;
using System.Collections.Generic;


   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "content")]
    public class Content
    {
        [XmlElement(ElementName = "textContent")]
        public string TextContent {
            get;
            set;
        }
    }

    [XmlRoot(ElementName = "contentInstance")]
    public class ContentInstance
    {
        [XmlElement(ElementName = "content")]
        public Content Content {
            get;
            set;
        }
        [XmlAttribute(AttributeName = "resourceName")]
        public string ResourceName {
            get;
            set;
        }
        [XmlAttribute(AttributeName = "resourceUnit")]
        public string ResourceUnit {
            get;
            set;
        }
        [XmlAttribute(AttributeName = "creationTime")]
        public string CreationTime {
            get;
            set;
        }
    }

    [XmlRoot(ElementName = "xml")]
    public class Xml
    {
        [XmlElement(ElementName = "contentInstance")]
        public List<ContentInstance> ContentInstance {
            get;
            set;
        }
    }

}

