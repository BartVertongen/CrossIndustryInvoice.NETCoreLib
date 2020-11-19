
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class FormattedDateTimeTypeDateTimeString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}
}
