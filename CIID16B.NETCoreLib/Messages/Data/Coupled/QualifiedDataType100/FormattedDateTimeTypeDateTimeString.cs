
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
    public class FormattedDateTimeTypeDateTimeString
    {
        [XmlAttribute()]
        public TimePointFormatCodeContentType format { get; set; }

        [XmlIgnore()]
        public bool formatSpecified { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}