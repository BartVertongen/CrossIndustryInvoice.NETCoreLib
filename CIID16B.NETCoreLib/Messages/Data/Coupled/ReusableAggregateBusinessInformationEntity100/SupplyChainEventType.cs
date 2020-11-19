
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SupplyChainEventType
	{
		public IDType ID { get; set; }

		public DateTimeType OccurrenceDateTime { get; set; }

		public CodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("DescriptionBinaryObject")]
		public BinaryObjectType[] DescriptionBinaryObject { get; set; }

		public QuantityType UnitQuantity { get; set; }

		public DateTimeType LatestOccurrenceDateTime { get; set; }

		public DateTimeType EarliestOccurrenceDateTime { get; set; }

		public SpecifiedPeriodType OccurrenceSpecifiedPeriod { get; set; }

		public LogisticsLocationType OccurrenceLogisticsLocation { get; set; }
	}
}
