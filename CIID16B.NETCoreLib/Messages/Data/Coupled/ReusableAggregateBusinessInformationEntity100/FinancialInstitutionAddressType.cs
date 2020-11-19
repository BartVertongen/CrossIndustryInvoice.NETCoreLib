
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using ciiValueType = VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100.ValueType;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class FinancialInstitutionAddressType
    {
        public CodeType PostcodeCode { get; set; }

        public TextType BuildingNumber { get; set; }

        public TextType LineOne { get; set; }

        public TextType LineTwo { get; set; }

        public TextType LineThree { get; set; }

        public TextType LineFour { get; set; }

        public TextType LineFive { get; set; }

        public TextType StreetName { get; set; }

        public TextType CityName { get; set; }

        public IDType CountrySubDivisionID { get; set; }

        public IDType CountryID { get; set; }

        public CodeType TypeCode { get; set; }

        public TextType DepartmentName { get; set; }

        public TextType PostOfficeBox { get; set; }

        public IDType CityID { get; set; }

        public TextType CountrySubDivisionName { get; set; }

        public TextType CountryName { get; set; }
    }
}
