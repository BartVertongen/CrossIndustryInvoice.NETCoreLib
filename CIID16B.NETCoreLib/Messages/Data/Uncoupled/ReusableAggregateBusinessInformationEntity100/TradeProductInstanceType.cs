
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
	public class TradeProductInstanceType
	{
		public IDType GlobalSerialID { get; set; }

		public IDType BatchID { get; set; }

		public IDType KanbanID { get; set; }

		public IDType SupplierAssignedSerialID { get; set; }

		public DateTimeType BestBeforeDateTime { get; set; }

		public DateTimeType ExpiryDateTime { get; set; }

		public DateTimeType SellByDateTime { get; set; }

		[XmlElement("SerialID")]
		public IDType[] SerialID { get; set; }

		[XmlElement("RegistrationID")]
		public IDType[] RegistrationID { get; set; }

		public SupplyChainEventType ProductionSupplyChainEvent { get; set; }

		public SupplyChainEventType PackagingSupplyChainEvent { get; set; }

		[XmlElement("ApplicableMaterialGoodsCharacteristic")]
		public MaterialGoodsCharacteristicType[] ApplicableMaterialGoodsCharacteristic { get; set; }

		[XmlElement("ApplicableProductCharacteristic")]
		public ProductCharacteristicType[] ApplicableProductCharacteristic { get; set; }
	}
}
