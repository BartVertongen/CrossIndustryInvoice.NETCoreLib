
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Uncoupled;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class LogisticsTransportMovementType
	{
		public TransportMovementStageCodeType StageCode { get; set; }

		public TransportModeCodeType ModeCode { get; set; }

		public TextType Mode { get; set; }

		public LogisticsTransportMeansType UsedLogisticsTransportMeans { get; set; }
	}
}
