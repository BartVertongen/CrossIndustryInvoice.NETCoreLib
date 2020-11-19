
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
    public class TradePaymentPenaltyTermsType
    {
        public DateTimeType BasisDateTime { get; set; }

        public MeasureType BasisPeriodMeasure { get; set; }

        public AmountType BasisAmount { get; set; }

        public PercentType CalculationPercent { get; set; }

        public AmountType ActualPenaltyAmount { get; set; }
    }
}
