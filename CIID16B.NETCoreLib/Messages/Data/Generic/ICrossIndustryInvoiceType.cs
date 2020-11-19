
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic;
using VertSoft.Common;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Generic
{
	public interface ICrossIndustryInvoiceType: IInvoice
	{
		IExchangedDocumentContextType ExchangedDocumentContext { get; set; }

		IExchangedDocumentType ExchangedDocument { get; set; }

		ISupplyChainTradeTransactionType SupplyChainTradeTransaction { get; set; }

		IValuationBreakdownStatementType ValuationBreakdownStatement { get; set; }
	}
}