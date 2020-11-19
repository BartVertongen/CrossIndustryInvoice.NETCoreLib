
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using ciiValueType = VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100.ValueType;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class TradeSettlementHeaderMonetarySummationType
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

        [XmlElement("RoundingAmount")]
        public AmountType[] RoundingAmount { get; set; }

        [XmlElement("GrandTotalAmount")]
        public AmountType[] GrandTotalAmount { get; set; }

        [XmlElement("InformationAmount")]
        public AmountType[] InformationAmount { get; set; }

        [XmlElement("TotalPrepaidAmount")]
        public AmountType[] TotalPrepaidAmount { get; set; }

        [XmlElement("TotalDiscountAmount")]
        public AmountType[] TotalDiscountAmount { get; set; }

        [XmlElement("TotalAllowanceChargeAmount")]
        public AmountType[] TotalAllowanceChargeAmount { get; set; }

        [XmlElement("DuePayableAmount")]
        public AmountType[] DuePayableAmount { get; set; }

        [XmlElement("RetailValueExcludingTaxInformationAmount")]
        public AmountType[] RetailValueExcludingTaxInformationAmount { get; set; }

        [XmlElement("TotalDepositFeeInformationAmount")]
        public AmountType[] TotalDepositFeeInformationAmount { get; set; }

        [XmlElement("ProductValueExcludingTobaccoTaxInformationAmount")]
        public AmountType[] ProductValueExcludingTobaccoTaxInformationAmount { get; set; }

        [XmlElement("TotalRetailValueInformationAmount")]
        public AmountType[] TotalRetailValueInformationAmount { get; set; }

        [XmlElement("GrossLineTotalAmount")]
        public AmountType[] GrossLineTotalAmount { get; set; }

        [XmlElement("NetLineTotalAmount")]
        public AmountType[] NetLineTotalAmount { get; set; }

        [XmlElement("NetIncludingTaxesLineTotalAmount")]
        public AmountType[] NetIncludingTaxesLineTotalAmount { get; set; }
    }
}
