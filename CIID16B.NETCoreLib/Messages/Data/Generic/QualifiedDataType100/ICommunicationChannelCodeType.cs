

namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic
{
	public interface ICommunicationChannelCodeType
	{
		string listID { get; set; }

		//QualifiedDataType100.Coupled(enum) or string
		//CommunicationChannelCodeListAgencyIDContentType listAgencyID { get; set; }

		//bool listAgencyIDSpecified { get; set; }

		string listVersionID { get; set; }

		string listURI { get; set; }

		//CodelistCoupled(enum) or string
		//CommunicationMeansTypeCodeContentType Value { get; set; }
	}
}
