
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
    public class SpecifiedBinaryFileType
    {
        [XmlElement("ID")]
        public IDType[] ID { get; set; }

        [XmlElement("Title")]
        public TextType[] Title { get; set; }

        [XmlElement("AuthorName")]
        public TextType[] AuthorName { get; set; }

        public IDType VersionID { get; set; }

        public TextType FileName { get; set; }

        public IDType URIID { get; set; }

        public CodeType MIMECode { get; set; }

        public CodeType EncodingCode { get; set; }

        public CodeType CharacterSetCode { get; set; }

        [XmlElement("IncludedBinaryObject")]
        public BinaryObjectType[] IncludedBinaryObject { get; set; }

        [XmlElement("Access")]
        public TextType[] Access { get; set; }

        [XmlElement("Description")]
        public TextType[] Description { get; set; }

        public MeasureType SizeMeasure { get; set; }

        public SpecifiedPeriodType AccessAvailabilitySpecifiedPeriod { get; set; }
    }
}
