
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeSettlementLineMonetarySummationType
	{
		[XmlElement("LineTotalAmount")]
		public AmountType[] LineTotalAmount { get; set; }

		[XmlElement("ChargeTotalAmount")]
		public AmountType[] ChargeTotalAmount { get; set; }

		[XmlElement("AllowanceTotalAmount")]
		public AmountType[] AllowanceTotalAmount { get; set; }

		[XmlElement("TaxBasisTotalAmount")]
		public AmountType[] TaxBasisTotalAmount { get; set; }


		[XmlElement("TaxTotalAmount")]
		public AmountType[] TaxTotalAmount { get; set; }

		[XmlElement("GrandTotalAmount")]
		public AmountType[] GrandTotalAmount { get; set; }

		[XmlElement("InformationAmount")]
		public AmountType[] InformationAmount { get; set; }

		[XmlElement("TotalAllowanceChargeAmount")]
		public AmountType[] TotalAllowanceChargeAmount { get; set; }

		[XmlElement("TotalRetailValueInformationAmount")]
		public AmountType[] TotalRetailValueInformationAmount { get; set; }

		[XmlElement("GrossLineTotalAmount")]
		public AmountType[] GrossLineTotalAmount { get; set; }

		[XmlElement("NetLineTotalAmount")]
		public AmountType[] NetLineTotalAmount { get; set; }

		[XmlElement("NetIncludingTaxesLineTotalAmount")]
		public AmountType[] NetIncludingTaxesLineTotalAmount { get; set; }

		[XmlElement("ProductWeightLossInformationAmount")]
		public AmountType[] ProductWeightLossInformationAmount { get; set; }
	}
}
