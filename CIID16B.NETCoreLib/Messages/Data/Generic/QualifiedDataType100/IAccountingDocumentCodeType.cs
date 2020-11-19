

namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface IAccountingDocumentCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//AccountingDocumentCodeListAgencyIDContentType listAgencyID { get; set; }

		//bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		string listURI { get; set; }

		//CodelistCoupled(enum) or string
		//DocumentNameCodeAccountingContentType Value { get; set; }
	}
}
