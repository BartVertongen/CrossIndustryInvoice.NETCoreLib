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
	public class TradeAccountingAccountType
	{
		public IDType ID { get; set; }

		public AccountingDocumentCodeType SetTriggerCode { get; set; }

		public AccountingAccountTypeCodeType TypeCode { get; set; }

		public AccountingAmountTypeCodeType AmountTypeCode { get; set; }

		public TextType Name { get; set; }

		public TextType CostReferenceDimensionPattern { get; set; }
	}
}
