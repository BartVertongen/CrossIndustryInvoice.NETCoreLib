
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class AppliedTaxType
    {
        public AmountType CalculatedAmount { get; set; }

        public CodeType TypeCode { get; set; }

        public RateType CalculatedRate { get; set; }

        public AmountType BasisAmount { get; set; }

        public DateType TaxPointDate { get; set; }
    }
}
