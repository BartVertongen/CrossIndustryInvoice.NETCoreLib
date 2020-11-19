
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
    public class TradeCurrencyExchangeType
    {
        public CurrencyCodeType SourceCurrencyCode { get; set; }

        public NumericType SourceUnitBasisNumeric { get; set; }

        public CurrencyCodeType TargetCurrencyCode { get; set; }

        public NumericType TargetUnitBaseNumeric { get; set; }

        public IDType MarketID { get; set; }

        public RateType ConversionRate { get; set; }

        public DateTimeType ConversionRateDateTime { get; set; }

        [XmlElement("AssociatedReferencedDocument")]
        public ReferencedDocumentType[] AssociatedReferencedDocument { get; set; }
    }
}
