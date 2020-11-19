
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
    public class LogisticsServiceChargeType
    {
        public FreightChargeTypeIDType ID { get; set; }

        [XmlElement("Description")]
        public TextType[] Description { get; set; }

        public CodeType PaymentArrangementCode { get; set; }

        public FreightChargeTariffClassCodeType TariffClassCode { get; set; }

        public CodeType ChargeCategoryCode { get; set; }

        public CodeType ServiceCategoryCode { get; set; }

        [XmlElement("DisbursementAmount")]
        public AmountType[] DisbursementAmount { get; set; }

        [XmlElement("AppliedAmount")]
        public AmountType[] AppliedAmount { get; set; }

        public TextType AllowanceCharge { get; set; }

        public ChargePayingPartyRoleCodeType PayingPartyRoleCode { get; set; }

        public LogisticsChargeCalculationBasisCodeType CalculationBasisCode { get; set; }

        public TextType CalculationBasis { get; set; }

        public CodeType TransportPaymentMethodCode { get; set; }

        public LogisticsLocationType PaymentPlaceLogisticsLocation { get; set; }

        public LogisticsLocationType AppliedFromLogisticsLocation { get; set; }

        public LogisticsLocationType AppliedToLogisticsLocation { get; set; }

        [XmlElement("AppliedTradeTax")]
        public TradeTaxType[] AppliedTradeTax { get; set; }
    }
}
