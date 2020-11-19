
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic
{
	public interface IExchangedDocumentContextType
	{
		IDType SpecifiedTransactionID { get; set; }

		IndicatorType TestIndicator { get; set; }

		IDocumentContextParameterType[] BusinessProcessSpecifiedDocumentContextParameter { get; set; }

		IDocumentContextParameterType[] BIMSpecifiedDocumentContextParameter { get; set; }


		IDocumentContextParameterType[] ScenarioSpecifiedDocumentContextParameter { get; set; }


		IDocumentContextParameterType[] ApplicationSpecifiedDocumentContextParameter { get; set; }

		IDocumentContextParameterType[] GuidelineSpecifiedDocumentContextParameter { get; set; }

		IDocumentContextParameterType[] SubsetSpecifiedDocumentContextParameter { get; set; }

		IDocumentContextParameterType MessageStandardSpecifiedDocumentContextParameter { get; set; }
	}
}
