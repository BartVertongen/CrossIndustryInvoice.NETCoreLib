
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class ReferencedStandardType
	{
		public IDType ID { get; set; }

		public IDType VersionID { get; set; }

		public IDType ElementVersionID { get; set; }

		public IDType URIID { get; set; }

		public IDType PartID { get; set; }

		public IDType AgencyID { get; set; }
	}
}
