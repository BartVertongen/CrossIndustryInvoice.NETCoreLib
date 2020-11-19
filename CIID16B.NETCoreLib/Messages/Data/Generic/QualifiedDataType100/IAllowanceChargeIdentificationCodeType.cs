
namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface IAllowanceChargeIdentificationCodeType
	{
		string listID { get; set; }

		string listAgencyID { get; set; }

		string listVersionID { get; set; }

		string listURI { get; set; }

		//CodelistCoupled(enum) or string
		//AllowanceChargeIdentificationCodeContentType Value { get; set; }
	}
}
