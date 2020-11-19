
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
    public class SupplyChainConsignmentItemType
    {
        public GoodsTypeCodeType TypeCode { get; set; }

        public GoodsTypeExtensionCodeType TypeExtensionCode { get; set; }

        public AmountType DeclaredValueForCustomsAmount { get; set; }

        public AmountType DeclaredValueForStatisticsAmount { get; set; }

        [XmlElement("InvoiceAmount")]
        public AmountType[] InvoiceAmount { get; set; }

        public WeightUnitMeasureType GrossWeightMeasure { get; set; }

        public MeasureType NetWeightMeasure { get; set; }

        public QuantityType TariffQuantity { get; set; }

        public TransportCargoType NatureIdentificationTransportCargo { get; set; }
    }
}
