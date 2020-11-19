
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class LogisticsLocationType
	{
		public IDType ID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public CodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public GeographicalCoordinateType PhysicalGeographicalCoordinate { get; set; }

		public TradeAddressType PostalTradeAddress { get; set; }
	}
}
