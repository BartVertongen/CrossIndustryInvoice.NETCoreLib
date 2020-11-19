
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
	public class TradePartyType
	{
		[XmlElement("ID")]
		public IDType[] ID { get; set; }

		[XmlElement("GlobalID")]
		public IDType[] GlobalID { get; set; }

		public TextType Name { get; set; }

		[XmlElement("RoleCode")]
		public PartyRoleCodeType[] RoleCode { get; set; }

		[XmlElement("Description")]
		public TextType[] Description { get; set; }

		public LegalOrganizationType SpecifiedLegalOrganization { get; set; }

		[XmlElement("DefinedTradeContact")]
		public TradeContactType[] DefinedTradeContact { get; set; }

		public TradeAddressType PostalTradeAddress { get; set; }

		[XmlElement("URIUniversalCommunication")]
		public UniversalCommunicationType[] URIUniversalCommunication { get; set; }

		[XmlElement("SpecifiedTaxRegistration")]
		public TaxRegistrationType[] SpecifiedTaxRegistration { get; set; }

		public UniversalCommunicationType EndPointURIUniversalCommunication { get; set; }

		[XmlElement("LogoAssociatedSpecifiedBinaryFile")]
		public SpecifiedBinaryFileType[] LogoAssociatedSpecifiedBinaryFile { get; set; }
	}
}
