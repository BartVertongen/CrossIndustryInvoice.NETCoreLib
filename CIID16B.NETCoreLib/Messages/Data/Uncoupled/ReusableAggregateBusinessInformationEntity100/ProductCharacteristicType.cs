
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Uncoupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ProductCharacteristicType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		public CodeType TypeCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public MeasureType ValueMeasure { get; set; }

		public CodeType MeasurementMethodCode { get; set; }

		[XmlElement("Value")]
		public TextType[] Value { get; set; }

		public CodeType ValueCode { get; set; }

		public DateTimeType ValueDateTime { get; set; }

		public IndicatorType ValueIndicator { get; set; }

		public CodeType ContentTypeCode { get; set; }

		public SpecifiedBinaryFileType ValueSpecifiedBinaryFile { get; set; }

		[XmlElement("ApplicableProductCharacteristicCondition")]
		public ProductCharacteristicConditionType[] ApplicableProductCharacteristicCondition { get; set; }

		public ReferencedStandardType ApplicableReferencedStandard { get; set; }
	}
}
