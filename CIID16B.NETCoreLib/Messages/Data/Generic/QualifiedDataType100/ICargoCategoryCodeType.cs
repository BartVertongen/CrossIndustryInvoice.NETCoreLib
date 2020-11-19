
namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface ICargoCategoryCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//CargoCategoryCodeListAgencyIDContentType listAgencyID { get; set; }

		//bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		string name { get; set; }

		//CodelistCoupled(enum) or string
		//ICargoTypeCodeContentType Value { get; set; }
	}
}
