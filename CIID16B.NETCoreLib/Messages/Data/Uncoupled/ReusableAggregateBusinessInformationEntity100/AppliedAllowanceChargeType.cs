
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class AppliedAllowanceChargeType
	{
		public AmountType ActualAmount { get; set; }

		public TextType Description { get; set; }

		public CodeType ReasonCode { get; set; }

		public PercentType CalculationPercent { get; set; }

		public AmountType BasisAmount { get; set; }

		public IndicatorType ChargeIndicator { get; set; }

		public AppliedTaxType CategoryAppliedTax { get; set; }
	}
}
