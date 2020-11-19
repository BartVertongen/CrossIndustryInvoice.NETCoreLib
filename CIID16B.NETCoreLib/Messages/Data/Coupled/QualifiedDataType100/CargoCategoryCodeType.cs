
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class CargoCategoryCodeType: ICargoCategoryCodeType
	{
        public CargoCategoryCodeType()
        {
            this.listID = "Recommendation 21-Annex I";
            this.listAgencyID = CargoCategoryCodeListAgencyIDContentType.Item6;
            this.listVersionID = "1996 Rev 2 Final";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute()]
        public CargoCategoryCodeListAgencyIDContentType listAgencyID { get; set; }

        [XmlIgnore()]
        public bool listAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute()]
        public string name { get; set; }

        [XmlText()]
        public CargoTypeCodeContentType Value { get; set; }
    }
}
