
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:10 0")]
	public class ReturnableAssetInstructionsType
	{
		[XmlElement("MaterialID")]
		public IDType[] MaterialID { get; set; }

		[XmlElement("TermsAndConditionsDescription")]
		public TextType[] TermsAndConditionsDescription { get; set; }

		public CodeType TermsAndConditionsDescriptionCode { get; set; }

		[XmlElement("DepositValueSpecifiedAmount")]
		public AmountType[] DepositValueSpecifiedAmount { get; set; }

		public SpecifiedPeriodType DepositValueValiditySpecifiedPeriod { get; set; }
	}
}
