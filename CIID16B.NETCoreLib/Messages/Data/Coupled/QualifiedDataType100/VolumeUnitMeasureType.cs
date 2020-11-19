
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class VolumeUnitMeasureType
    {
        [XmlAttribute()]
        public MeasurementUnitCommonCodeVolumeContentType unitCode { get; set; }

        [XmlIgnore()]
        public bool unitCodeSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string unitCodeListVersionID { get; set; }

        [XmlText()]
        public decimal Value { get; set; }
    }
}
