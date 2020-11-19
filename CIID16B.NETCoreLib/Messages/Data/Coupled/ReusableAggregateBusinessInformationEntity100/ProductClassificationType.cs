
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
	public class ProductClassificationType
	{
		public IDType SystemID { get; set; }

		[XmlElement("SystemName")]
		public TextType[] SystemName { get; set; }

		public CodeType ClassCode { get; set; }

		[XmlElement("ClassName")]
		public TextType[] ClassName { get; set; }

		public CodeType SubClassCode { get; set; }

		[XmlElement("ClassProductCharacteristic")]
		public ProductCharacteristicType[] ClassProductCharacteristic { get; set; }

		public ReferencedStandardType ApplicableReferencedStandard { get; set; }
	}
}
