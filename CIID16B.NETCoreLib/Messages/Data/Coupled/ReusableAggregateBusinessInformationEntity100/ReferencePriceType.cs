
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
	public class ReferencePriceType
	{
		public AmountType ChargeAmount { get; set; }

		[XmlElement("BasisQuantity")]
		public QuantityType[] BasisQuantity { get; set; }

		[XmlElement("NetPriceIndicator")]
		public IndicatorType[] NetPriceIndicator { get; set; }

		public CodeType ComparisonMethodCode { get; set; }
	}
}
