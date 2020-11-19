
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic
{
	public interface IExchangedDocumentType
	{
		IDType ID { get; set; }

		TextType[] Name { get; set; }

		//DocumentCodeType TypeCode { get; set; }

		 DateTimeType IssueDateTime { get; set; }

		IndicatorType CopyIndicator { get; set; }

		TextType Purpose { get; set; }

		IndicatorType ControlRequirementIndicator { get; set; }

		IDType[] LanguageID { get; set; }

		//MessageFunctionCodeType PurposeCode { get; set; }

		DateTimeType RevisionDateTime { get; set; }

		IDType VersionID { get; set; }

		IDType GlobalID { get; set; }

		IDType RevisionID { get; set; }

		IDType PreviousRevisionID { get; set; }

		CodeType CategoryCode { get; set; }

		//NoteType[] IncludedNote { get; set; }

		//SpecifiedPeriodType EffectiveSpecifiedPeriod { get; set; }

		//TradePartyType IssuerTradeParty { get; set; }
	}
}
