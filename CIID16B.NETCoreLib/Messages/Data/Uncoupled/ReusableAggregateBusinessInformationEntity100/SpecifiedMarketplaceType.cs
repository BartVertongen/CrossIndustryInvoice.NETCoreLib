
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SpecifiedMarketplaceType
	{
		public IDType ID { get; set; }

		public TextType Name { get; set; }

		public IndicatorType VirtualIndicator { get; set; }

		[XmlElement("WebsiteURIID")]
		public IDType[] WebsiteURIID { get; set; }

		public CodeType SalesMethodCode { get; set; }

		[XmlElement("OrderingAvailablePeriod")]
		public AvailablePeriodType[] OrderingAvailablePeriod { get; set; }
	}
}
