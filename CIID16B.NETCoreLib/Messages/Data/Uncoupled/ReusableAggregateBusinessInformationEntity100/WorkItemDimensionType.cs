
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class WorkItemDimensionType
	{
		public IDType ID { get; set; }

		public MeasureType ValueMeasure { get; set; }

		public TextType Description { get; set; }

		public CodeType TypeCode { get; set; }

		public CodeType ContractualLanguageCode { get; set; }

		[XmlElement("ComponentWorkItemDimension")]
		public WorkItemDimensionType[] ComponentWorkItemDimension { get; set; }
	}
}
