
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class SubordinateLineTradeDeliveryType
	{
		public QuantityType PackageQuantity { get; set; }

		public QuantityType ProductUnitQuantity { get; set; }

		public QuantityType PerPackageUnitQuantity { get; set; }

		[XmlElement("IncludedSupplyChainPackaging")]
		public SupplyChainPackagingType[] IncludedSupplyChainPackaging { get; set; }
	}
}
