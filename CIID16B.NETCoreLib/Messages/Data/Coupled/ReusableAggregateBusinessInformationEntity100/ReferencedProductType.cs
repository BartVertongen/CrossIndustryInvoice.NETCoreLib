
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
	public class ReferencedProductType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		[XmlElement("GlobalID")]
		public IDType[] GlobalID { get; set; }

		public IDType SellerAssignedID { get; set; }

		public IDType BuyerAssignedID { get; set; }

		[XmlElement("ManufacturerAssignedID")]
		public IDType[] ManufacturerAssignedID { get; set; }

		[XmlElement("IndustryAssignedID")]
		public IDType[] IndustryAssignedID { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		[XmlElement("RelationshipTypeCode")]
		public CodeType[] RelationshipTypeCode { get; set; }

		[XmlElement("UnitQuantity")]
		public QuantityType[] UnitQuantity { get; set; }
	}
}
