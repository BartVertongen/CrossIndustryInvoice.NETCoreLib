

namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface ICargoOperationalCategoryCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//CargoOperationalCategoryCodeListAgencyIDContentType listAgencyID { get; set; }

		//public bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		string name { get; set; }

		//CodelistCoupled(enum) or string
		//CargoOperationalCategoryCodeContentType Value { get; set; }
	}
}
