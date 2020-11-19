
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
	public class MaterialGoodsCharacteristicType
	{
		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public CodeType TypeCode { get; set; }

		public PercentType ProportionalConstituentPercent { get; set; }

		public MeasureType AbsolutePresenceWeightMeasure { get; set; }

		public MeasureType AbsolutePresenceVolumeMeasure { get; set; }
	}
}
