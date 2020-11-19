
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class CountryIDType
    {
        public CountryIDType()
        {
            this.schemeVersionID = "second edition 2006";
        }

        [XmlAttribute(DataType = "token")]
        public string schemeID { get; set; }

        [XmlAttribute()]
        public CountryIDSchemeAgencyIDContentType schemeAgencyID { get; set; }

        [XmlIgnore()]
        public bool schemeAgencyIDSpecified { get; set; }

        [XmlAttribute(DataType = "token")]
        public string schemeVersionID { get; set; }

        [XmlText()]
        public ISOTwoletterCountryCodeContentType Value { get; set; }
    }
}
