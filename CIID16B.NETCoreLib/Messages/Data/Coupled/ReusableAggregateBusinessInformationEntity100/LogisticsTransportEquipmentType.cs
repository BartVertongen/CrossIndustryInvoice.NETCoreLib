﻿
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
    public class LogisticsTransportEquipmentType
    {
        public IDType ID { get; set; }

        public LinearUnitMeasureType LoadingLengthMeasure { get; set; }

        public TransportEquipmentCategoryCodeType CategoryCode { get; set; }

        public TransportEquipmentSizeTypeCodeType CharacteristicCode { get; set; }

        public TransportEquipmentFullnessCodeType UsedCapacityCode { get; set; }

        public SpatialDimensionType LinearSpatialDimension { get; set; }
    }
}
