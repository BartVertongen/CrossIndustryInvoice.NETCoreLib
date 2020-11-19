
using System;
using System.Xml.Serialization;
using VertSoft.CrossIndustryInvoice.D16B.Data.QualifiedDataType100.Coupled;
using VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100;
using ciiValueType = VertSoft.CrossIndustryInvoice.D16B.Data.UnqualifiedDataType100.ValueType;


namespace VertSoft.CrossIndustryInvoice.D16B.Data.ReusableAggregateBusinessInformationEntity100.Coupled
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:standard:ReusableAggregateBusinessInformationEntity:100")]
    public class CreditorFinancialInstitutionType
    {
        public IDType BICID { get; set; }

        public IDType CHIPSUniversalID { get; set; }

        public IDType NewZealandNCCID { get; set; }

        public IDType IrishNSCID { get; set; }

        public IDType UKSortCodeID { get; set; }

        public IDType CHIPSParticipantID { get; set; }

        public IDType SwissBCID { get; set; }

        public IDType FedwireRoutingNumberID { get; set; }

        public IDType PortugueseNCCID { get; set; }

        public IDType RussianCentralBankID { get; set; }

        public IDType ItalianDomesticID { get; set; }

        public IDType AustrianBankleitzahlID { get; set; }

        public IDType CanadianPaymentsAssociationID { get; set; }

        public IDType SICID { get; set; }

        public IDType GermanBankleitzahlID { get; set; }

        public IDType SpanishDomesticInterbankingID { get; set; }

        public IDType SouthAfricanNCCID { get; set; }

        public IDType HongKongBankID { get; set; }

        public IDType AustralianBSBID { get; set; }

        public IDType IndianFinancialSystemID { get; set; }

        public IDType HellenicBankID { get; set; }

        public IDType PolishNationalClearingID { get; set; }

        public TextType Name { get; set; }

        public TextType ClearingSystemName { get; set; }

        public IDType JapanFinancialInstitutionCommonID { get; set; }

        public FinancialInstitutionAddressType LocationFinancialInstitutionAddress { get; set; }

        public BranchFinancialInstitutionType SubDivisionBranchFinancialInstitution { get; set; }
    }
}
