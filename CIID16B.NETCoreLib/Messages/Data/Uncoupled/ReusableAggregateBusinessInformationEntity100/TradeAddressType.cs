
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeAddressType
	{
		public IDType ID { get; set; }

		public CodeType PostcodeCode { get; set; }

		public TextType PostOfficeBox { get; set; }

		public TextType BuildingName { get; set; }

		public TextType LineOne { get; set; }

		public TextType LineTwo { get; set; }

		public TextType LineThree { get; set; }

		public TextType LineFour { get; set; }

		public TextType LineFive { get; set; }

		public TextType StreetName { get; set; }

		public TextType CityName { get; set; }

		public TextType CitySubDivisionName { get; set; }

		public CountryIDType CountryID { get; set; }

		[XmlElement("CountryName")]
		public TextType[] CountryName { get; set; }

		public IDType CountrySubDivisionID { get; set; }

		[XmlElement("CountrySubDivisionName")]
		public TextType[] CountrySubDivisionName { get; set; }

		public TextType AttentionOf { get; set; }

		public TextType CareOf { get; set; }

		public TextType BuildingNumber { get; set; }

		public TextType DepartmentName { get; set; }

		public TextType AdditionalStreetName { get; set; }
	}
}
