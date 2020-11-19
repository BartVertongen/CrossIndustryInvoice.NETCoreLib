
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
	public class DocumentLineDocumentType
	{
		public IDType LineID { get; set; }

		public IDType ParentLineID { get; set; }

		public LineStatusCodeType LineStatusCode { get; set; }

		public CodeType LineStatusReasonCode { get; set; }

		[XmlElement("IncludedNote")]
		public NoteType[] IncludedNote { get; set; }
	}
}
