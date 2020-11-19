
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class PaymentTermsIDType
    {
        [XmlAttribute(DataType = "token")]
        public string schemeID { get; set; }

        [XmlAttribute()]
        public PaymentTermsIDSchemeAgencyIDContentType schemeAgencyID { get; set; }

        [XmlIgnore()]
        public bool schemeAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string schemeVersionID { get; set; }

        [XmlText()]
        public PaymentTermsDescriptionIdentifierContentType Value { get; set; }
    }
}
