
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Uncoupled
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
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
