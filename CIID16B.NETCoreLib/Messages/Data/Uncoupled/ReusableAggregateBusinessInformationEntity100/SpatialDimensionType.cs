
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SpatialDimensionType
	{
		public MeasureType ValueMeasure { get; set; }

		public DimensionTypeCodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public MeasureType WidthMeasure { get; set; }

		public MeasureType LengthMeasure { get; set; }

		public MeasureType HeightMeasure { get; set; }

		public IDType ID { get; set; }

		public LinearUnitMeasureType DiameterMeasure { get; set; }
	}
}
