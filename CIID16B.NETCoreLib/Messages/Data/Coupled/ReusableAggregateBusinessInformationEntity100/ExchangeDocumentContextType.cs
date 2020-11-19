
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class ExchangedDocumentContextType
    {
        public IDType SpecifiedTransactionID { get; set; }

        public IndicatorType TestIndicator { get; set; }

        [XmlElement("BusinessProcessSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] BusinessProcessSpecifiedDocumentContextParameter { get; set; }

        [XmlElement("BIMSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] BIMSpecifiedDocumentContextParameter { get; set; }


        [XmlElement("ScenarioSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] ScenarioSpecifiedDocumentContextParameter { get; set; }


        [XmlElement("ApplicationSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] ApplicationSpecifiedDocumentContextParameter { get; set; }


        [XmlElement("GuidelineSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] GuidelineSpecifiedDocumentContextParameter { get; set; }

        [XmlElement("SubsetSpecifiedDocumentContextParameter")]
        public DocumentContextParameterType[] SubsetSpecifiedDocumentContextParameter { get; set; }

        public DocumentContextParameterType MessageStandardSpecifiedDocumentContextParameter { get; set; }
    }
}
