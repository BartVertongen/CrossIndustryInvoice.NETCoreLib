
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ExchangedDocumentContextType: IExchangedDocumentContextType
	{
		public IDType SpecifiedTransactionID { get; set; }

		public IndicatorType TestIndicator { get; set; }

		[XmlElement("BusinessProcessSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] BusinessProcessSpecifiedDocumentContextParameter { get; set; }

		[XmlElement("BIMSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] BIMSpecifiedDocumentContextParameter { get; set; }

		[XmlElement("ScenarioSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] ScenarioSpecifiedDocumentContextParameter { get; set; }

		[XmlElement("ApplicationSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] ApplicationSpecifiedDocumentContextParameter { get; set; }


		[XmlElement("GuidelineSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] GuidelineSpecifiedDocumentContextParameter { get; set; }

		[XmlElement("SubsetSpecifiedDocumentContextParameter")]
		public IDocumentContextParameterType[] SubsetSpecifiedDocumentContextParameter { get; set; }

		public IDocumentContextParameterType MessageStandardSpecifiedDocumentContextParameter { get; set; }
	}
}
