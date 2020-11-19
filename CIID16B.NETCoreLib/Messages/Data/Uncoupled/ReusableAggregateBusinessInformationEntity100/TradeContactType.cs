
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
	public class TradeContactType
	{
		public IDType ID { get; set; }

		public TextType PersonName { get; set; }

		public TextType DepartmentName { get; set; }

		public ContactTypeCodeType TypeCode { get; set; }

		public TextType JobTitle { get; set; }

		public TextType Responsibility { get; set; }

		[XmlElement("PersonID")]
		public IDType[] PersonID { get; set; }

		public UniversalCommunicationType TelephoneUniversalCommunication { get; set; }

		public UniversalCommunicationType DirectTelephoneUniversalCommunication { get; set; }

		public UniversalCommunicationType MobileTelephoneUniversalCommunication { get; set; }

		public UniversalCommunicationType FaxUniversalCommunication { get; set; }

		public UniversalCommunicationType EmailURIUniversalCommunication { get; set; }

		public UniversalCommunicationType TelexUniversalCommunication { get; set; }

		public UniversalCommunicationType VOIPUniversalCommunication { get; set; }

		public UniversalCommunicationType InstantMessagingUniversalCommunication { get; set; }

		[XmlElement("SpecifiedNote")]
		public NoteType[] SpecifiedNote { get; set; }

		public ContactPersonType SpecifiedContactPerson { get; set; }
	}
}
