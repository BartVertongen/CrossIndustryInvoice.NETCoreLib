using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class DisposalInstructionsType
	{
		public IDType MaterialID { get; set; }

		[XmlElement("RecyclingDescriptionCode")]
		public CodeType[] RecyclingDescriptionCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("RecyclingProcedure")]
		public TextType[] RecyclingProcedure { get; set; }
	}
}
