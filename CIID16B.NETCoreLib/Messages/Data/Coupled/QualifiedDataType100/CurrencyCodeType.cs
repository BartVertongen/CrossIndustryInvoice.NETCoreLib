
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class CurrencyCodeType
    {
        public CurrencyCodeType()
        {
            this.listID = "ISO 4217 3A";
            this.listAgencyID = CurrencyCodeListAgencyIDContentType.Item5;
            this.listVersionID = "2012-08-31";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute()]
        public CurrencyCodeListAgencyIDContentType listAgencyID { get; set; }

        [XmlIgnore()]
        public bool listAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string listURI { get; set; }

        [XmlText()]
        public ISO3AlphaCurrencyCodeContentType Value { get; set; }
    }
}
