
using System;
using System.Xml.Serialization;


namespace CII_D16B.NETCoreLib.Messages.CodeLists
{
	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:EDIFICAS-EU:AccountingAccountType:D11A")]
	public enum AccountingAccountTypeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
	}
}
