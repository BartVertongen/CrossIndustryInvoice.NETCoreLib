
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class ReferenceCodeType
    {
        public ReferenceCodeType()
        {
            this.listID = "1153_ReferenceTypeCode";
            this.listAgencyID = ReferenceCodeListAgencyIDContentType.Item6;
            this.listVersionID = "D16A";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute()]
        public ReferenceCodeListAgencyIDContentType listAgencyID { get; set; }

        [XmlIgnore()]
        public bool listAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute()]
        public string name { get; set; }

        [XmlText()]
        public ReferenceTypeCodeContentType Value { get; set; }
    }
}
