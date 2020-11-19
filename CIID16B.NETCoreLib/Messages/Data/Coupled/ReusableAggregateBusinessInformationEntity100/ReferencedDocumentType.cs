
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
    public class ReferencedDocumentType
    {
        public IDType IssuerAssignedID { get; set; }

        public IDType URIID { get; set; }

        public DocumentStatusCodeType StatusCode { get; set; }

        public IndicatorType CopyIndicator { get; set; }

        public IDType LineID { get; set; }

        public DocumentCodeType TypeCode { get; set; }

        public IDType GlobalID { get; set; }

        public IDType RevisionID { get; set; }

        [XmlElement("Name")]
        public TextType[] Name { get; set; }

        [XmlElement("AttachmentBinaryObject")]
        public BinaryObjectType[] AttachmentBinaryObject { get; set; }

        [XmlElement("Information")]
        public TextType[] Information { get; set; }

        public ReferenceCodeType ReferenceTypeCode { get; set; }

        [XmlElement("SectionName")]
        public TextType[] SectionName { get; set; }

        [XmlElement("PreviousRevisionID")]
        public IDType[] PreviousRevisionID { get; set; }

        public FormattedDateTimeType FormattedIssueDateTime { get; set; }

        public SpecifiedPeriodType EffectiveSpecifiedPeriod { get; set; }

        public TradePartyType IssuerTradeParty { get; set; }

        [XmlElement("AttachedSpecifiedBinaryFile")]
        public SpecifiedBinaryFileType[] AttachedSpecifiedBinaryFile { get; set; }
    }
}
