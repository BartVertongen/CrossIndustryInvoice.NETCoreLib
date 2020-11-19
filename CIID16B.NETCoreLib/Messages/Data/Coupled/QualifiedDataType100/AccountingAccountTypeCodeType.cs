﻿
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
    public class AccountingAccountTypeCodeType
    {
        public AccountingAccountTypeCodeType()
        {
            this.listID = "AccountingE501";
            this.listAgencyID = "210";
            this.listVersionID = "D11A";
        }

        [XmlAttribute(DataType = "token")]
        public string listID { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listAgencyID { get; set; }

        [XmlAttribute(DataType = "token")]
        public string listVersionID { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string listURI { get; set; }

        [XmlText()]
        public AccountingAccountTypeContentType Value { get; set; }
    }
}