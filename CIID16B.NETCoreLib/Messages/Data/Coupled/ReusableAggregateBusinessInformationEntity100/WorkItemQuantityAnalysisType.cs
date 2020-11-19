
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
    public class WorkItemQuantityAnalysisType
    {
        public IDType ID { get; set; }

        public QuantityType ActualQuantity { get; set; }

        public TextType Description { get; set; }

        public PercentType ActualQuantityPercent { get; set; }

        public CodeType StatusCode { get; set; }

        public CodeType TypeCode { get; set; }

        [XmlElement("PrimaryClassificationCode")]
        public CodeType[] PrimaryClassificationCode { get; set; }

        [XmlElement("AlternativeClassificationCode")]
        public CodeType[] AlternativeClassificationCode { get; set; }

        public CodeType ContractualLanguageCode { get; set; }

        [XmlElement("ActualQuantityWorkItemDimension")]
        public WorkItemDimensionType[] ActualQuantityWorkItemDimension { get; set; }

        [XmlElement("BreakdownWorkItemQuantityAnalysis")]
        public WorkItemQuantityAnalysisType[] BreakdownWorkItemQuantityAnalysis { get; set; }

        [XmlElement("ChangedRecordedStatus")]
        public RecordedStatusType[] ChangedRecordedStatus { get; set; }
    }
}
