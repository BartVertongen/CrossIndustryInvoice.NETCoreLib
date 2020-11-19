

namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface IChargePayingPartyRoleCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//ChargePayingPartyRoleCodeListAgencyIDContentType listAgencyID { get; set; }

		//bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		string name { get; set; }

		//CodelistCoupled(enum) or string
		//PartyRoleCodeChargePayingContentType Value { get; set; }
	}
}
