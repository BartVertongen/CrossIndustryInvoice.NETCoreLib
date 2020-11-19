
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class RegisteredTaxType
    {
        public CodeType TypeCode { get; set; }

        public CodeType ExemptionReasonCode { get; set; }

        [XmlElement("ExemptionReason")]
        public TextType[] ExemptionReason { get; set; }

        public CodeType CurrencyCode { get; set; }

        [XmlElement("Jurisdiction")]
        public TextType[] Jurisdiction { get; set; }

        [XmlElement("Description")]
        public TextType[] Description { get; set; }

        public IndicatorType CustomsDutyIndicator { get; set; }
    }
}
