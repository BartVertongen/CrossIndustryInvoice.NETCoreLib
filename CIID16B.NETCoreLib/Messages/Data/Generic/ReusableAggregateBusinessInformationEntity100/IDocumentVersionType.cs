
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Generic
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>No difference between Coupled and Uncoupled</remarks>
	public interface IDocumentVersionType
	{
		IDType ID { get; set; }

		TextType Name { get; set; }

		DateTimeType IssueDateTime { get; set; }
	}
}