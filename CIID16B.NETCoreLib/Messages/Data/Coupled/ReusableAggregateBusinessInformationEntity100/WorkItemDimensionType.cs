
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
    public class WorkItemDimensionType
    {
        public IDType ID { get; set; }

        public MeasureType ValueMeasure { get; set; }

        public TextType Description { get; set; }

        public CodeType TypeCode { get; set; }

        public CodeType ContractualLanguageCode { get; set; }

        [XmlElement("ComponentWorkItemDimension")]
        public WorkItemDimensionType[] ComponentWorkItemDimension { get; set; }
    }
}
