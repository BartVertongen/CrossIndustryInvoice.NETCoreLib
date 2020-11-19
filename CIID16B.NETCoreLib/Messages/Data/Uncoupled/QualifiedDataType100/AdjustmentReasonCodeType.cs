
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Generic;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:QualifiedDataType:100")]
	public class AdjustmentReasonCodeType : IAdjustmentReasonCodeType
	{
		public AdjustmentReasonCodeType()
		{
			this.listID = "4465";
			this.listAgencyID = "6";
		}

		[XmlAttribute(DataType = "token")]
		public string listID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listAgencyID { get; set; }

		[XmlAttribute(DataType = "token")]
		public string listVersionID { get; set; }

		[XmlText(DataType = "token")]
		public string Value { get; set; }
	}
}