
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
	public class DeliveryAdjustmentType
	{
		public AdjustmentReasonCodeType ReasonCode { get; set; }

		[XmlElement("Reason")]
		public TextType[] Reason { get; set; }

		[XmlElement("ActualAmount")]
		public AmountType[] ActualAmount { get; set; }

		public QuantityType ActualQuantity { get; set; }

		public DateTimeType ActualDateTime { get; set; }
	}
}
