﻿
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.Invoice100.Uncoupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ProductCharacteristicConditionType
	{
		public CodeType TypeCode { get; set; }

		[XmlElement("Name")]
		public TextType[] Name { get; set; }

		public MeasureType ValueMeasure { get; set; }
	}
}