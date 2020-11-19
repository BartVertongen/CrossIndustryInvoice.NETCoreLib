
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface IAccountingAmountTypeCodeType
	{
		string listID { get; set; }

		string listAgencyID { get; set; }

		string listVersionID { get; set; }

		string listURI { get; set; }

		//CodelistCoupled(enum) or string
		//AccountingAmountTypeContentType Value { get; set; }
	}
}
