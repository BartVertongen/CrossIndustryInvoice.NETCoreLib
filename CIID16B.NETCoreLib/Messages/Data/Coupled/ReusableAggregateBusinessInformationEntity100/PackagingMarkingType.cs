
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
	public class PackagingMarkingType
	{
		[XmlElement("TypeCode")]
		public PackagingMarkingCodeType[] TypeCode { get; set; }

		[XmlElement("Content")]
		public TextType[] Content { get; set; }

		public DateTimeType ContentDateTime { get; set; }
		[XmlElement("ContentAmount")]
		public AmountType[] ContentAmount { get; set; }

		[XmlElement("BarcodeTypeCode")]
		public CodeType[] BarcodeTypeCode { get; set; }

		[XmlElement("ContentCode")]
		public CodeType[] ContentCode { get; set; }

		[XmlElement("AutomaticDataCaptureMethodTypeCode")]
		public AutomaticDataCaptureMethodCodeType[] AutomaticDataCaptureMethodTypeCode { get; set; }
	}
}
