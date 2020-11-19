
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
    public class AllowanceChargeReasonCodeType : IAllowanceChargeReasonCodeType
	{
        public AllowanceChargeReasonCodeType()
        {
            this.listID = "4465_AllowanceChargeReasonCode";
            this.listAgencyID = AllowanceChargeReasonCodeListAgencyIDContentType.Item6;
            this.listVersionID = "D16A";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute()]
        public AllowanceChargeReasonCodeListAgencyIDContentType listAgencyID { get; set; }

        [XmlIgnore()]
        public bool listAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string listURI { get; set; }

        [XmlText()]
        public AllowanceChargeReasonCodeContentType Value { get; set; }
    }
}
