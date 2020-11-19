﻿
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class VolumeUnitMeasureType
	{
		[XmlAttribute(DataType = "token")]
		public string unitCode { get; set; }

		[XmlAttribute(DataType = "token")]
		public string unitCodeListVersionID { get; set; }

		[XmlText()]
		public decimal Value { get; set; }
	}
}
