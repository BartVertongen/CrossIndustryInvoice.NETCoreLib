
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeLocationType
	{
		public CountryIDType CountryID { get; set; }

		public TextType CountryName { get; set; }

		public IDType ID { get; set; }

		public TextType Name { get; set; }
	}
}
