
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic
{
	public interface IDocumentContextParameterType
	{
		IDType ID { get; set; }

		TextType Value { get; set; }

		IDocumentVersionType SpecifiedDocumentVersion { get; set; }
	}
}
