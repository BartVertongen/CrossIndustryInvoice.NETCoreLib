
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using ciiValueType = VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100.ValueType;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class SpecifiedPeriodType
    {
        [XmlElement("DurationMeasure")]
        public MeasureType[] DurationMeasure { get; set; }

        public IndicatorType InclusiveIndicator { get; set; }

        [XmlElement("Description")]
        public TextType[] Description { get; set; }

        public DateTimeType StartDateTime { get; set; }

        public DateTimeType EndDateTime { get; set; }

        public DateTimeType CompleteDateTime { get; set; }

        public IndicatorType OpenIndicator { get; set; }

        public CodeType SeasonCode { get; set; }

        public IDType ID { get; set; }

        [XmlElement("Name")]
        public TextType[] Name { get; set; }

        public NumericType SequenceNumeric { get; set; }

        public CodeType StartDateFlexibilityCode { get; set; }

        public IndicatorType ContinuousIndicator { get; set; }

        public CodeType PurposeCode { get; set; }
    }
}
