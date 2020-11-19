
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
    public class GroupedWorkItemType
    {
        public IDType ID { get; set; }

        [XmlElement("PrimaryClassificationCode")]
        public CodeType[] PrimaryClassificationCode { get; set; }

        [XmlElement("AlternativeClassificationCode")]
        public CodeType[] AlternativeClassificationCode { get; set; }

        [XmlElement("TypeCode")]
        public CodeType[] TypeCode { get; set; }

        [XmlElement("Comment")]
        public TextType[] Comment { get; set; }

        public QuantityType TotalQuantity { get; set; }

        public TextType Index { get; set; }

        [XmlElement("RequestedActionCode")]
        public CodeType[] RequestedActionCode { get; set; }

        public IDType PriceListItemID { get; set; }

        public CodeType ContractualLanguageCode { get; set; }

        [XmlElement("TotalCalculatedPrice")]
        public CalculatedPriceType[] TotalCalculatedPrice { get; set; }

        [XmlElement("ItemGroupedWorkItem")]
        public GroupedWorkItemType[] ItemGroupedWorkItem { get; set; }

        [XmlElement("ItemBasicWorkItem")]
        public BasicWorkItemType[] ItemBasicWorkItem { get; set; }

        [XmlElement("ChangedRecordedStatus")]
        public RecordedStatusType[] ChangedRecordedStatus { get; set; }

        [XmlElement("ActualWorkItemComplexDescription")]
        public WorkItemComplexDescriptionType[] ActualWorkItemComplexDescription { get; set; }

        [XmlElement("ReferencedSpecifiedBinaryFile")]
        public SpecifiedBinaryFileType[] ReferencedSpecifiedBinaryFile { get; set; }
    }
}
