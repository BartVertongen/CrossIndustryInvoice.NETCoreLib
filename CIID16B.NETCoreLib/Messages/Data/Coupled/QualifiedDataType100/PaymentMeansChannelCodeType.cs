
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class PaymentMeansChannelCodeType
    {
        public PaymentMeansChannelCodeType()
        {
            this.listID = "4435";
            this.listAgencyID = PaymentMeansChannelCodeListAgencyIDContentType.Item6;
            this.listVersionID = "D16A";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute()]
        public PaymentMeansChannelCodeListAgencyIDContentType listAgencyID { get; set; }

        [XmlIgnore()]
        public bool listAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute()]
        public string name { get; set; }

        [XmlText()]
        public PaymentMeansChannelCodeContentType Value { get; set; }
    }
}
