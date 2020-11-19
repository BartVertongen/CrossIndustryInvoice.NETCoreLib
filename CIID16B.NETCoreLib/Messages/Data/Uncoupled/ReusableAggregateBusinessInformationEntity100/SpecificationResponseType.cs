
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SpecificationResponseType
	{
		public IDType ID { get; set; }

		public IDType QueryID { get; set; }

		public CodeType TypeCode { get; set; }

		public TextType Content { get; set; }

		public CodeType ContractualLanguageCode { get; set; }
	}
}