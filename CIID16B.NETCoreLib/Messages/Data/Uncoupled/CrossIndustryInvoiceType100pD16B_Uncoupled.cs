
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Generic;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:CrossIndustryInvoice:100")]
	[XmlRoot("CrossIndustryInvoice", Namespace = "urn:un:unece:uncefact:data:standard:CrossIndustryInvoice:100", IsNullable = false)]
	public class CrossIndustryInvoiceType : ICrossIndustryInvoiceType
	{
		public IExchangedDocumentContextType ExchangedDocumentContext { get; set; }

		public IExchangedDocumentType ExchangedDocument { get; set; }

		public ISupplyChainTradeTransactionType SupplyChainTradeTransaction { get; set; }

		public IValuationBreakdownStatementType ValuationBreakdownStatement { get; set; }
	}
}