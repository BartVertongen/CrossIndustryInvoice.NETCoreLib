
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class CalculatedPriceType
    {
        [XmlElement("TypeCode")]
        public CodeType[] TypeCode { get; set; }

        [XmlElement("ChargeAmount")]
        public AmountType[] ChargeAmount { get; set; }

        [XmlElement("RelatedAppliedAllowanceCharge")]
        public AppliedAllowanceChargeType[] RelatedAppliedAllowanceCharge { get; set; }
    }
}
