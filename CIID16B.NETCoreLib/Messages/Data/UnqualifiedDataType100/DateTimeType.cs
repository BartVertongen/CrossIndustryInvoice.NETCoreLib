
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class DateTimeType
	{
		[XmlElement("DateTime", typeof(DateTime))]
		[XmlElement("DateTimeString", typeof(DateTimeTypeDateTimeString))]
		public object Item { get; set; }
	}
}
