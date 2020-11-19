
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ValuationBreakdownStatementType : IValuationBreakdownStatementType
	{
		public IDType ID { get; set; }

		public TextType Name { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("MeasurementMethodID")]
		public IDType[] MeasurementMethodID { get; set; }

		public DateTimeType CreationDateTime { get; set; }

		public CurrencyCodeType DefaultCurrencyCode { get; set; }

		public CodeType DefaultLanguageCode { get; set; }

		[XmlElement("Comment")]
		public TextType[] Comment { get; set; }

		[XmlElement("TypeCode")]
		public CodeType[] TypeCode { get; set; }

		[XmlElement("RequestedActionCode")]
		public CodeType[] RequestedActionCode { get; set; }

		public IDType PriceListID { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ItemGroupedWorkItem")]
		public GroupedWorkItemType[] ItemGroupedWorkItem { get; set; }

		[XmlElement("ItemBasicWorkItem")]
		public BasicWorkItemType[] ItemBasicWorkItem { get; set; }

		[XmlElement("TotalCalculatedPrice")]
		public CalculatedPriceType[] TotalCalculatedPrice { get; set; }


		[XmlElement("ChangedRecordedStatus")]
		public RecordedStatusType[] ChangedRecordedStatus { get; set; }


		[XmlElement("CreationSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] CreationSpecifiedBinaryFile { get; set; }


		[XmlElement("ReaderSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] ReaderSpecifiedBinaryFile { get; set; }


		[XmlElement("ReferencedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] ReferencedSpecifiedBinaryFile { get; set; }
	}
}
