
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
