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
    public class WorkItemComplexDescriptionType
    {
        [XmlElement("Abstract")]
        public TextType[] Abstract { get; set; }

        [XmlElement("Content")]
        public TextType[] Content { get; set; }

        public CodeType ContractualLanguageCode { get; set; }

        [XmlElement("RequestingSpecificationQuery")]
        public SpecificationQueryType[] RequestingSpecificationQuery { get; set; }

        [XmlElement("RespondingSpecificationResponse")]
        public SpecificationResponseType[] RespondingSpecificationResponse { get; set; }

        public WorkItemComplexDescriptionType SubsetWorkItemComplexDescription { get; set; }
    }
}
