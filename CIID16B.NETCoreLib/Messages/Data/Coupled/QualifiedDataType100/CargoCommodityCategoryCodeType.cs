
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
    public class CargoCommodityCategoryCodeType: ICargoCommodityCategoryCodeType
	{
        public CargoCommodityCategoryCodeType()
        {
            this.listID = "7357";
            this.listAgencyID = "6";
            this.listVersionID = "D16A";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listAgencyID { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute()]
        public string name { get; set; }

        [XmlText()]
        public CommodityIdentificationCodeContentType Value { get; set; }
    }
}
