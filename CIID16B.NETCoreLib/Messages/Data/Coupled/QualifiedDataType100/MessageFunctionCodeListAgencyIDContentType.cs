
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public enum MessageFunctionCodeListAgencyIDContentType
	{
		[XmlEnum("6")]
		Item6,
	}
}