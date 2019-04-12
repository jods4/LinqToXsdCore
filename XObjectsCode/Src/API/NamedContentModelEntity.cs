using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Xml.Schema.Linq
{
    public class NamedContentModelEntity : ContentModelEntity
    {
        internal XName name;
        int elementPosition = -1;
        SchemaAwareContentModelEntity parentContentModel;

        public NamedContentModelEntity(XName name)
        {
            this.name = name;
        }

        public override void AddElementToParent(XName name, object value, XElement parentElement, bool addToExisting,
            XmlSchemaDatatype datatype)
        {
            throw new InvalidOperationException();
        }

        internal XName Name
        {
            get { return name; }
        }

        internal int ElementPosition
        {
            get { return elementPosition; }
            set { elementPosition = value; }
        }

        internal SchemaAwareContentModelEntity ParentContentModel
        {
            get { return this.parentContentModel; }
            set { this.parentContentModel = value; }
        }
    }
}