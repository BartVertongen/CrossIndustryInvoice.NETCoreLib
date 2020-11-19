﻿
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:UnqualifiedDataType:100")]
	public class QuantityType
	{
		[XmlAttribute(DataType = "token")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListAgencyID { get; set; }

		[XmlAttribute()]
		public string unitCodeListAgencyName { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}
}
