
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic
{
	public interface IValuationBreakdownStatementType
	{
		IDType ID { get; set; }

		TextType Name { get; set; }

		TextType[] Description { get; set; }

		IDType[] MeasurementMethodID { get; set; }

		DateTimeType CreationDateTime { get; set; }

		//CurrencyCodeType DefaultCurrencyCode { get; set; }

		CodeType DefaultLanguageCode { get; set; }

		TextType[] Comment { get; set; }

		CodeType[] TypeCode { get; set; }

		CodeType[] RequestedActionCode { get; set; }

		IDType PriceListID { get; set; }

		CodeType ContractualLanguageCode { get; set; }

		//GroupedWorkItemType[] ItemGroupedWorkItem { get; set; }

		//BasicWorkItemType[] ItemBasicWorkItem { get; set; }

		//CalculatedPriceType[] TotalCalculatedPrice { get; set; }

		//RecordedStatusType[] ChangedRecordedStatus { get; set; }

		//SpecifiedBinaryFileType[] CreationSpecifiedBinaryFile { get; set; }

		//SpecifiedBinaryFileType[] ReaderSpecifiedBinaryFile { get; set; }

		//SpecifiedBinaryFileType[] ReferencedSpecifiedBinaryFile { get; set; }
	}
}
