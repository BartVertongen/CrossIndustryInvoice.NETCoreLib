
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class NoteType
	{
		public TextType Subject { get; set; }

		public CodeType ContentCode { get; set; }

		[XmlElement("Content")]
		public TextType[] Content { get; set; }

		public CodeType SubjectCode { get; set; }

		public IDType ID { get; set; }
	}
}
