
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class IndicatorTypeIndicatorString
	{
		[XmlAttribute()]
		public string format { get; set; }

		[XmlText()]
		public string Value { get; set; }
	}
}
