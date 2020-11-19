
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ExchangedDocumentType: IExchangedDocumentType
	{
		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public DocumentCodeType TypeCode { get; set; }

		public DateTimeType IssueDateTime { get; set; }

		public IndicatorType CopyIndicator { get; set; }

		public TextType Purpose { get; set; }

		public IndicatorType ControlRequirementIndicator { get; set; }

		[XmlElement("LanguageID")]
		public IDType[] LanguageID { get; set; }

		public MessageFunctionCodeType PurposeCode { get; set; }

		public DateTimeType RevisionDateTime { get; set; }

		public IDType VersionID { get; set; }

		public IDType GlobalID { get; set; }

		public IDType RevisionID { get; set; }

		public IDType PreviousRevisionID { get; set; }

		public CodeType CategoryCode { get; set; }

		[XmlElement("IncludedNote")]
		public NoteType[] IncludedNote { get; set; }

		public SpecifiedPeriodType EffectiveSpecifiedPeriod { get; set; }

		public TradePartyType IssuerTradeParty { get; set; }
	}
}
