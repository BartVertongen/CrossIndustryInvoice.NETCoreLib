
namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface IAdjustmentReasonCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//IAdjustmentReasonCodeListAgencyIDContentType listAgencyID { get; set; }

		//bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		//CodelistCoupled(enum) or string
		//IAdjustmentReasonDescriptionCodeContentType Value { get; set; }
	}
}