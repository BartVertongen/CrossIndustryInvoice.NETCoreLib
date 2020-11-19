
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class IndicatorType
	{
		[XmlElement("Indicator", typeof(bool))]
		[XmlElement("IndicatorString", typeof(IndicatorTypeIndicatorString))]
		public object Item { get; set; }
	}
}
