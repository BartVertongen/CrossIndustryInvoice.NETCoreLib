
using System;
using System.Xml.Serialization;


namespace VertSoft.CrossIndustryInvoice.D16B.Codelists.Coupled
{
    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:ISO:ISO3AlphaCurrencyCode:2012-08-31")]
    public enum ISO3AlphaCurrencyCodeContentType
    {
        AED, AFN,
        ALL, AMD,
        ANG, AOA,
        ARS,
        AUD,
        AWG,
        AZN,
        BAM,
        BBD,
        BDT,
        BGN,
        BHD,
        BIF,
        BMD,
        BND,
        BOB,
        BOV,
        BRL,
        BSD,
        BTN,
        BWP,
        BYN,
        BZD,
        CAD,
        CDF,
        CHE,
        CHF,
        CHW,
        CLF,
        CLP,
        CNY,
        COP,
        COU,
        CRC,
        CUC,
        CUP,
        CVE,
        CZK,
        DJF,
        DKK,
        DOP,
        DZD,
        EGP,
        ERN,
        ETB,
        EUR,
        FJD,
        FKP,
        GBP,
        GEL,
        GHS,
        GIP,
        GMD,
        GNF,
        GTQ,
        GYD,
        HKD,
        HNL,
        HRK,
        HUF,
        IDR,
        ILS,
        INR,
        IQD,
        IRR,
        ISK,
        JMD,
        JOD,
        JPY,
        KES,
        KGS,
        KHR,
        KMF,
        KPW,
        KRW,
        KWD,
        KYD,
        KZT,
        LAK,
        LBP,
        LKR,
        LRD,
        LSL,
        LYD,
        MAD,
        MDL,
        MGA,
        MKD,
        MMK,
        MNT,
        MOP,
        MRO,
        MUR,
        MVR,
        MWK,
        MXN,
        MXV,
        MYR,
        MZN,
        NAD,
        NGN,
        NIO,
        NOK,
        NPR,
        NZD,
        OMR,
        PAB,
        PEN,
        PGK,
        PHP,
        PKR,
        PLN,
        PYG,
        QAR,
        RON,
        RSD,
        RUB,
        RWF,
        SAR,
        SBD,
        SCR,
        SDG,
        SEK,
        SGD,
        SHP,
        SLL,
        SOS,
        SRD,
        SSP,
        STD,
        SVC,
        SYP,
        SZL,
        THB,
        TJS,
        TMT,
        TND,
        TOP,
        TRY,
        TTD,
        TWD,
        TZS,
        UAH,
        UGX,
        USD,
        USN,
        UYI,
        UYU,
        UZS,
        VEF,
        VND,
        VUV,
        WST,
        XAF,
        XAG,
        XAU,
        XBA,
        XBB,
        XBC,
        XBD,
        XCD,
        XDR,
        XOF,
        XPD,
        XPF,
        XPT,
        XSU,
        XTS,
        XUA,
        XXX,
        YER,
        ZAR,
        ZMW,
        ZWL,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TimePointFormatCode:D16A")]
    public enum TimePointFormatCodeContentType
    {
        [XmlEnum("102")]
        Item102,
        [XmlEnum("203")]
        Item203,
        [XmlEnum("205")]
        Item205,
        [XmlEnum("209")]
        Item209,
        [XmlEnum("502")]
        Item502,
        [XmlEnum("602")]
        Item602,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DutyTaxFeeTypeCode:D16A")]
    public enum DutyTaxFeeTypeCodeContentType
    {
        AAA,
        AAB,
        AAC,
        AAD,
        AAE,
        AAF,
        AAG,
        AAH,
        AAI,
        AAJ,
        AAK,
        AAL,
        AAM,
        ADD,
        BOL,
        CAP,
        CAR,
        COC,
        CST,
        CUD,
        CVD,
        ENV,
        EXC,
        EXP,
        FET,
        FRE,
        GCN,
        GST,
        ILL,
        IMP,
        IND,
        LAC,
        LCN,
        LDP,
        LOC,
        LST,
        MCA,
        MCD,
        OTH,
        PDB,
        PDC,
        PRF,
        SCN,
        SSS,
        STT,
        SUP,
        SUR,
        SWT,
        TAC,
        TOT,
        TOX,
        TTA,
        VAD,
        VAT,
    }

	[System.Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MeasurementUnitCommonCode_FileSize:4")]
	[XmlRoot("MeasurementUnitCommonCodeFileSize",
		   Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MeasurementUnitCommonCode_FileSize:4", IsNullable = false)]
	public enum MeasurementUnitCommonCodeFileSizeContentType
	{
		[XmlEnum("4L")]
		Item4L,
		E34,
		E35,
	}


	[Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DutyorTaxorFeeCategoryCode:D16A")]
    public enum DutyorTaxorFeeCategoryCodeContentType
    {
        A,
        AA,
        AB,
        AC,
        AD,
        AE,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        O,
        S,
        Z,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:EventTimeReferenceCode:D16A")]
    public enum EventTimeReferenceCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("42")]
        Item42,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("44")]
        Item44,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("46")]
        Item46,
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("54")]
        Item54,
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("60")]
        Item60,
        [XmlEnum("61")]
        Item61,
        [XmlEnum("62")]
        Item62,
        [XmlEnum("63")]
        Item63,
        [XmlEnum("64")]
        Item64,
        [XmlEnum("65")]
        Item65,
        [XmlEnum("66")]
        Item66,
        [XmlEnum("67")]
        Item67,
        [XmlEnum("68")]
        Item68,
        [XmlEnum("69")]
        Item69,
        [XmlEnum("70")]
        Item70,
        [XmlEnum("71")]
        Item71,
        [XmlEnum("72")]
        Item72,
        [XmlEnum("73")]
        Item73,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,
        [XmlEnum("76")]
        Item76,
        [XmlEnum("77")]
        Item77,
        [XmlEnum("78")]
        Item78,
        [XmlEnum("79")]
        Item79,
        [XmlEnum("80")]
        Item80,
        [XmlEnum("81")]
        Item81,
        [XmlEnum("82")]
        Item82,
        [XmlEnum("83")]
        Item83,
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DocumentNameCode_Accounting:D16A")]
    public enum DocumentNameCodeAccountingContentType
    {
        [XmlEnum("105")]
        Item105,
        [XmlEnum("220")]
        Item220,
        [XmlEnum("223")]
        Item223,
        [XmlEnum("224")]
        Item224,
        [XmlEnum("245")]
        Item245,
        [XmlEnum("315")]
        Item315,
        [XmlEnum("320")]
        Item320,
        [XmlEnum("325")]
        Item325,
        [XmlEnum("326")]
        Item326,
        [XmlEnum("380")]
        Item380,
        [XmlEnum("389")]
        Item389,
        [XmlEnum("393")]
        Item393,
        [XmlEnum("394")]
        Item394,
        [XmlEnum("395")]
        Item395,
        [XmlEnum("398")]
        Item398,
        [XmlEnum("399")]
        Item399,
        [XmlEnum("455")]
        Item455,
        [XmlEnum("481")]
        Item481,
        [XmlEnum("533")]
        Item533,
        [XmlEnum("534")]
        Item534,
        [XmlEnum("640")]
        Item640,
        [XmlEnum("719")]
        Item719,
        [XmlEnum("731")]
        Item731,
        [XmlEnum("747")]
        Item747,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:EDIFICAS-EU:AccountingAccountType:D11A")]
    public enum AccountingAccountTypeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:EDIFICAS-EU:AccountingAmountType:D11A")]
    public enum AccountingAmountTypeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:identifierlist:standard:ISO:ISOTwo-letterCountryCode:Second Edition2006")]
    public enum ISOTwoletterCountryCodeContentType
    {
        AD,
        AE,
        AF,
        AG,
        AI,
        AL,
        AM,
        AO,
        AQ,
        AR,
        AS,
        AT,
        AU,
        AW,
        AX,
        AZ,
        BA,
        BB,
        BD,
        BE,
        BF,
        BG,
        BH,
        BI,
        BJ,
        BL,
        BM,
        BN,
        BO,
        BQ,
        BR,
        BS,
        BT,
        BV,
        BW,
        BY,
        BZ,
        CA,
        CC,
        CD,
        CF,
        CG,
        CH,
        CI,
        CK,
        CL,
        CM,
        CN,
        CO,
        CR,
        CU,
        CV,
        CW,
        CX,
        CY,
        CZ,
        DE,
        DJ,
        DK,
        DM,
        DO,
        DZ,
        EC,
        EE,
        EG,
        EH,
        ER,
        ES,
        ET,
        FI,
        FJ,
        FK,
        FM,
        FO,
        FR,
        GA,
        GB,
        GD,
        GE,
        GF,
        GG,
        GH,
        GI,
        GL,
        GM,
        GN,
        GP,
        GQ,
        GR,
        GS,
        GT,
        GU,
        GW,
        GY,
        HK,
        HM,
        HN,
        HR,
        HT,
        HU,
        ID,
        IE,
        IL,
        IM,
        IN,
        IO,
        IQ,
        IR,
        IS,
        IT,
        JE,
        JM,
        JO,
        JP,
        KE,
        KG,
        KH,
        KI,
        KM,
        KN,
        KP,
        KR,
        KW,
        KY,
        KZ,
        LA,
        LB,
        LC,
        LI,
        LK,
        LR,
        LS,
        LT,
        LU,
        LV,
        LY,
        MA,
        MC,
        MD,
        ME,
        MF,
        MG,
        MH,
        MK,
        ML,
        MM,
        MN,
        MO,
        MP,
        MQ,
        MR,
        MS,
        MT,
        MU,
        MV,
        MW,
        MX,
        MY,
        MZ,
        NA,
        NC,
        NE,
        NF,
        NG,
        NI,
        NL,
        NO,
        NP,
        NR,
        NU,
        NZ,
        OM,
        PA,
        PE,
        PF,
        PG,
        PH,
        PK,
        PL,
        PM,
        PN,
        PR,
        PS,
        PT,
        PW,
        PY,
        QA,
        RE,
        RO,
        RS,
        RU,
        RW,
        SA,
        SB,
        SC,
        SD,
        SE,
        SG,
        SH,
        SI,
        SJ,
        SK,
        SL,
        SM,
        SN,
        SO,
        SR,
        SS,
        ST,
        SV,
        SX,
        SY,
        SZ,
        TC,
        TD,
        TF,
        TG,
        TH,
        TJ,
        TK,
        TL,
        TM,
        TN,
        TO,
        TR,
        TT,
        TV,
        TW,
        TZ,
        UA,
        UG,
        UM,
        US,
        UY,
        UZ,
        VA,
        VC,
        VE,
        VG,
        VI,
        VN,
        VU,
        WF,
        WS,
        YE,
        YT,
        ZA,
        ZM,
        ZW,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PaymentGuaranteeMeansCode:D16A")]
    public enum PaymentGuaranteeMeansCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("45")]
        Item45,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PaymentMeansCode:D16A")]
    public enum PaymentMeansCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("35")]
        Item35,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("42")]
        Item42,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("44")]
        Item44,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("46")]
        Item46,
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("49")]
        Item49,
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("54")]
        Item54,
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("58")]
        Item58,
        [XmlEnum("59")]
        Item59,
        [XmlEnum("60")]
        Item60,
        [XmlEnum("61")]
        Item61,
        [XmlEnum("62")]
        Item62,
        [XmlEnum("63")]
        Item63,
        [XmlEnum("64")]
        Item64,
        [XmlEnum("65")]
        Item65,
        [XmlEnum("66")]
        Item66,
        [XmlEnum("67")]
        Item67,
        [XmlEnum("68")]
        Item68,
        [XmlEnum("70")]
        Item70,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,
        [XmlEnum("76")]
        Item76,
        [XmlEnum("77")]
        Item77,
        [XmlEnum("78")]
        Item78,
        [XmlEnum("91")]
        Item91,
        [XmlEnum("92")]
        Item92,
        [XmlEnum("93")]
        Item93,
        [XmlEnum("94")]
        Item94,
        [XmlEnum("95")]
        Item95,
        [XmlEnum("96")]
        Item96,
        [XmlEnum("97")]
        Item97,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PaymentMeansChannelCode:D16A")]
    public enum PaymentMeansChannelCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PartyRoleCode:D16A")]
    public enum PartyRoleCodeContentType
    {
        AA, AB,
        AE, AF,
        AG, AH,
        AI, AJ,
        AK,
        AL,
        AM,
        AN,
        AO,
        AP,
        AQ,
        AR,
        AS,
        AT,
        AU,
        AV,
        AW,
        AX,
        AY,
        AZ,
        B1,
        B2,
        BA,
        BB,
        BC,
        BD,
        BE,
        BF,
        BG,
        BH,
        BI,
        BJ,
        BK,
        BL,
        BM,
        BN,
        BO,
        BP,
        BQ,
        BS,
        BT,
        BU,
        BV,
        BW,
        BX,
        BY,
        BZ,
        C1,
        C2,
        CA,
        CB,
        CC,
        CD,
        CE,
        CF,
        CG,
        CH,
        CI,
        CJ,
        CK,
        CL,
        CM,
        CN,
        CNX,
        CNY,
        CNZ,
        CO,
        COA,
        COB,
        COC,
        COD,
        COE,
        COF,
        COG,
        COH,
        COI,
        COJ,
        COK,
        COL,
        COM,
        CON,
        COO,

        /// <remarks/>
        COP,

        /// <remarks/>
        COQ,

        /// <remarks/>
        COR,

        /// <remarks/>
        COS,

        /// <remarks/>
        COT,

        /// <remarks/>
        COU,

        /// <remarks/>
        COV,

        /// <remarks/>
        COW,

        /// <remarks/>
        COX,

        /// <remarks/>
        COY,

        /// <remarks/>
        COZ,

        /// <remarks/>
        CP,

        /// <remarks/>
        CPA,

        /// <remarks/>
        CPB,

        /// <remarks/>
        CPC,

        /// <remarks/>
        CPD,

        /// <remarks/>
        CPE,

        /// <remarks/>
        CPF,

        /// <remarks/>
        CPG,

        /// <remarks/>
        CPH,

        /// <remarks/>
        CPI,

        /// <remarks/>
        CPJ,

        /// <remarks/>
        CPK,

        /// <remarks/>
        CPL,

        /// <remarks/>
        CPM,

        /// <remarks/>
        CPN,

        /// <remarks/>
        CPO,

        /// <remarks/>
        CQ,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,
        CV,
        CW,

        /// <remarks/>
        CX,

        /// <remarks/>
        CY,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DA,

        /// <remarks/>
        DB,
        DC,
        DCP,
        DCQ,

        /// <remarks/>
        DCR,

        /// <remarks/>
        DCS,

        /// <remarks/>
        DCT,

        /// <remarks/>
        DCU,

        /// <remarks/>
        DCV,

        /// <remarks/>
        DCW,

        /// <remarks/>
        DCX,

        /// <remarks/>
        DCY,

        /// <remarks/>
        DCZ,

        /// <remarks/>
        DD,

        /// <remarks/>
        DDA,

        /// <remarks/>
        DDB,

        /// <remarks/>
        DDC,

        /// <remarks/>
        DDD,

        /// <remarks/>
        DDE,

        /// <remarks/>
        DDF,

        /// <remarks/>
        DDG,

        /// <remarks/>
        DDH,

        /// <remarks/>
        DDI,

        /// <remarks/>
        DDJ,

        /// <remarks/>
        DDK,

        /// <remarks/>
        DDL,

        /// <remarks/>
        DDM,

        /// <remarks/>
        DDN,

        /// <remarks/>
        DDO,

        /// <remarks/>
        DDP,

        /// <remarks/>
        DDQ,

        /// <remarks/>
        DDR,

        /// <remarks/>
        DDS,

        /// <remarks/>
        DDT,

        /// <remarks/>
        DDU,

        /// <remarks/>
        DDV,

        /// <remarks/>
        DDW,

        /// <remarks/>
        DDX,

        /// <remarks/>
        DDY,

        /// <remarks/>
        DDZ,

        /// <remarks/>
        DE,

        /// <remarks/>
        DEA,

        /// <remarks/>
        DEB,

        /// <remarks/>
        DEC,

        /// <remarks/>
        DED,

        /// <remarks/>
        DEE,

        /// <remarks/>
        DEF,

        /// <remarks/>
        DEG,

        /// <remarks/>
        DEH,

        /// <remarks/>
        DEI,

        /// <remarks/>
        DEJ,

        /// <remarks/>
        DEK,

        /// <remarks/>
        DEL,

        /// <remarks/>
        DEM,

        /// <remarks/>
        DEN,

        /// <remarks/>
        DEO,

        /// <remarks/>
        DEP,

        /// <remarks/>
        DEQ,

        /// <remarks/>
        DER,

        /// <remarks/>
        DES,

        /// <remarks/>
        DET,

        /// <remarks/>
        DEU,

        /// <remarks/>
        DEV,

        /// <remarks/>
        DEW,

        /// <remarks/>
        DEX,

        /// <remarks/>
        DEY,

        /// <remarks/>
        DEZ,

        /// <remarks/>
        DF,

        /// <remarks/>
        DFA,

        /// <remarks/>
        DFB,

        /// <remarks/>
        DFC,

        /// <remarks/>
        DFD,

        /// <remarks/>
        DFE,

        /// <remarks/>
        DFF,

        /// <remarks/>
        DFG,

        /// <remarks/>
        DFH,

        /// <remarks/>
        DFI,
        DFJ,
        DFK,
        DFL,
        DFM,
        DFN,
        DFO,
        DFP,
        DFQ,
        DFR,
        DFS,
        DFT,
        DFU,
        DFV,
        DFW,
        DFX,
        DFY,
        DFZ,
        DG,
        DGA,
        DGB,
        DGC,
        DGD,
        DGE,
        DH,
        DI,
        DJ,
        DK,
        DL,
        DM,

        /// <remarks/>
        DN,

        /// <remarks/>
        DO,

        /// <remarks/>
        DP,

        /// <remarks/>
        DQ,

        /// <remarks/>
        DR,

        /// <remarks/>
        DS,

        /// <remarks/>
        DT,

        /// <remarks/>
        DU,

        /// <remarks/>
        DV,

        /// <remarks/>
        DW,

        /// <remarks/>
        DX,

        /// <remarks/>
        DY,

        /// <remarks/>
        DZ,

        /// <remarks/>
        EA,

        /// <remarks/>
        EB,

        /// <remarks/>
        EC,

        /// <remarks/>
        ED,

        /// <remarks/>
        EE,

        /// <remarks/>
        EF,

        /// <remarks/>
        EG,

        /// <remarks/>
        EH,

        /// <remarks/>
        EI,

        /// <remarks/>
        EJ,

        /// <remarks/>
        EK,

        /// <remarks/>
        EL,

        /// <remarks/>
        EM,

        /// <remarks/>
        EN,

        /// <remarks/>
        EO,
        EP,
        EQ,
        ER,
        ES,
        ET,
        EU,
        EV,
        EW,
        EX,
        EY,
        EZ,
        FA,
        FB,
        FC,
        FD,
        FE,
        FF,
        FG,
        FH,
        FI,
        FJ,

        /// <remarks/>
        FK,

        /// <remarks/>
        FL,

        /// <remarks/>
        FM,

        /// <remarks/>
        FN,

        /// <remarks/>
        FO,

        /// <remarks/>
        FP,

        /// <remarks/>
        FQ,

        /// <remarks/>
        FR,

        /// <remarks/>
        FS,

        /// <remarks/>
        FT,

        /// <remarks/>
        FU,

        /// <remarks/>
        FV,

        /// <remarks/>
        FW,

        /// <remarks/>
        FX,

        /// <remarks/>
        FY,

        /// <remarks/>
        FZ,

        /// <remarks/>
        GA,

        /// <remarks/>
        GB,

        /// <remarks/>
        GC,

        /// <remarks/>
        GD,

        /// <remarks/>
        GE,

        /// <remarks/>
        GF,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GJ,

        /// <remarks/>
        GK,

        /// <remarks/>
        GL,

        /// <remarks/>
        GM,

        /// <remarks/>
        GN,

        /// <remarks/>
        GO,

        /// <remarks/>
        GP,

        /// <remarks/>
        GQ,

        /// <remarks/>
        GR,

        /// <remarks/>
        GS,

        /// <remarks/>
        GT,

        /// <remarks/>
        GU,

        /// <remarks/>
        GV,

        /// <remarks/>
        GW,

        /// <remarks/>
        GX,

        /// <remarks/>
        GY,

        /// <remarks/>
        GZ,

        /// <remarks/>
        HA,
        HB,
        HC,
        HD,
        HE,
        HF,
        HG,
        HH,

        /// <remarks/>
        HI,

        /// <remarks/>
        HJ,

        /// <remarks/>
        HK,

        /// <remarks/>
        HL,
        HM,
        HN,
        HO,
        HP,
        HQ,
        HR,
        HS,
        HT,
        HU,
        HV,
        HW,
        HX,
        HY,
        HZ,
        I1,
        I2,
        IB,
        IC,
        ID,

        /// <remarks/>
        IE,

        /// <remarks/>
        IF,

        /// <remarks/>
        IG,

        /// <remarks/>
        IH,

        /// <remarks/>
        II,

        /// <remarks/>
        IJ,

        /// <remarks/>
        IL,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IO,

        /// <remarks/>
        IP,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IR,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        IU,

        /// <remarks/>
        IV,

        /// <remarks/>
        IW,

        /// <remarks/>
        IX,

        /// <remarks/>
        IY,

        /// <remarks/>
        IZ,

        /// <remarks/>
        JA,

        /// <remarks/>
        JB,

        /// <remarks/>
        JC,

        /// <remarks/>
        JD,
        JE,
        JF,
        JG,
        JH,
        LA,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LD,

        /// <remarks/>
        LE,

        /// <remarks/>
        LF,

        /// <remarks/>
        LG,

        /// <remarks/>
        LH,

        /// <remarks/>
        LI,

        /// <remarks/>
        LJ,

        /// <remarks/>
        LK,

        /// <remarks/>
        LL,

        /// <remarks/>
        LM,

        /// <remarks/>
        LN,

        /// <remarks/>
        LO,

        /// <remarks/>
        LP,

        /// <remarks/>
        LQ,

        /// <remarks/>
        LR,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        LV,

        /// <remarks/>
        MA,

        /// <remarks/>
        MAD,

        /// <remarks/>
        MDR,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MI,

        /// <remarks/>
        MOP,

        /// <remarks/>
        MP,

        /// <remarks/>
        MR,
        MS,
        MT,
        N2,
        NI,
        OA,
        OB,
        OC,
        OD,
        OE,
        OF,
        OG,
        OH,
        OI,
        OJ,
        OK,
        OL,
        OM,
        ON,
        OO,
        OP,

        /// <remarks/>
        OQ,

        /// <remarks/>
        OR,

        /// <remarks/>
        OS,

        /// <remarks/>
        OT,

        /// <remarks/>
        OU,

        /// <remarks/>
        OV,

        /// <remarks/>
        OW,

        /// <remarks/>
        OX,

        /// <remarks/>
        OY,
        OZ,
        P1,
        P2,
        P3,
        P4,
        PA,
        PB,
        PC,
        PD,
        PE,
        PF,
        PG,
        PH,
        PI,
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        POA,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,
        PW,
        PX,
        PY,
        PZ,
        RA,
        RB,
        RCA,
        RCR,
        RE,
        RF,
        RH,
        RI,
        RL,
        RM,
        RP,
        RS,
        RV,
        RW,
        SB,
        SE,
        SF,
        SG,
        SI,
        SN,
        SO,
        SPC,
        SR,
        SS,
        ST,
        SU,
        SX,
        SY,
        SZ,
        TA,
        TB,
        TC,
        TCP,
        TCR,
        TD,
        TE,
        TF,
        TG,

        /// <remarks/>
        TH,

        /// <remarks/>
        TI,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TK,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TP,

        /// <remarks/>
        TQ,

        /// <remarks/>
        TR,

        /// <remarks/>
        TS,

        /// <remarks/>
        TT,

        /// <remarks/>
        TU,
        TV,
        TW,
        TX,
        TY,
        TZ,
        UA,
        UB,
        UC,
        UD,

        /// <remarks/>
        UE,

        /// <remarks/>
        UF,

        /// <remarks/>
        UG,

        /// <remarks/>
        UH,

        /// <remarks/>
        UHP,

        /// <remarks/>
        UI,

        /// <remarks/>
        UJ,

        /// <remarks/>
        UK,

        /// <remarks/>
        UL,

        /// <remarks/>
        UM,

        /// <remarks/>
        UN,

        /// <remarks/>
        UO,

        /// <remarks/>
        UP,

        /// <remarks/>
        UQ,

        /// <remarks/>
        UR,

        /// <remarks/>
        US,

        /// <remarks/>
        UT,

        /// <remarks/>
        UU,

        /// <remarks/>
        UV,

        /// <remarks/>
        UW,

        /// <remarks/>
        UX,

        /// <remarks/>
        UY,

        /// <remarks/>
        UZ,

        /// <remarks/>
        VA,

        /// <remarks/>
        VB,

        /// <remarks/>
        VC,

        /// <remarks/>
        VE,

        /// <remarks/>
        VF,

        /// <remarks/>
        VG,

        /// <remarks/>
        VH,

        /// <remarks/>
        VI,

        /// <remarks/>
        VJ,

        /// <remarks/>
        VK,

        /// <remarks/>
        VL,

        /// <remarks/>
        VM,

        /// <remarks/>
        VN,

        /// <remarks/>
        VO,

        /// <remarks/>
        VP,

        /// <remarks/>
        VQ,

        /// <remarks/>
        VR,

        /// <remarks/>
        VS,

        /// <remarks/>
        VT,

        /// <remarks/>
        VU,

        /// <remarks/>
        VV,

        /// <remarks/>
        VW,

        /// <remarks/>
        VX,

        /// <remarks/>
        VY,

        /// <remarks/>
        VZ,

        /// <remarks/>
        WA,

        /// <remarks/>
        WB,

        /// <remarks/>
        WC,

        /// <remarks/>
        WD,

        /// <remarks/>
        WE,

        /// <remarks/>
        WF,

        /// <remarks/>
        WG,

        /// <remarks/>
        WH,

        /// <remarks/>
        WI,
        WJ,
        WK,
        WL,
        WM,
        WN,
        WO,
        WP,
        WPA,
        WQ,
        WR,
        WS,
        WT,
        WU,
        WV,
        WW,
        WX,
        WY,
        WZ,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:ContactFunctionCode:D16A")]
    public enum ContactFunctionCodeContentType
    {
        AA,
        AB,
        AC,
        AD,
        AE,
        AF,
        AG,
        AH,
        AI,
        AJ,
        AK,
        AL,
        AM,
        AN,
        AO,
        AP,
        AQ,
        AR,
        AS,

        /// <remarks/>
        AT,

        /// <remarks/>
        AU,

        /// <remarks/>
        AV,

        /// <remarks/>
        AW,

        /// <remarks/>
        AX,

        /// <remarks/>
        AY,

        /// <remarks/>
        AZ,

        /// <remarks/>
        BA,
        BB,
        BC,
        BD,
        BE,
        BF,
        BG,
        BH,

        /// <remarks/>
        BI,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BK,

        /// <remarks/>
        BL,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BP,

        /// <remarks/>
        BQ,

        /// <remarks/>
        BR,

        /// <remarks/>
        BU,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,
        CE,
        CF,
        CG,
        CN,
        CO,
        CP,
        CR,

        /// <remarks/>
        CW,

        /// <remarks/>
        DE,

        /// <remarks/>
        DI,

        /// <remarks/>
        DL,
        EB,
        EC,

        /// <remarks/>
        ED,
        EX,
        GR,
        HE,
        HG,
        HM,
        IC,
        IN,
        LB,
        LO,
        MC,
        MD,
        MH,
        MR,
        MS,
        NT,
        OC,
        PA,
        PD,
        PE,
        PM,
        QA,
        QC,
        RD,
        RP,
        SA,
        SC,
        SD,
        SR,
        SU,
        TA,
        TD,
        TI,
        TR,
        WH,
        WI,
        WJ,
        WK,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:CommunicationMeansTypeCode:D16A")]
    public enum CommunicationMeansTypeCodeContentType
    {
        AA,
        AB,
        AC,
        AD,
        AE,
        AF,
        AG,
        AH,
        AI,
        AJ,
        AK,
        AL,
        AM,
        AN,
        AO,
        AP,
        AQ,
        AR,
        AS,
        AT,
        AU,
        AV,
        AW,
        CA,
        EI,
        EM,
        EX,
        FT,
        FX,
        GM,
        IE,
        IM,
        MA,
        PB,
        PS,
        SW,
        TE,
        TG,
        TL,
        TM,
        TT,
        TX,
        XF,
        XG,
        XH,
        XI,
        XJ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DocumentStatusCode:D16A")]
    public enum DocumentStatusCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("35")]
        Item35,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DocumentNameCode:D16A")]
    public enum DocumentNameCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,

        /// <remarks/>
        [XmlEnum("17")]
        Item17,

        /// <remarks/>
        [XmlEnum("18")]
        Item18,

        /// <remarks/>
        [XmlEnum("19")]
        Item19,

        /// <remarks/>
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,

        /// <remarks/>
        [XmlEnum("26")]
        Item26,

        /// <remarks/>
        [XmlEnum("27")]
        Item27,

        /// <remarks/>
        [XmlEnum("28")]
        Item28,

        /// <remarks/>
        [XmlEnum("29")]
        Item29,

        /// <remarks/>
        [XmlEnum("30")]
        Item30,

        /// <remarks/>
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,

        /// <remarks/>
        [XmlEnum("34")]
        Item34,

        /// <remarks/>
        [XmlEnum("35")]
        Item35,

        /// <remarks/>
        [XmlEnum("36")]
        Item36,

        /// <remarks/>
        [XmlEnum("37")]
        Item37,

        /// <remarks/>
        [XmlEnum("38")]
        Item38,

        /// <remarks/>
        [XmlEnum("39")]
        Item39,

        /// <remarks/>
        [XmlEnum("40")]
        Item40,

        /// <remarks/>
        [XmlEnum("41")]
        Item41,

        /// <remarks/>
        [XmlEnum("42")]
        Item42,

        /// <remarks/>
        [XmlEnum("43")]
        Item43,

        /// <remarks/>
        [XmlEnum("44")]
        Item44,

        /// <remarks/>
        [XmlEnum("45")]
        Item45,

        /// <remarks/>
        [XmlEnum("46")]
        Item46,

        /// <remarks/>
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("49")]
        Item49,

        /// <remarks/>
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,

        /// <remarks/>
        [XmlEnum("53")]
        Item53,

        /// <remarks/>
        [XmlEnum("54")]
        Item54,

        /// <remarks/>
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("58")]
        Item58,

        /// <remarks/>
        [XmlEnum("59")]
        Item59,

        /// <remarks/>
        [XmlEnum("60")]
        Item60,

        /// <remarks/>
        [XmlEnum("61")]
        Item61,

        /// <remarks/>
        [XmlEnum("62")]
        Item62,

        /// <remarks/>
        [XmlEnum("63")]
        Item63,

        /// <remarks/>
        [XmlEnum("64")]
        Item64,

        /// <remarks/>
        [XmlEnum("65")]
        Item65,

        /// <remarks/>
        [XmlEnum("66")]
        Item66,

        /// <remarks/>
        [XmlEnum("67")]
        Item67,

        /// <remarks/>
        [XmlEnum("68")]
        Item68,

        /// <remarks/>
        [XmlEnum("69")]
        Item69,

        /// <remarks/>
        [XmlEnum("70")]
        Item70,

        /// <remarks/>
        [XmlEnum("71")]
        Item71,

        /// <remarks/>
        [XmlEnum("72")]
        Item72,

        /// <remarks/>
        [XmlEnum("73")]
        Item73,

        /// <remarks/>
        [XmlEnum("74")]
        Item74,

        /// <remarks/>
        [XmlEnum("75")]
        Item75,

        /// <remarks/>
        [XmlEnum("76")]
        Item76,

        /// <remarks/>
        [XmlEnum("77")]
        Item77,

        /// <remarks/>
        [XmlEnum("78")]
        Item78,

        /// <remarks/>
        [XmlEnum("79")]
        Item79,

        /// <remarks/>
        [XmlEnum("80")]
        Item80,

        /// <remarks/>
        [XmlEnum("81")]
        Item81,

        /// <remarks/>
        [XmlEnum("82")]
        Item82,

        /// <remarks/>
        [XmlEnum("83")]
        Item83,

        /// <remarks/>
        [XmlEnum("84")]
        Item84,

        /// <remarks/>
        [XmlEnum("85")]
        Item85,

        /// <remarks/>
        [XmlEnum("86")]
        Item86,

        /// <remarks/>
        [XmlEnum("87")]
        Item87,
        [XmlEnum("88")]
        Item88,
        [XmlEnum("89")]
        Item89,
        [XmlEnum("90")]
        Item90,
        [XmlEnum("91")]
        Item91,
        [XmlEnum("92")]
        Item92,
        [XmlEnum("93")]
        Item93,
        [XmlEnum("94")]
        Item94,
        [XmlEnum("95")]
        Item95,
        [XmlEnum("96")]
        Item96,
        [XmlEnum("97")]
        Item97,
        [XmlEnum("98")]
        Item98,
        [XmlEnum("99")]
        Item99,
        [XmlEnum("100")]
        Item100,
        [XmlEnum("101")]
        Item101,

        /// <remarks/>
        [XmlEnum("102")]
        Item102,

        /// <remarks/>
        [XmlEnum("103")]
        Item103,

        /// <remarks/>
        [XmlEnum("104")]
        Item104,

        /// <remarks/>
        [XmlEnum("105")]
        Item105,

        /// <remarks/>
        [XmlEnum("106")]
        Item106,

        /// <remarks/>
        [XmlEnum("107")]
        Item107,

        /// <remarks/>
        [XmlEnum("108")]
        Item108,

        /// <remarks/>
        [XmlEnum("109")]
        Item109,

        /// <remarks/>
        [XmlEnum("110")]
        Item110,

        /// <remarks/>
        [XmlEnum("111")]
        Item111,

        /// <remarks/>
        [XmlEnum("112")]
        Item112,
        [XmlEnum("113")]
        Item113,
        [XmlEnum("114")]
        Item114,
        [XmlEnum("115")]
        Item115,
        [XmlEnum("116")]
        Item116,
        [XmlEnum("117")]
        Item117,

        /// <remarks/>
        [XmlEnum("118")]
        Item118,

        /// <remarks/>
        [XmlEnum("119")]
        Item119,

        /// <remarks/>
        [XmlEnum("120")]
        Item120,

        /// <remarks/>
        [XmlEnum("121")]
        Item121,

        /// <remarks/>
        [XmlEnum("122")]
        Item122,

        /// <remarks/>
        [XmlEnum("123")]
        Item123,

        /// <remarks/>
        [XmlEnum("124")]
        Item124,

        /// <remarks/>
        [XmlEnum("125")]
        Item125,

        /// <remarks/>
        [XmlEnum("126")]
        Item126,

        /// <remarks/>
        [XmlEnum("127")]
        Item127,

        /// <remarks/>
        [XmlEnum("128")]
        Item128,

        /// <remarks/>
        [XmlEnum("129")]
        Item129,

        /// <remarks/>
        [XmlEnum("130")]
        Item130,

        /// <remarks/>
        [XmlEnum("131")]
        Item131,

        /// <remarks/>
        [XmlEnum("132")]
        Item132,

        /// <remarks/>
        [XmlEnum("133")]
        Item133,

        /// <remarks/>
        [XmlEnum("134")]
        Item134,

        /// <remarks/>
        [XmlEnum("135")]
        Item135,

        /// <remarks/>
        [XmlEnum("136")]
        Item136,

        /// <remarks/>
        [XmlEnum("137")]
        Item137,

        /// <remarks/>
        [XmlEnum("138")]
        Item138,

        /// <remarks/>
        [XmlEnum("139")]
        Item139,

        /// <remarks/>
        [XmlEnum("140")]
        Item140,

        /// <remarks/>
        [XmlEnum("141")]
        Item141,

        /// <remarks/>
        [XmlEnum("142")]
        Item142,

        /// <remarks/>
        [XmlEnum("143")]
        Item143,

        /// <remarks/>
        [XmlEnum("144")]
        Item144,

        /// <remarks/>
        [XmlEnum("145")]
        Item145,

        /// <remarks/>
        [XmlEnum("146")]
        Item146,

        /// <remarks/>
        [XmlEnum("147")]
        Item147,

        /// <remarks/>
        [XmlEnum("148")]
        Item148,

        /// <remarks/>
        [XmlEnum("149")]
        Item149,

        /// <remarks/>
        [XmlEnum("150")]
        Item150,

        /// <remarks/>
        [XmlEnum("151")]
        Item151,

        /// <remarks/>
        [XmlEnum("152")]
        Item152,

        /// <remarks/>
        [XmlEnum("153")]
        Item153,

        /// <remarks/>
        [XmlEnum("154")]
        Item154,

        /// <remarks/>
        [XmlEnum("155")]
        Item155,

        /// <remarks/>
        [XmlEnum("156")]
        Item156,

        /// <remarks/>
        [XmlEnum("157")]
        Item157,

        /// <remarks/>
        [XmlEnum("158")]
        Item158,

        /// <remarks/>
        [XmlEnum("159")]
        Item159,

        /// <remarks/>
        [XmlEnum("160")]
        Item160,

        /// <remarks/>
        [XmlEnum("161")]
        Item161,

        /// <remarks/>
        [XmlEnum("162")]
        Item162,

        /// <remarks/>
        [XmlEnum("163")]
        Item163,

        /// <remarks/>
        [XmlEnum("164")]
        Item164,

        /// <remarks/>
        [XmlEnum("165")]
        Item165,

        /// <remarks/>
        [XmlEnum("166")]
        Item166,

        /// <remarks/>
        [XmlEnum("167")]
        Item167,

        /// <remarks/>
        [XmlEnum("168")]
        Item168,

        /// <remarks/>
        [XmlEnum("169")]
        Item169,

        /// <remarks/>
        [XmlEnum("170")]
        Item170,

        /// <remarks/>
        [XmlEnum("171")]
        Item171,

        /// <remarks/>
        [XmlEnum("172")]
        Item172,

        /// <remarks/>
        [XmlEnum("173")]
        Item173,

        /// <remarks/>
        [XmlEnum("174")]
        Item174,

        /// <remarks/>
        [XmlEnum("175")]
        Item175,

        /// <remarks/>
        [XmlEnum("176")]
        Item176,

        /// <remarks/>
        [XmlEnum("177")]
        Item177,

        /// <remarks/>
        [XmlEnum("178")]
        Item178,

        /// <remarks/>
        [XmlEnum("179")]
        Item179,

        /// <remarks/>
        [XmlEnum("180")]
        Item180,

        /// <remarks/>
        [XmlEnum("181")]
        Item181,

        /// <remarks/>
        [XmlEnum("182")]
        Item182,

        /// <remarks/>
        [XmlEnum("183")]
        Item183,

        /// <remarks/>
        [XmlEnum("184")]
        Item184,
        [XmlEnum("185")]
        Item185,
        [XmlEnum("186")]
        Item186,
        [XmlEnum("187")]
        Item187,
        [XmlEnum("188")]
        Item188,
        [XmlEnum("189")]
        Item189,

        /// <remarks/>
        [XmlEnum("190")]
        Item190,

        /// <remarks/>
        [XmlEnum("191")]
        Item191,

        /// <remarks/>
        [XmlEnum("192")]
        Item192,

        /// <remarks/>
        [XmlEnum("193")]
        Item193,

        /// <remarks/>
        [XmlEnum("194")]
        Item194,

        /// <remarks/>
        [XmlEnum("195")]
        Item195,

        /// <remarks/>
        [XmlEnum("196")]
        Item196,

        /// <remarks/>
        [XmlEnum("197")]
        Item197,

        /// <remarks/>
        [XmlEnum("198")]
        Item198,

        /// <remarks/>
        [XmlEnum("199")]
        Item199,

        /// <remarks/>
        [XmlEnum("200")]
        Item200,

        /// <remarks/>
        [XmlEnum("201")]
        Item201,

        /// <remarks/>
        [XmlEnum("202")]
        Item202,

        /// <remarks/>
        [XmlEnum("203")]
        Item203,

        /// <remarks/>
        [XmlEnum("204")]
        Item204,

        /// <remarks/>
        [XmlEnum("205")]
        Item205,

        /// <remarks/>
        [XmlEnum("206")]
        Item206,

        /// <remarks/>
        [XmlEnum("207")]
        Item207,

        /// <remarks/>
        [XmlEnum("208")]
        Item208,

        /// <remarks/>
        [XmlEnum("209")]
        Item209,

        /// <remarks/>
        [XmlEnum("210")]
        Item210,

        /// <remarks/>
        [XmlEnum("211")]
        Item211,

        /// <remarks/>
        [XmlEnum("212")]
        Item212,

        /// <remarks/>
        [XmlEnum("213")]
        Item213,

        /// <remarks/>
        [XmlEnum("214")]
        Item214,

        /// <remarks/>
        [XmlEnum("215")]
        Item215,

        /// <remarks/>
        [XmlEnum("216")]
        Item216,

        /// <remarks/>
        [XmlEnum("217")]
        Item217,

        /// <remarks/>
        [XmlEnum("218")]
        Item218,

        /// <remarks/>
        [XmlEnum("219")]
        Item219,

        /// <remarks/>
        [XmlEnum("220")]
        Item220,

        /// <remarks/>
        [XmlEnum("221")]
        Item221,

        /// <remarks/>
        [XmlEnum("222")]
        Item222,

        /// <remarks/>
        [XmlEnum("223")]
        Item223,

        /// <remarks/>
        [XmlEnum("224")]
        Item224,

        /// <remarks/>
        [XmlEnum("225")]
        Item225,

        /// <remarks/>
        [XmlEnum("226")]
        Item226,

        /// <remarks/>
        [XmlEnum("227")]
        Item227,

        /// <remarks/>
        [XmlEnum("228")]
        Item228,

        /// <remarks/>
        [XmlEnum("229")]
        Item229,

        /// <remarks/>
        [XmlEnum("230")]
        Item230,

        /// <remarks/>
        [XmlEnum("231")]
        Item231,

        /// <remarks/>
        [XmlEnum("232")]
        Item232,

        /// <remarks/>
        [XmlEnum("233")]
        Item233,

        /// <remarks/>
        [XmlEnum("234")]
        Item234,

        /// <remarks/>
        [XmlEnum("235")]
        Item235,

        /// <remarks/>
        [XmlEnum("236")]
        Item236,

        /// <remarks/>
        [XmlEnum("237")]
        Item237,

        /// <remarks/>
        [XmlEnum("238")]
        Item238,

        /// <remarks/>
        [XmlEnum("239")]
        Item239,

        /// <remarks/>
        [XmlEnum("240")]
        Item240,

        /// <remarks/>
        [XmlEnum("241")]
        Item241,

        /// <remarks/>
        [XmlEnum("242")]
        Item242,

        /// <remarks/>
        [XmlEnum("243")]
        Item243,

        /// <remarks/>
        [XmlEnum("244")]
        Item244,

        /// <remarks/>
        [XmlEnum("245")]
        Item245,

        /// <remarks/>
        [XmlEnum("246")]
        Item246,

        /// <remarks/>
        [XmlEnum("247")]
        Item247,

        /// <remarks/>
        [XmlEnum("248")]
        Item248,

        /// <remarks/>
        [XmlEnum("249")]
        Item249,

        /// <remarks/>
        [XmlEnum("250")]
        Item250,

        /// <remarks/>
        [XmlEnum("251")]
        Item251,

        /// <remarks/>
        [XmlEnum("252")]
        Item252,

        /// <remarks/>
        [XmlEnum("253")]
        Item253,

        /// <remarks/>
        [XmlEnum("254")]
        Item254,

        /// <remarks/>
        [XmlEnum("255")]
        Item255,

        /// <remarks/>
        [XmlEnum("256")]
        Item256,

        /// <remarks/>
        [XmlEnum("257")]
        Item257,

        /// <remarks/>
        [XmlEnum("258")]
        Item258,

        /// <remarks/>
        [XmlEnum("259")]
        Item259,

        /// <remarks/>
        [XmlEnum("260")]
        Item260,

        /// <remarks/>
        [XmlEnum("261")]
        Item261,

        /// <remarks/>
        [XmlEnum("262")]
        Item262,

        /// <remarks/>
        [XmlEnum("263")]
        Item263,

        /// <remarks/>
        [XmlEnum("264")]
        Item264,

        /// <remarks/>
        [XmlEnum("265")]
        Item265,

        /// <remarks/>
        [XmlEnum("266")]
        Item266,

        /// <remarks/>
        [XmlEnum("267")]
        Item267,

        /// <remarks/>
        [XmlEnum("268")]
        Item268,

        /// <remarks/>
        [XmlEnum("269")]
        Item269,

        /// <remarks/>
        [XmlEnum("270")]
        Item270,

        /// <remarks/>
        [XmlEnum("271")]
        Item271,

        /// <remarks/>
        [XmlEnum("272")]
        Item272,

        /// <remarks/>
        [XmlEnum("273")]
        Item273,

        /// <remarks/>
        [XmlEnum("274")]
        Item274,

        /// <remarks/>
        [XmlEnum("275")]
        Item275,

        /// <remarks/>
        [XmlEnum("276")]
        Item276,

        /// <remarks/>
        [XmlEnum("277")]
        Item277,

        /// <remarks/>
        [XmlEnum("278")]
        Item278,

        /// <remarks/>
        [XmlEnum("279")]
        Item279,

        /// <remarks/>
        [XmlEnum("280")]
        Item280,

        /// <remarks/>
        [XmlEnum("281")]
        Item281,

        /// <remarks/>
        [XmlEnum("282")]
        Item282,

        /// <remarks/>
        [XmlEnum("283")]
        Item283,

        /// <remarks/>
        [XmlEnum("284")]
        Item284,

        /// <remarks/>
        [XmlEnum("285")]
        Item285,

        /// <remarks/>
        [XmlEnum("286")]
        Item286,

        /// <remarks/>
        [XmlEnum("287")]
        Item287,

        /// <remarks/>
        [XmlEnum("288")]
        Item288,

        /// <remarks/>
        [XmlEnum("289")]
        Item289,

        /// <remarks/>
        [XmlEnum("290")]
        Item290,

        /// <remarks/>
        [XmlEnum("291")]
        Item291,

        /// <remarks/>
        [XmlEnum("292")]
        Item292,

        /// <remarks/>
        [XmlEnum("293")]
        Item293,

        /// <remarks/>
        [XmlEnum("294")]
        Item294,

        /// <remarks/>
        [XmlEnum("295")]
        Item295,

        /// <remarks/>
        [XmlEnum("296")]
        Item296,

        /// <remarks/>
        [XmlEnum("297")]
        Item297,

        /// <remarks/>
        [XmlEnum("298")]
        Item298,

        /// <remarks/>
        [XmlEnum("299")]
        Item299,

        /// <remarks/>
        [XmlEnum("300")]
        Item300,

        /// <remarks/>
        [XmlEnum("301")]
        Item301,

        /// <remarks/>
        [XmlEnum("302")]
        Item302,

        /// <remarks/>
        [XmlEnum("303")]
        Item303,

        /// <remarks/>
        [XmlEnum("304")]
        Item304,

        /// <remarks/>
        [XmlEnum("305")]
        Item305,

        /// <remarks/>
        [XmlEnum("306")]
        Item306,

        /// <remarks/>
        [XmlEnum("307")]
        Item307,

        /// <remarks/>
        [XmlEnum("308")]
        Item308,
        [XmlEnum("309")]
        Item309,

        [XmlEnum("310")]
        Item310,

        [XmlEnum("311")]
        Item311,
        [XmlEnum("312")]
        Item312,
        [XmlEnum("313")]
        Item313,
        [XmlEnum("314")]
        Item314,
        [XmlEnum("315")]
        Item315,
        [XmlEnum("316")]
        Item316,
        [XmlEnum("317")]
        Item317,

        /// <remarks/>
        [XmlEnum("318")]
        Item318,

        /// <remarks/>
        [XmlEnum("319")]
        Item319,

        /// <remarks/>
        [XmlEnum("320")]
        Item320,

        /// <remarks/>
        [XmlEnum("321")]
        Item321,

        /// <remarks/>
        [XmlEnum("322")]
        Item322,

        /// <remarks/>
        [XmlEnum("323")]
        Item323,

        /// <remarks/>
        [XmlEnum("324")]
        Item324,

        /// <remarks/>
        [XmlEnum("325")]
        Item325,

        /// <remarks/>
        [XmlEnum("326")]
        Item326,

        /// <remarks/>
        [XmlEnum("327")]
        Item327,

        /// <remarks/>
        [XmlEnum("328")]
        Item328,

        /// <remarks/>
        [XmlEnum("329")]
        Item329,

        /// <remarks/>
        [XmlEnum("330")]
        Item330,

        /// <remarks/>
        [XmlEnum("331")]
        Item331,

        /// <remarks/>
        [XmlEnum("332")]
        Item332,

        /// <remarks/>
        [XmlEnum("333")]
        Item333,

        /// <remarks/>
        [XmlEnum("334")]
        Item334,

        /// <remarks/>
        [XmlEnum("335")]
        Item335,

        /// <remarks/>
        [XmlEnum("336")]
        Item336,

        /// <remarks/>
        [XmlEnum("337")]
        Item337,

        /// <remarks/>
        [XmlEnum("338")]
        Item338,

        /// <remarks/>
        [XmlEnum("339")]
        Item339,

        /// <remarks/>
        [XmlEnum("340")]
        Item340,

        /// <remarks/>
        [XmlEnum("341")]
        Item341,

        /// <remarks/>
        [XmlEnum("342")]
        Item342,

        /// <remarks/>
        [XmlEnum("343")]
        Item343,

        /// <remarks/>
        [XmlEnum("344")]
        Item344,

        /// <remarks/>
        [XmlEnum("345")]
        Item345,

        /// <remarks/>
        [XmlEnum("346")]
        Item346,

        /// <remarks/>
        [XmlEnum("347")]
        Item347,

        /// <remarks/>
        [XmlEnum("348")]
        Item348,

        /// <remarks/>
        [XmlEnum("349")]
        Item349,

        /// <remarks/>
        [XmlEnum("350")]
        Item350,

        /// <remarks/>
        [XmlEnum("351")]
        Item351,

        /// <remarks/>
        [XmlEnum("352")]
        Item352,

        /// <remarks/>
        [XmlEnum("353")]
        Item353,

        /// <remarks/>
        [XmlEnum("354")]
        Item354,

        /// <remarks/>
        [XmlEnum("355")]
        Item355,

        /// <remarks/>
        [XmlEnum("356")]
        Item356,

        /// <remarks/>
        [XmlEnum("357")]
        Item357,

        /// <remarks/>
        [XmlEnum("358")]
        Item358,

        /// <remarks/>
        [XmlEnum("359")]
        Item359,

        /// <remarks/>
        [XmlEnum("360")]
        Item360,

        /// <remarks/>
        [XmlEnum("361")]
        Item361,

        /// <remarks/>
        [XmlEnum("362")]
        Item362,

        /// <remarks/>
        [XmlEnum("363")]
        Item363,

        /// <remarks/>
        [XmlEnum("364")]
        Item364,

        /// <remarks/>
        [XmlEnum("365")]
        Item365,

        /// <remarks/>
        [XmlEnum("366")]
        Item366,

        /// <remarks/>
        [XmlEnum("367")]
        Item367,

        /// <remarks/>
        [XmlEnum("368")]
        Item368,

        /// <remarks/>
        [XmlEnum("369")]
        Item369,

        /// <remarks/>
        [XmlEnum("370")]
        Item370,

        /// <remarks/>
        [XmlEnum("371")]
        Item371,

        /// <remarks/>
        [XmlEnum("372")]
        Item372,

        /// <remarks/>
        [XmlEnum("373")]
        Item373,

        /// <remarks/>
        [XmlEnum("374")]
        Item374,

        /// <remarks/>
        [XmlEnum("375")]
        Item375,

        /// <remarks/>
        [XmlEnum("376")]
        Item376,

        /// <remarks/>
        [XmlEnum("377")]
        Item377,

        /// <remarks/>
        [XmlEnum("378")]
        Item378,

        /// <remarks/>
        [XmlEnum("379")]
        Item379,

        /// <remarks/>
        [XmlEnum("380")]
        Item380,

        /// <remarks/>
        [XmlEnum("381")]
        Item381,

        /// <remarks/>
        [XmlEnum("382")]
        Item382,

        /// <remarks/>
        [XmlEnum("383")]
        Item383,

        /// <remarks/>
        [XmlEnum("384")]
        Item384,

        /// <remarks/>
        [XmlEnum("385")]
        Item385,

        /// <remarks/>
        [XmlEnum("386")]
        Item386,

        /// <remarks/>
        [XmlEnum("387")]
        Item387,

        /// <remarks/>
        [XmlEnum("388")]
        Item388,

        /// <remarks/>
        [XmlEnum("389")]
        Item389,

        /// <remarks/>
        [XmlEnum("390")]
        Item390,

        /// <remarks/>
        [XmlEnum("391")]
        Item391,

        /// <remarks/>
        [XmlEnum("392")]
        Item392,
        [XmlEnum("393")]
        Item393,
        [XmlEnum("394")]
        Item394,
        [XmlEnum("395")]
        Item395,
        [XmlEnum("396")]
        Item396,
        [XmlEnum("397")]
        Item397,
        [XmlEnum("398")]
        Item398,

        /// <remarks/>
        [XmlEnum("399")]
        Item399,

        /// <remarks/>
        [XmlEnum("400")]
        Item400,

        /// <remarks/>
        [XmlEnum("401")]
        Item401,

        /// <remarks/>
        [XmlEnum("402")]
        Item402,

        /// <remarks/>
        [XmlEnum("403")]
        Item403,

        /// <remarks/>
        [XmlEnum("404")]
        Item404,

        /// <remarks/>
        [XmlEnum("405")]
        Item405,

        /// <remarks/>
        [XmlEnum("406")]
        Item406,

        /// <remarks/>
        [XmlEnum("407")]
        Item407,

        /// <remarks/>
        [XmlEnum("408")]
        Item408,

        /// <remarks/>
        [XmlEnum("409")]
        Item409,

        /// <remarks/>
        [XmlEnum("410")]
        Item410,

        /// <remarks/>
        [XmlEnum("411")]
        Item411,

        /// <remarks/>
        [XmlEnum("412")]
        Item412,

        /// <remarks/>
        [XmlEnum("413")]
        Item413,

        /// <remarks/>
        [XmlEnum("414")]
        Item414,

        /// <remarks/>
        [XmlEnum("415")]
        Item415,

        /// <remarks/>
        [XmlEnum("416")]
        Item416,

        /// <remarks/>
        [XmlEnum("417")]
        Item417,

        /// <remarks/>
        [XmlEnum("418")]
        Item418,

        /// <remarks/>
        [XmlEnum("419")]
        Item419,
        [XmlEnum("420")]
        Item420,
        [XmlEnum("421")]
        Item421,
        [XmlEnum("422")]
        Item422,
        [XmlEnum("423")]
        Item423,
        [XmlEnum("424")]
        Item424,
        [XmlEnum("425")]
        Item425,

        /// <remarks/>
        [XmlEnum("426")]
        Item426,

        /// <remarks/>
        [XmlEnum("427")]
        Item427,

        /// <remarks/>
        [XmlEnum("428")]
        Item428,

        /// <remarks/>
        [XmlEnum("429")]
        Item429,

        /// <remarks/>
        [XmlEnum("430")]
        Item430,

        /// <remarks/>
        [XmlEnum("431")]
        Item431,

        /// <remarks/>
        [XmlEnum("432")]
        Item432,

        /// <remarks/>
        [XmlEnum("433")]
        Item433,

        /// <remarks/>
        [XmlEnum("434")]
        Item434,

        /// <remarks/>
        [XmlEnum("435")]
        Item435,

        /// <remarks/>
        [XmlEnum("436")]
        Item436,

        /// <remarks/>
        [XmlEnum("437")]
        Item437,

        /// <remarks/>
        [XmlEnum("438")]
        Item438,

        /// <remarks/>
        [XmlEnum("439")]
        Item439,

        /// <remarks/>
        [XmlEnum("440")]
        Item440,

        /// <remarks/>
        [XmlEnum("441")]
        Item441,

        /// <remarks/>
        [XmlEnum("442")]
        Item442,

        /// <remarks/>
        [XmlEnum("443")]
        Item443,

        /// <remarks/>
        [XmlEnum("444")]
        Item444,

        /// <remarks/>
        [XmlEnum("445")]
        Item445,

        /// <remarks/>
        [XmlEnum("446")]
        Item446,

        /// <remarks/>
        [XmlEnum("447")]
        Item447,

        /// <remarks/>
        [XmlEnum("448")]
        Item448,

        /// <remarks/>
        [XmlEnum("449")]
        Item449,

        /// <remarks/>
        [XmlEnum("450")]
        Item450,

        /// <remarks/>
        [XmlEnum("451")]
        Item451,

        /// <remarks/>
        [XmlEnum("452")]
        Item452,

        /// <remarks/>
        [XmlEnum("453")]
        Item453,

        /// <remarks/>
        [XmlEnum("454")]
        Item454,

        /// <remarks/>
        [XmlEnum("455")]
        Item455,

        /// <remarks/>
        [XmlEnum("456")]
        Item456,

        /// <remarks/>
        [XmlEnum("457")]
        Item457,

        /// <remarks/>
        [XmlEnum("458")]
        Item458,

        /// <remarks/>
        [XmlEnum("459")]
        Item459,

        /// <remarks/>
        [XmlEnum("460")]
        Item460,

        /// <remarks/>
        [XmlEnum("461")]
        Item461,

        /// <remarks/>
        [XmlEnum("462")]
        Item462,

        /// <remarks/>
        [XmlEnum("463")]
        Item463,

        /// <remarks/>
        [XmlEnum("464")]
        Item464,

        /// <remarks/>
        [XmlEnum("465")]
        Item465,

        /// <remarks/>
        [XmlEnum("466")]
        Item466,

        /// <remarks/>
        [XmlEnum("467")]
        Item467,

        /// <remarks/>
        [XmlEnum("468")]
        Item468,

        /// <remarks/>
        [XmlEnum("469")]
        Item469,

        /// <remarks/>
        [XmlEnum("470")]
        Item470,

        /// <remarks/>
        [XmlEnum("481")]
        Item481,

        /// <remarks/>
        [XmlEnum("482")]
        Item482,

        /// <remarks/>
        [XmlEnum("483")]
        Item483,

        /// <remarks/>
        [XmlEnum("484")]
        Item484,

        /// <remarks/>
        [XmlEnum("485")]
        Item485,

        /// <remarks/>
        [XmlEnum("486")]
        Item486,

        /// <remarks/>
        [XmlEnum("487")]
        Item487,

        /// <remarks/>
        [XmlEnum("488")]
        Item488,

        /// <remarks/>
        [XmlEnum("489")]
        Item489,

        /// <remarks/>
        [XmlEnum("490")]
        Item490,

        /// <remarks/>
        [XmlEnum("491")]
        Item491,

        /// <remarks/>
        [XmlEnum("493")]
        Item493,

        /// <remarks/>
        [XmlEnum("494")]
        Item494,

        /// <remarks/>
        [XmlEnum("495")]
        Item495,

        /// <remarks/>
        [XmlEnum("496")]
        Item496,

        /// <remarks/>
        [XmlEnum("497")]
        Item497,

        /// <remarks/>
        [XmlEnum("498")]
        Item498,

        /// <remarks/>
        [XmlEnum("499")]
        Item499,

        /// <remarks/>
        [XmlEnum("520")]
        Item520,

        /// <remarks/>
        [XmlEnum("521")]
        Item521,

        /// <remarks/>
        [XmlEnum("522")]
        Item522,

        /// <remarks/>
        [XmlEnum("523")]
        Item523,

        /// <remarks/>
        [XmlEnum("524")]
        Item524,

        /// <remarks/>
        [XmlEnum("525")]
        Item525,

        /// <remarks/>
        [XmlEnum("526")]
        Item526,

        /// <remarks/>
        [XmlEnum("527")]
        Item527,

        /// <remarks/>
        [XmlEnum("528")]
        Item528,

        /// <remarks/>
        [XmlEnum("529")]
        Item529,

        /// <remarks/>
        [XmlEnum("530")]
        Item530,

        /// <remarks/>
        [XmlEnum("531")]
        Item531,

        /// <remarks/>
        [XmlEnum("532")]
        Item532,

        /// <remarks/>
        [XmlEnum("533")]
        Item533,

        /// <remarks/>
        [XmlEnum("534")]
        Item534,

        /// <remarks/>
        [XmlEnum("535")]
        Item535,

        /// <remarks/>
        [XmlEnum("536")]
        Item536,

        /// <remarks/>
        [XmlEnum("537")]
        Item537,

        /// <remarks/>
        [XmlEnum("538")]
        Item538,

        /// <remarks/>
        [XmlEnum("539")]
        Item539,

        /// <remarks/>
        [XmlEnum("550")]
        Item550,

        /// <remarks/>
        [XmlEnum("551")]
        Item551,

        /// <remarks/>
        [XmlEnum("552")]
        Item552,

        /// <remarks/>
        [XmlEnum("553")]
        Item553,

        /// <remarks/>
        [XmlEnum("554")]
        Item554,

        /// <remarks/>
        [XmlEnum("575")]
        Item575,

        /// <remarks/>
        [XmlEnum("576")]
        Item576,

        /// <remarks/>
        [XmlEnum("577")]
        Item577,

        /// <remarks/>
        [XmlEnum("578")]
        Item578,

        /// <remarks/>
        [XmlEnum("579")]
        Item579,

        /// <remarks/>
        [XmlEnum("580")]
        Item580,

        /// <remarks/>
        [XmlEnum("581")]
        Item581,

        /// <remarks/>
        [XmlEnum("582")]
        Item582,

        /// <remarks/>
        [XmlEnum("583")]
        Item583,

        /// <remarks/>
        [XmlEnum("584")]
        Item584,

        /// <remarks/>
        [XmlEnum("585")]
        Item585,

        /// <remarks/>
        [XmlEnum("586")]
        Item586,

        /// <remarks/>
        [XmlEnum("587")]
        Item587,

        /// <remarks/>
        [XmlEnum("588")]
        Item588,

        /// <remarks/>
        [XmlEnum("589")]
        Item589,

        /// <remarks/>
        [XmlEnum("610")]
        Item610,

        /// <remarks/>
        [XmlEnum("621")]
        Item621,

        /// <remarks/>
        [XmlEnum("622")]
        Item622,

        /// <remarks/>
        [XmlEnum("623")]
        Item623,

        /// <remarks/>
        [XmlEnum("624")]
        Item624,

        /// <remarks/>
        [XmlEnum("625")]
        Item625,

        /// <remarks/>
        [XmlEnum("626")]
        Item626,

        /// <remarks/>
        [XmlEnum("627")]
        Item627,

        /// <remarks/>
        [XmlEnum("628")]
        Item628,

        /// <remarks/>
        [XmlEnum("629")]
        Item629,

        /// <remarks/>
        [XmlEnum("630")]
        Item630,

        /// <remarks/>
        [XmlEnum("631")]
        Item631,

        /// <remarks/>
        [XmlEnum("632")]
        Item632,

        /// <remarks/>
        [XmlEnum("633")]
        Item633,

        /// <remarks/>
        [XmlEnum("634")]
        Item634,

        /// <remarks/>
        [XmlEnum("635")]
        Item635,

        /// <remarks/>
        [XmlEnum("636")]
        Item636,

        /// <remarks/>
        [XmlEnum("637")]
        Item637,

        /// <remarks/>
        [XmlEnum("638")]
        Item638,

        /// <remarks/>
        [XmlEnum("639")]
        Item639,

        /// <remarks/>
        [XmlEnum("640")]
        Item640,

        /// <remarks/>
        [XmlEnum("641")]
        Item641,

        /// <remarks/>
        [XmlEnum("642")]
        Item642,

        /// <remarks/>
        [XmlEnum("643")]
        Item643,

        /// <remarks/>
        [XmlEnum("644")]
        Item644,

        /// <remarks/>
        [XmlEnum("645")]
        Item645,

        /// <remarks/>
        [XmlEnum("646")]
        Item646,

        /// <remarks/>
        [XmlEnum("647")]
        Item647,

        /// <remarks/>
        [XmlEnum("648")]
        Item648,

        /// <remarks/>
        [XmlEnum("649")]
        Item649,

        /// <remarks/>
        [XmlEnum("650")]
        Item650,

        /// <remarks/>
        [XmlEnum("651")]
        Item651,

        /// <remarks/>
        [XmlEnum("652")]
        Item652,

        /// <remarks/>
        [XmlEnum("653")]
        Item653,

        /// <remarks/>
        [XmlEnum("654")]
        Item654,

        /// <remarks/>
        [XmlEnum("655")]
        Item655,

        /// <remarks/>
        [XmlEnum("656")]
        Item656,

        /// <remarks/>
        [XmlEnum("657")]
        Item657,

        /// <remarks/>
        [XmlEnum("658")]
        Item658,

        /// <remarks/>
        [XmlEnum("659")]
        Item659,

        /// <remarks/>
        [XmlEnum("700")]
        Item700,

        /// <remarks/>
        [XmlEnum("701")]
        Item701,

        /// <remarks/>
        [XmlEnum("702")]
        Item702,

        /// <remarks/>
        [XmlEnum("703")]
        Item703,

        /// <remarks/>
        [XmlEnum("704")]
        Item704,

        /// <remarks/>
        [XmlEnum("705")]
        Item705,

        /// <remarks/>
        [XmlEnum("706")]
        Item706,

        /// <remarks/>
        [XmlEnum("707")]
        Item707,

        /// <remarks/>
        [XmlEnum("708")]
        Item708,

        /// <remarks/>
        [XmlEnum("709")]
        Item709,

        /// <remarks/>
        [XmlEnum("710")]
        Item710,

        /// <remarks/>
        [XmlEnum("711")]
        Item711,

        /// <remarks/>
        [XmlEnum("712")]
        Item712,

        /// <remarks/>
        [XmlEnum("713")]
        Item713,

        /// <remarks/>
        [XmlEnum("714")]
        Item714,

        /// <remarks/>
        [XmlEnum("715")]
        Item715,

        /// <remarks/>
        [XmlEnum("716")]
        Item716,

        /// <remarks/>
        [XmlEnum("717")]
        Item717,

        /// <remarks/>
        [XmlEnum("718")]
        Item718,

        /// <remarks/>
        [XmlEnum("719")]
        Item719,

        /// <remarks/>
        [XmlEnum("720")]
        Item720,

        /// <remarks/>
        [XmlEnum("721")]
        Item721,

        /// <remarks/>
        [XmlEnum("722")]
        Item722,

        /// <remarks/>
        [XmlEnum("723")]
        Item723,

        /// <remarks/>
        [XmlEnum("724")]
        Item724,

        /// <remarks/>
        [XmlEnum("725")]
        Item725,

        /// <remarks/>
        [XmlEnum("726")]
        Item726,

        /// <remarks/>
        [XmlEnum("727")]
        Item727,

        /// <remarks/>
        [XmlEnum("728")]
        Item728,

        /// <remarks/>
        [XmlEnum("729")]
        Item729,

        /// <remarks/>
        [XmlEnum("730")]
        Item730,

        /// <remarks/>
        [XmlEnum("731")]
        Item731,

        /// <remarks/>
        [XmlEnum("732")]
        Item732,

        /// <remarks/>
        [XmlEnum("733")]
        Item733,

        /// <remarks/>
        [XmlEnum("734")]
        Item734,

        /// <remarks/>
        [XmlEnum("735")]
        Item735,

        /// <remarks/>
        [XmlEnum("736")]
        Item736,

        /// <remarks/>
        [XmlEnum("737")]
        Item737,

        /// <remarks/>
        [XmlEnum("738")]
        Item738,

        /// <remarks/>
        [XmlEnum("739")]
        Item739,

        /// <remarks/>
        [XmlEnum("740")]
        Item740,

        /// <remarks/>
        [XmlEnum("741")]
        Item741,

        /// <remarks/>
        [XmlEnum("742")]
        Item742,

        /// <remarks/>
        [XmlEnum("743")]
        Item743,

        /// <remarks/>
        [XmlEnum("744")]
        Item744,

        /// <remarks/>
        [XmlEnum("745")]
        Item745,

        /// <remarks/>
        [XmlEnum("746")]
        Item746,

        /// <remarks/>
        [XmlEnum("747")]
        Item747,

        /// <remarks/>
        [XmlEnum("748")]
        Item748,

        /// <remarks/>
        [XmlEnum("749")]
        Item749,

        /// <remarks/>
        [XmlEnum("750")]
        Item750,

        /// <remarks/>
        [XmlEnum("751")]
        Item751,

        /// <remarks/>
        [XmlEnum("760")]
        Item760,

        /// <remarks/>
        [XmlEnum("761")]
        Item761,

        /// <remarks/>
        [XmlEnum("763")]
        Item763,

        /// <remarks/>
        [XmlEnum("764")]
        Item764,

        /// <remarks/>
        [XmlEnum("765")]
        Item765,

        /// <remarks/>
        [XmlEnum("766")]
        Item766,

        /// <remarks/>
        [XmlEnum("770")]
        Item770,

        /// <remarks/>
        [XmlEnum("775")]
        Item775,

        /// <remarks/>
        [XmlEnum("780")]
        Item780,

        /// <remarks/>
        [XmlEnum("781")]
        Item781,

        /// <remarks/>
        [XmlEnum("782")]
        Item782,

        /// <remarks/>
        [XmlEnum("783")]
        Item783,

        /// <remarks/>
        [XmlEnum("784")]
        Item784,

        /// <remarks/>
        [XmlEnum("785")]
        Item785,

        /// <remarks/>
        [XmlEnum("786")]
        Item786,

        /// <remarks/>
        [XmlEnum("787")]
        Item787,

        /// <remarks/>
        [XmlEnum("788")]
        Item788,

        /// <remarks/>
        [XmlEnum("789")]
        Item789,

        /// <remarks/>
        [XmlEnum("790")]
        Item790,

        /// <remarks/>
        [XmlEnum("791")]
        Item791,

        /// <remarks/>
        [XmlEnum("792")]
        Item792,

        /// <remarks/>
        [XmlEnum("793")]
        Item793,

        /// <remarks/>
        [XmlEnum("794")]
        Item794,

        /// <remarks/>
        [XmlEnum("795")]
        Item795,

        /// <remarks/>
        [XmlEnum("796")]
        Item796,

        /// <remarks/>
        [XmlEnum("797")]
        Item797,

        /// <remarks/>
        [XmlEnum("798")]
        Item798,

        /// <remarks/>
        [XmlEnum("799")]
        Item799,

        /// <remarks/>
        [XmlEnum("810")]
        Item810,

        /// <remarks/>
        [XmlEnum("811")]
        Item811,

        /// <remarks/>
        [XmlEnum("812")]
        Item812,

        /// <remarks/>
        [XmlEnum("820")]
        Item820,

        /// <remarks/>
        [XmlEnum("821")]
        Item821,

        /// <remarks/>
        [XmlEnum("822")]
        Item822,

        /// <remarks/>
        [XmlEnum("823")]
        Item823,

        /// <remarks/>
        [XmlEnum("824")]
        Item824,

        /// <remarks/>
        [XmlEnum("825")]
        Item825,

        /// <remarks/>
        [XmlEnum("830")]
        Item830,

        /// <remarks/>
        [XmlEnum("833")]
        Item833,

        /// <remarks/>
        [XmlEnum("840")]
        Item840,

        /// <remarks/>
        [XmlEnum("841")]
        Item841,

        /// <remarks/>
        [XmlEnum("850")]
        Item850,

        /// <remarks/>
        [XmlEnum("851")]
        Item851,

        /// <remarks/>
        [XmlEnum("852")]
        Item852,

        /// <remarks/>
        [XmlEnum("853")]
        Item853,

        /// <remarks/>
        [XmlEnum("855")]
        Item855,

        /// <remarks/>
        [XmlEnum("856")]
        Item856,

        /// <remarks/>
        [XmlEnum("860")]
        Item860,

        /// <remarks/>
        [XmlEnum("861")]
        Item861,

        /// <remarks/>
        [XmlEnum("862")]
        Item862,

        /// <remarks/>
        [XmlEnum("863")]
        Item863,

        /// <remarks/>
        [XmlEnum("864")]
        Item864,

        /// <remarks/>
        [XmlEnum("865")]
        Item865,

        /// <remarks/>
        [XmlEnum("870")]
        Item870,

        /// <remarks/>
        [XmlEnum("890")]
        Item890,

        /// <remarks/>
        [XmlEnum("895")]
        Item895,

        /// <remarks/>
        [XmlEnum("896")]
        Item896,

        /// <remarks/>
        [XmlEnum("901")]
        Item901,

        /// <remarks/>
        [XmlEnum("910")]
        Item910,

        /// <remarks/>
        [XmlEnum("911")]
        Item911,

        /// <remarks/>
        [XmlEnum("913")]
        Item913,

        /// <remarks/>
        [XmlEnum("914")]
        Item914,

        /// <remarks/>
        [XmlEnum("915")]
        Item915,

        /// <remarks/>
        [XmlEnum("916")]
        Item916,

        /// <remarks/>
        [XmlEnum("917")]
        Item917,

        /// <remarks/>
        [XmlEnum("925")]
        Item925,

        /// <remarks/>
        [XmlEnum("926")]
        Item926,

        /// <remarks/>
        [XmlEnum("927")]
        Item927,

        /// <remarks/>
        [XmlEnum("929")]
        Item929,

        /// <remarks/>
        [XmlEnum("930")]
        Item930,

        /// <remarks/>
        [XmlEnum("931")]
        Item931,

        /// <remarks/>
        [XmlEnum("932")]
        Item932,

        /// <remarks/>
        [XmlEnum("933")]
        Item933,

        /// <remarks/>
        [XmlEnum("934")]
        Item934,

        /// <remarks/>
        [XmlEnum("935")]
        Item935,

        /// <remarks/>
        [XmlEnum("936")]
        Item936,

        /// <remarks/>
        [XmlEnum("937")]
        Item937,

        /// <remarks/>
        [XmlEnum("938")]
        Item938,

        /// <remarks/>
        [XmlEnum("940")]
        Item940,

        /// <remarks/>
        [XmlEnum("941")]
        Item941,

        /// <remarks/>
        [XmlEnum("950")]
        Item950,

        /// <remarks/>
        [XmlEnum("951")]
        Item951,

        /// <remarks/>
        [XmlEnum("952")]
        Item952,

        /// <remarks/>
        [XmlEnum("953")]
        Item953,

        /// <remarks/>
        [XmlEnum("954")]
        Item954,

        /// <remarks/>
        [XmlEnum("955")]
        Item955,

        /// <remarks/>
        [XmlEnum("960")]
        Item960,

        /// <remarks/>
        [XmlEnum("961")]
        Item961,

        /// <remarks/>
        [XmlEnum("962")]
        Item962,

        /// <remarks/>
        [XmlEnum("963")]
        Item963,

        /// <remarks/>
        [XmlEnum("964")]
        Item964,

        /// <remarks/>
        [XmlEnum("965")]
        Item965,

        /// <remarks/>
        [XmlEnum("966")]
        Item966,

        /// <remarks/>
        [XmlEnum("970")]
        Item970,

        /// <remarks/>
        [XmlEnum("971")]
        Item971,

        /// <remarks/>
        [XmlEnum("972")]
        Item972,

        /// <remarks/>
        [XmlEnum("974")]
        Item974,

        /// <remarks/>
        [XmlEnum("975")]
        Item975,

        /// <remarks/>
        [XmlEnum("976")]
        Item976,

        /// <remarks/>
        [XmlEnum("977")]
        Item977,

        /// <remarks/>
        [XmlEnum("978")]
        Item978,

        /// <remarks/>
        [XmlEnum("979")]
        Item979,
        [XmlEnum("990")]
        Item990,
        [XmlEnum("991")]
        Item991,
        [XmlEnum("995")]
        Item995,
        [XmlEnum("996")]
        Item996,
        [XmlEnum("998")]
        Item998,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:ReferenceTypeCode:D16A")]
    public enum ReferenceTypeCodeContentType
    {
        AAA,
        AAB,
        AAC,
        AAD,
        AAE,
        AAF,
        AAG,
        AAH,
        AAI,
        AAJ,
        AAK,
        AAL,
        AAM,
        AAN,
        AAO,
        AAP,
        AAQ,
        AAR,
        AAS,
        AAT,
        AAU,
        AAV,
        AAW,
        AAX,
        AAY,
        AAZ,
        ABA,
        ABB,
        ABC,
        ABD,

        /// <remarks/>
        ABE,

        /// <remarks/>
        ABF,

        /// <remarks/>
        ABG,

        /// <remarks/>
        ABH,

        /// <remarks/>
        ABI,

        /// <remarks/>
        ABJ,

        /// <remarks/>
        ABK,

        /// <remarks/>
        ABL,

        /// <remarks/>
        ABM,
        ABN,
        ABO,
        ABP,

        /// <remarks/>
        ABQ,

        /// <remarks/>
        ABR,
        ABS,

        /// <remarks/>
        ABT,

        /// <remarks/>
        ABU,

        /// <remarks/>
        ABV,

        /// <remarks/>
        ABW,

        /// <remarks/>
        ABX,

        /// <remarks/>
        ABY,

        /// <remarks/>
        ABZ,

        /// <remarks/>
        AC,

        /// <remarks/>
        ACA,

        /// <remarks/>
        ACB,

        /// <remarks/>
        ACC,

        /// <remarks/>
        ACD,

        /// <remarks/>
        ACE,

        /// <remarks/>
        ACF,

        /// <remarks/>
        ACG,

        /// <remarks/>
        ACH,

        /// <remarks/>
        ACI,

        /// <remarks/>
        ACJ,

        /// <remarks/>
        ACK,

        /// <remarks/>
        ACL,

        /// <remarks/>
        ACN,

        /// <remarks/>
        ACO,

        /// <remarks/>
        ACP,

        /// <remarks/>
        ACQ,

        /// <remarks/>
        ACR,

        /// <remarks/>
        ACT,

        /// <remarks/>
        ACU,

        /// <remarks/>
        ACV,

        /// <remarks/>
        ACW,

        /// <remarks/>
        ACX,

        /// <remarks/>
        ACY,

        /// <remarks/>
        ACZ,

        /// <remarks/>
        ADA,

        /// <remarks/>
        ADB,

        /// <remarks/>
        ADC,

        /// <remarks/>
        ADD,

        /// <remarks/>
        ADE,

        /// <remarks/>
        ADF,

        /// <remarks/>
        ADG,

        /// <remarks/>
        ADI,

        /// <remarks/>
        ADJ,

        /// <remarks/>
        ADK,

        /// <remarks/>
        ADL,

        /// <remarks/>
        ADM,

        /// <remarks/>
        ADN,

        /// <remarks/>
        ADO,

        /// <remarks/>
        ADP,

        /// <remarks/>
        ADQ,

        /// <remarks/>
        ADT,

        /// <remarks/>
        ADU,

        /// <remarks/>
        ADV,

        /// <remarks/>
        ADW,

        /// <remarks/>
        ADX,

        /// <remarks/>
        ADY,

        /// <remarks/>
        ADZ,

        /// <remarks/>
        AE,

        /// <remarks/>
        AEA,

        /// <remarks/>
        AEB,

        /// <remarks/>
        AEC,

        /// <remarks/>
        AED,

        /// <remarks/>
        AEE,

        /// <remarks/>
        AEF,

        /// <remarks/>
        AEG,

        /// <remarks/>
        AEH,

        /// <remarks/>
        AEI,

        /// <remarks/>
        AEJ,

        /// <remarks/>
        AEK,

        /// <remarks/>
        AEL,

        /// <remarks/>
        AEM,

        /// <remarks/>
        AEN,

        /// <remarks/>
        AEO,

        /// <remarks/>
        AEP,

        /// <remarks/>
        AEQ,

        /// <remarks/>
        AER,

        /// <remarks/>
        AES,

        /// <remarks/>
        AET,

        /// <remarks/>
        AEU,

        /// <remarks/>
        AEV,

        /// <remarks/>
        AEW,

        /// <remarks/>
        AEX,

        /// <remarks/>
        AEY,

        /// <remarks/>
        AEZ,

        /// <remarks/>
        AF,

        /// <remarks/>
        AFA,

        /// <remarks/>
        AFB,

        /// <remarks/>
        AFC,

        /// <remarks/>
        AFD,

        /// <remarks/>
        AFE,

        /// <remarks/>
        AFF,

        /// <remarks/>
        AFG,

        /// <remarks/>
        AFH,

        /// <remarks/>
        AFI,

        /// <remarks/>
        AFJ,

        /// <remarks/>
        AFK,

        /// <remarks/>
        AFL,

        /// <remarks/>
        AFM,

        /// <remarks/>
        AFN,

        /// <remarks/>
        AFO,

        /// <remarks/>
        AFP,

        /// <remarks/>
        AFQ,

        /// <remarks/>
        AFR,

        /// <remarks/>
        AFS,

        /// <remarks/>
        AFT,

        /// <remarks/>
        AFU,

        /// <remarks/>
        AFV,

        /// <remarks/>
        AFW,

        /// <remarks/>
        AFX,

        /// <remarks/>
        AFY,

        /// <remarks/>
        AFZ,

        /// <remarks/>
        AGA,

        /// <remarks/>
        AGB,

        /// <remarks/>
        AGC,

        /// <remarks/>
        AGD,

        /// <remarks/>
        AGE,

        /// <remarks/>
        AGF,

        /// <remarks/>
        AGG,

        /// <remarks/>
        AGH,

        /// <remarks/>
        AGI,

        /// <remarks/>
        AGJ,

        /// <remarks/>
        AGK,

        /// <remarks/>
        AGL,

        /// <remarks/>
        AGM,

        /// <remarks/>
        AGN,

        /// <remarks/>
        AGO,

        /// <remarks/>
        AGP,

        /// <remarks/>
        AGQ,

        /// <remarks/>
        AGR,

        /// <remarks/>
        AGS,

        /// <remarks/>
        AGT,

        /// <remarks/>
        AGU,

        /// <remarks/>
        AGV,

        /// <remarks/>
        AGW,

        /// <remarks/>
        AGX,

        /// <remarks/>
        AGY,

        /// <remarks/>
        AGZ,

        /// <remarks/>
        AHA,

        /// <remarks/>
        AHB,

        /// <remarks/>
        AHC,

        /// <remarks/>
        AHD,

        /// <remarks/>
        AHE,

        /// <remarks/>
        AHF,

        /// <remarks/>
        AHG,

        /// <remarks/>
        AHH,

        /// <remarks/>
        AHI,

        /// <remarks/>
        AHJ,

        /// <remarks/>
        AHK,

        /// <remarks/>
        AHL,

        /// <remarks/>
        AHM,

        /// <remarks/>
        AHN,

        /// <remarks/>
        AHO,

        /// <remarks/>
        AHP,

        /// <remarks/>
        AHQ,

        /// <remarks/>
        AHR,

        /// <remarks/>
        AHS,

        /// <remarks/>
        AHT,

        /// <remarks/>
        AHU,

        /// <remarks/>
        AHV,

        /// <remarks/>
        AHX,

        /// <remarks/>
        AHY,

        /// <remarks/>
        AHZ,

        /// <remarks/>
        AIA,

        /// <remarks/>
        AIB,

        /// <remarks/>
        AIC,

        /// <remarks/>
        AID,

        /// <remarks/>
        AIE,

        /// <remarks/>
        AIF,

        /// <remarks/>
        AIG,

        /// <remarks/>
        AIH,

        /// <remarks/>
        AII,

        /// <remarks/>
        AIJ,

        /// <remarks/>
        AIK,

        /// <remarks/>
        AIL,

        /// <remarks/>
        AIM,

        /// <remarks/>
        AIN,

        /// <remarks/>
        AIO,

        /// <remarks/>
        AIP,

        /// <remarks/>
        AIQ,

        /// <remarks/>
        AIR,

        /// <remarks/>
        AIS,

        /// <remarks/>
        AIT,

        /// <remarks/>
        AIU,

        /// <remarks/>
        AIV,

        /// <remarks/>
        AIW,

        /// <remarks/>
        AIX,

        /// <remarks/>
        AIY,

        /// <remarks/>
        AIZ,

        /// <remarks/>
        AJA,

        /// <remarks/>
        AJB,

        /// <remarks/>
        AJC,

        /// <remarks/>
        AJD,

        /// <remarks/>
        AJE,

        /// <remarks/>
        AJF,

        /// <remarks/>
        AJG,

        /// <remarks/>
        AJH,

        /// <remarks/>
        AJI,

        /// <remarks/>
        AJJ,

        /// <remarks/>
        AJK,

        /// <remarks/>
        AJL,

        /// <remarks/>
        AJM,

        /// <remarks/>
        AJN,

        /// <remarks/>
        AJO,

        /// <remarks/>
        AJP,

        /// <remarks/>
        AJQ,

        /// <remarks/>
        AJR,

        /// <remarks/>
        AJS,

        /// <remarks/>
        AJT,

        /// <remarks/>
        AJU,

        /// <remarks/>
        AJV,

        /// <remarks/>
        AJW,

        /// <remarks/>
        AJX,

        /// <remarks/>
        AJY,

        /// <remarks/>
        AJZ,

        /// <remarks/>
        AKA,

        /// <remarks/>
        AKB,

        /// <remarks/>
        AKC,

        /// <remarks/>
        AKD,

        /// <remarks/>
        AKE,

        /// <remarks/>
        AKF,

        /// <remarks/>
        AKG,

        /// <remarks/>
        AKH,

        /// <remarks/>
        AKI,

        /// <remarks/>
        AKJ,

        /// <remarks/>
        AKK,

        /// <remarks/>
        AKL,

        /// <remarks/>
        AKM,
        AKN,
        AKO,
        AKP,
        AKQ,

        /// <remarks/>
        AKR,

        /// <remarks/>
        AKS,

        /// <remarks/>
        AKT,

        /// <remarks/>
        AKU,

        /// <remarks/>
        AKV,

        /// <remarks/>
        AKW,

        /// <remarks/>
        AKX,

        /// <remarks/>
        AKY,

        /// <remarks/>
        AKZ,

        /// <remarks/>
        ALA,

        /// <remarks/>
        ALB,

        /// <remarks/>
        ALC,

        /// <remarks/>
        ALD,

        /// <remarks/>
        ALE,

        /// <remarks/>
        ALF,

        /// <remarks/>
        ALG,

        /// <remarks/>
        ALH,

        /// <remarks/>
        ALI,

        /// <remarks/>
        ALJ,

        /// <remarks/>
        ALK,

        /// <remarks/>
        ALL,

        /// <remarks/>
        ALM,

        /// <remarks/>
        ALN,

        /// <remarks/>
        ALO,

        /// <remarks/>
        ALP,

        /// <remarks/>
        ALQ,

        /// <remarks/>
        ALR,

        /// <remarks/>
        ALS,

        /// <remarks/>
        ALT,

        /// <remarks/>
        ALU,

        /// <remarks/>
        ALV,

        /// <remarks/>
        ALW,

        /// <remarks/>
        ALX,

        /// <remarks/>
        ALY,

        /// <remarks/>
        ALZ,

        /// <remarks/>
        AMA,

        /// <remarks/>
        AMB,

        /// <remarks/>
        AMC,

        /// <remarks/>
        AMD,

        /// <remarks/>
        AME,

        /// <remarks/>
        AMF,

        /// <remarks/>
        AMG,

        /// <remarks/>
        AMH,

        /// <remarks/>
        AMI,

        /// <remarks/>
        AMJ,

        /// <remarks/>
        AMK,

        /// <remarks/>
        AML,

        /// <remarks/>
        AMM,

        /// <remarks/>
        AMN,

        /// <remarks/>
        AMO,

        /// <remarks/>
        AMP,

        /// <remarks/>
        AMQ,

        /// <remarks/>
        AMR,

        /// <remarks/>
        AMS,

        /// <remarks/>
        AMT,

        /// <remarks/>
        AMU,

        /// <remarks/>
        AMV,

        /// <remarks/>
        AMW,

        /// <remarks/>
        AMX,

        /// <remarks/>
        AMY,

        /// <remarks/>
        AMZ,

        /// <remarks/>
        ANA,

        /// <remarks/>
        ANB,

        /// <remarks/>
        ANC,

        /// <remarks/>
        AND,

        /// <remarks/>
        ANE,

        /// <remarks/>
        ANF,

        /// <remarks/>
        ANG,

        /// <remarks/>
        ANH,

        /// <remarks/>
        ANI,

        /// <remarks/>
        ANJ,

        /// <remarks/>
        ANK,

        /// <remarks/>
        ANL,

        /// <remarks/>
        ANM,

        /// <remarks/>
        ANN,

        /// <remarks/>
        ANO,

        /// <remarks/>
        ANP,

        /// <remarks/>
        ANQ,

        /// <remarks/>
        ANR,

        /// <remarks/>
        ANS,

        /// <remarks/>
        ANT,

        /// <remarks/>
        ANU,

        /// <remarks/>
        ANV,

        /// <remarks/>
        ANW,

        /// <remarks/>
        ANX,

        /// <remarks/>
        ANY,

        /// <remarks/>
        AOA,

        /// <remarks/>
        AOD,

        /// <remarks/>
        AOE,

        /// <remarks/>
        AOF,

        /// <remarks/>
        AOG,

        /// <remarks/>
        AOH,

        /// <remarks/>
        AOI,

        /// <remarks/>
        AOJ,

        /// <remarks/>
        AOK,

        /// <remarks/>
        AOL,

        /// <remarks/>
        AOM,

        /// <remarks/>
        AON,

        /// <remarks/>
        AOO,

        /// <remarks/>
        AOP,

        /// <remarks/>
        AOQ,

        /// <remarks/>
        AOR,

        /// <remarks/>
        AOS,

        /// <remarks/>
        AOT,

        /// <remarks/>
        AOU,

        /// <remarks/>
        AOV,

        /// <remarks/>
        AOW,

        /// <remarks/>
        AOX,

        /// <remarks/>
        AOY,

        /// <remarks/>
        AOZ,

        /// <remarks/>
        AP,

        /// <remarks/>
        APA,

        /// <remarks/>
        APB,

        /// <remarks/>
        APC,

        /// <remarks/>
        APD,
        APE,
        APF,

        /// <remarks/>
        APG,

        /// <remarks/>
        APH,

        /// <remarks/>
        API,

        /// <remarks/>
        APJ,

        /// <remarks/>
        APK,

        /// <remarks/>
        APL,

        /// <remarks/>
        APM,

        /// <remarks/>
        APN,

        /// <remarks/>
        APO,

        /// <remarks/>
        APP,

        /// <remarks/>
        APQ,

        /// <remarks/>
        APR,

        /// <remarks/>
        APS,

        /// <remarks/>
        APT,

        /// <remarks/>
        APU,

        /// <remarks/>
        APV,

        /// <remarks/>
        APW,

        /// <remarks/>
        APX,

        /// <remarks/>
        APY,

        /// <remarks/>
        APZ,

        /// <remarks/>
        AQA,

        /// <remarks/>
        AQB,

        /// <remarks/>
        AQC,

        /// <remarks/>
        AQD,

        /// <remarks/>
        AQE,

        /// <remarks/>
        AQF,

        /// <remarks/>
        AQG,

        /// <remarks/>
        AQH,

        /// <remarks/>
        AQI,

        /// <remarks/>
        AQJ,

        /// <remarks/>
        AQK,

        /// <remarks/>
        AQL,

        /// <remarks/>
        AQM,

        /// <remarks/>
        AQN,

        /// <remarks/>
        AQO,

        /// <remarks/>
        AQP,

        /// <remarks/>
        AQQ,

        /// <remarks/>
        AQR,

        /// <remarks/>
        AQS,

        /// <remarks/>
        AQT,

        /// <remarks/>
        AQU,

        /// <remarks/>
        AQV,

        /// <remarks/>
        AQW,

        /// <remarks/>
        AQX,

        /// <remarks/>
        AQY,

        /// <remarks/>
        AQZ,

        /// <remarks/>
        ARA,

        /// <remarks/>
        ARB,

        /// <remarks/>
        ARC,

        /// <remarks/>
        ARD,

        /// <remarks/>
        ARE,

        /// <remarks/>
        ARF,

        /// <remarks/>
        ARG,

        /// <remarks/>
        ARH,

        /// <remarks/>
        ARI,

        /// <remarks/>
        ARJ,

        /// <remarks/>
        ARK,

        /// <remarks/>
        ARL,

        /// <remarks/>
        ARM,

        /// <remarks/>
        ARN,

        /// <remarks/>
        ARO,

        /// <remarks/>
        ARP,

        /// <remarks/>
        ARQ,

        /// <remarks/>
        ARR,

        /// <remarks/>
        ARS,

        /// <remarks/>
        ART,

        /// <remarks/>
        ARU,

        /// <remarks/>
        ARV,

        /// <remarks/>
        ARW,

        /// <remarks/>
        ARX,

        /// <remarks/>
        ARY,

        /// <remarks/>
        ARZ,

        /// <remarks/>
        ASA,

        /// <remarks/>
        ASB,

        /// <remarks/>
        ASC,

        /// <remarks/>
        ASD,

        /// <remarks/>
        ASE,

        /// <remarks/>
        ASF,

        /// <remarks/>
        ASG,

        /// <remarks/>
        ASH,

        /// <remarks/>
        ASI,

        /// <remarks/>
        ASJ,

        /// <remarks/>
        ASK,

        /// <remarks/>
        ASL,

        /// <remarks/>
        ASM,

        /// <remarks/>
        ASN,

        /// <remarks/>
        ASO,

        /// <remarks/>
        ASP,

        /// <remarks/>
        ASQ,

        /// <remarks/>
        ASR,

        /// <remarks/>
        ASS,

        /// <remarks/>
        AST,

        /// <remarks/>
        ASU,

        /// <remarks/>
        ASV,

        /// <remarks/>
        ASW,

        /// <remarks/>
        ASX,

        /// <remarks/>
        ASY,

        /// <remarks/>
        ASZ,

        /// <remarks/>
        ATA,

        /// <remarks/>
        ATB,

        /// <remarks/>
        ATC,

        /// <remarks/>
        ATD,

        /// <remarks/>
        ATE,

        /// <remarks/>
        ATF,

        /// <remarks/>
        ATG,

        /// <remarks/>
        ATH,

        /// <remarks/>
        ATI,

        /// <remarks/>
        ATJ,

        /// <remarks/>
        ATK,

        /// <remarks/>
        ATL,

        /// <remarks/>
        ATM,

        /// <remarks/>
        ATN,

        /// <remarks/>
        ATO,

        /// <remarks/>
        ATP,

        /// <remarks/>
        ATQ,

        /// <remarks/>
        ATR,

        /// <remarks/>
        ATS,

        /// <remarks/>
        ATT,

        /// <remarks/>
        ATU,

        /// <remarks/>
        ATV,

        /// <remarks/>
        ATW,

        /// <remarks/>
        ATX,

        /// <remarks/>
        ATY,

        /// <remarks/>
        ATZ,

        /// <remarks/>
        AU,

        /// <remarks/>
        AUA,

        /// <remarks/>
        AUB,

        /// <remarks/>
        AUC,

        /// <remarks/>
        AUD,

        /// <remarks/>
        AUE,

        /// <remarks/>
        AUF,

        /// <remarks/>
        AUG,

        /// <remarks/>
        AUH,

        /// <remarks/>
        AUI,

        /// <remarks/>
        AUJ,

        /// <remarks/>
        AUK,

        /// <remarks/>
        AUL,

        /// <remarks/>
        AUM,

        /// <remarks/>
        AUN,

        /// <remarks/>
        AUO,

        /// <remarks/>
        AUP,

        /// <remarks/>
        AUQ,

        /// <remarks/>
        AUR,

        /// <remarks/>
        AUS,

        /// <remarks/>
        AUT,

        /// <remarks/>
        AUU,

        /// <remarks/>
        AUV,

        /// <remarks/>
        AUW,

        /// <remarks/>
        AUX,

        /// <remarks/>
        AUY,

        /// <remarks/>
        AUZ,

        /// <remarks/>
        AV,

        /// <remarks/>
        AVA,

        /// <remarks/>
        AVB,

        /// <remarks/>
        AVC,

        /// <remarks/>
        AVD,

        /// <remarks/>
        AVE,

        /// <remarks/>
        AVF,

        /// <remarks/>
        AVG,

        /// <remarks/>
        AVH,

        /// <remarks/>
        AVI,

        /// <remarks/>
        AVJ,

        /// <remarks/>
        AVK,

        /// <remarks/>
        AVL,

        /// <remarks/>
        AVM,

        /// <remarks/>
        AVN,

        /// <remarks/>
        AVO,

        /// <remarks/>
        AVP,

        /// <remarks/>
        AVQ,

        /// <remarks/>
        AVR,

        /// <remarks/>
        AVS,

        /// <remarks/>
        AVT,

        /// <remarks/>
        AVU,

        /// <remarks/>
        AVV,

        /// <remarks/>
        AVW,

        /// <remarks/>
        AVX,

        /// <remarks/>
        AVY,

        /// <remarks/>
        AVZ,

        /// <remarks/>
        AWA,

        /// <remarks/>
        AWB,

        /// <remarks/>
        AWC,

        /// <remarks/>
        AWD,

        /// <remarks/>
        AWE,

        /// <remarks/>
        AWF,

        /// <remarks/>
        AWG,

        /// <remarks/>
        AWH,

        /// <remarks/>
        AWI,

        /// <remarks/>
        AWJ,

        /// <remarks/>
        AWK,

        /// <remarks/>
        AWL,

        /// <remarks/>
        AWM,

        /// <remarks/>
        AWN,

        /// <remarks/>
        AWO,

        /// <remarks/>
        AWP,

        /// <remarks/>
        AWQ,

        /// <remarks/>
        AWR,

        /// <remarks/>
        AWS,

        /// <remarks/>
        AWT,

        /// <remarks/>
        AWU,

        /// <remarks/>
        AWV,

        /// <remarks/>
        AWW,

        /// <remarks/>
        AWX,

        /// <remarks/>
        AWY,

        /// <remarks/>
        AWZ,

        /// <remarks/>
        AXA,

        /// <remarks/>
        AXB,

        /// <remarks/>
        AXC,

        /// <remarks/>
        AXD,

        /// <remarks/>
        AXE,

        /// <remarks/>
        AXF,

        /// <remarks/>
        AXG,

        /// <remarks/>
        AXH,

        /// <remarks/>
        AXI,

        /// <remarks/>
        AXJ,

        /// <remarks/>
        AXK,

        /// <remarks/>
        AXL,

        /// <remarks/>
        AXM,

        /// <remarks/>
        AXN,

        /// <remarks/>
        AXO,

        /// <remarks/>
        AXP,

        /// <remarks/>
        AXQ,

        /// <remarks/>
        AXR,

        /// <remarks/>
        BA,

        /// <remarks/>
        BC,

        /// <remarks/>
        BD,

        /// <remarks/>
        BE,

        /// <remarks/>
        BH,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BR,

        /// <remarks/>
        BT,

        /// <remarks/>
        BW,

        /// <remarks/>
        CAS,

        /// <remarks/>
        CAT,

        /// <remarks/>
        CAU,

        /// <remarks/>
        CAV,

        /// <remarks/>
        CAW,

        /// <remarks/>
        CAX,

        /// <remarks/>
        CAY,

        /// <remarks/>
        CAZ,

        /// <remarks/>
        CBA,

        /// <remarks/>
        CBB,

        /// <remarks/>
        CD,

        /// <remarks/>
        CEC,

        /// <remarks/>
        CED,

        /// <remarks/>
        CFE,

        /// <remarks/>
        CFF,

        /// <remarks/>
        CFO,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CK,

        /// <remarks/>
        CKN,

        /// <remarks/>
        CM,

        /// <remarks/>
        CMR,

        /// <remarks/>
        CN,

        /// <remarks/>
        CNO,

        /// <remarks/>
        COF,

        /// <remarks/>
        CP,

        /// <remarks/>
        CR,

        /// <remarks/>
        CRN,

        /// <remarks/>
        CS,

        /// <remarks/>
        CST,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,

        /// <remarks/>
        CV,

        /// <remarks/>
        CW,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DA,

        /// <remarks/>
        DAN,

        /// <remarks/>
        DB,

        /// <remarks/>
        DI,

        /// <remarks/>
        DL,

        /// <remarks/>
        DM,

        /// <remarks/>
        DQ,

        /// <remarks/>
        DR,

        /// <remarks/>
        EA,

        /// <remarks/>
        EB,

        /// <remarks/>
        ED,

        /// <remarks/>
        EE,

        /// <remarks/>
        EI,

        /// <remarks/>
        EN,

        /// <remarks/>
        EQ,

        /// <remarks/>
        ER,

        /// <remarks/>
        ERN,

        /// <remarks/>
        ET,

        /// <remarks/>
        EX,

        /// <remarks/>
        FC,

        /// <remarks/>
        FF,

        /// <remarks/>
        FI,

        /// <remarks/>
        FLW,

        /// <remarks/>
        FN,

        /// <remarks/>
        FO,

        /// <remarks/>
        FS,

        /// <remarks/>
        FT,

        /// <remarks/>
        FV,

        /// <remarks/>
        FX,

        /// <remarks/>
        GA,

        /// <remarks/>
        GC,

        /// <remarks/>
        GD,

        /// <remarks/>
        GDN,

        /// <remarks/>
        GN,

        /// <remarks/>
        HS,

        /// <remarks/>
        HWB,

        /// <remarks/>
        IA,

        /// <remarks/>
        IB,

        /// <remarks/>
        ICA,

        /// <remarks/>
        ICE,

        /// <remarks/>
        ICO,

        /// <remarks/>
        II,

        /// <remarks/>
        IL,

        /// <remarks/>
        INB,

        /// <remarks/>
        INN,

        /// <remarks/>
        INO,

        /// <remarks/>
        IP,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        IV,

        /// <remarks/>
        JB,

        /// <remarks/>
        JE,

        /// <remarks/>
        LA,

        /// <remarks/>
        LAN,

        /// <remarks/>
        LAR,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LI,

        /// <remarks/>
        LO,

        /// <remarks/>
        LRC,

        /// <remarks/>
        LS,

        /// <remarks/>
        MA,

        /// <remarks/>
        MB,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MH,

        /// <remarks/>
        MR,

        /// <remarks/>
        MRN,

        /// <remarks/>
        MS,

        /// <remarks/>
        MSS,

        /// <remarks/>
        MWB,

        /// <remarks/>
        NA,

        /// <remarks/>
        NF,

        /// <remarks/>
        OH,

        /// <remarks/>
        OI,

        /// <remarks/>
        ON,

        /// <remarks/>
        OP,

        /// <remarks/>
        OR,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PI,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        POR,

        /// <remarks/>
        PP,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PW,

        /// <remarks/>
        PY,

        /// <remarks/>
        RA,

        /// <remarks/>
        RC,

        /// <remarks/>
        RCN,

        /// <remarks/>
        RE,

        /// <remarks/>
        REN,

        /// <remarks/>
        RF,

        /// <remarks/>
        RR,

        /// <remarks/>
        RT,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SEA,

        /// <remarks/>
        SF,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SP,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SRN,

        /// <remarks/>
        SS,

        /// <remarks/>
        STA,

        /// <remarks/>
        SW,

        /// <remarks/>
        SZ,

        /// <remarks/>
        TB,

        /// <remarks/>
        TCR,

        /// <remarks/>
        TE,

        /// <remarks/>
        TF,

        /// <remarks/>
        TI,

        /// <remarks/>
        TIN,

        /// <remarks/>
        TL,

        /// <remarks/>
        TN,

        /// <remarks/>
        TP,

        /// <remarks/>
        UAR,

        /// <remarks/>
        UC,

        /// <remarks/>
        UCN,

        /// <remarks/>
        UN,

        /// <remarks/>
        UO,

        /// <remarks/>
        URI,

        /// <remarks/>
        VA,

        /// <remarks/>
        VC,

        /// <remarks/>
        VGR,

        /// <remarks/>
        VM,

        /// <remarks/>
        VN,

        /// <remarks/>
        VON,

        /// <remarks/>
        VOR,
        VP,
        VR,
        VS,
        VT,
        VV,
        WE,
        WM,
        WN,
        WR,
        WS,
        WY,
        XA,
        XC,
        XP,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:AllowanceChargeReasonCode:D16A")]
    public enum AllowanceChargeReasonCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,

        /// <remarks/>
        [XmlEnum("16")]
        Item16,

        /// <remarks/>
        [XmlEnum("17")]
        Item17,

        /// <remarks/>
        [XmlEnum("18")]
        Item18,

        /// <remarks/>
        [XmlEnum("19")]
        Item19,

        /// <remarks/>
        [XmlEnum("20")]
        Item20,

        /// <remarks/>
        [XmlEnum("21")]
        Item21,

        /// <remarks/>
        [XmlEnum("22")]
        Item22,

        /// <remarks/>
        [XmlEnum("23")]
        Item23,

        /// <remarks/>
        [XmlEnum("24")]
        Item24,

        /// <remarks/>
        [XmlEnum("25")]
        Item25,

        /// <remarks/>
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,

        /// <remarks/>
        [XmlEnum("29")]
        Item29,

        /// <remarks/>
        [XmlEnum("30")]
        Item30,

        /// <remarks/>
        [XmlEnum("31")]
        Item31,

        /// <remarks/>
        [XmlEnum("32")]
        Item32,

        /// <remarks/>
        [XmlEnum("33")]
        Item33,

        /// <remarks/>
        [XmlEnum("34")]
        Item34,

        /// <remarks/>
        [XmlEnum("35")]
        Item35,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,

        /// <remarks/>
        [XmlEnum("38")]
        Item38,

        /// <remarks/>
        [XmlEnum("39")]
        Item39,

        /// <remarks/>
        [XmlEnum("40")]
        Item40,

        /// <remarks/>
        [XmlEnum("41")]
        Item41,

        /// <remarks/>
        [XmlEnum("42")]
        Item42,

        /// <remarks/>
        [XmlEnum("43")]
        Item43,

        /// <remarks/>
        [XmlEnum("44")]
        Item44,

        /// <remarks/>
        [XmlEnum("45")]
        Item45,

        /// <remarks/>
        [XmlEnum("46")]
        Item46,

        /// <remarks/>
        [XmlEnum("47")]
        Item47,

        /// <remarks/>
        [XmlEnum("48")]
        Item48,

        /// <remarks/>
        [XmlEnum("49")]
        Item49,

        /// <remarks/>
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("54")]
        Item54,

        /// <remarks/>
        [XmlEnum("55")]
        Item55,

        /// <remarks/>
        [XmlEnum("56")]
        Item56,

        /// <remarks/>
        [XmlEnum("57")]
        Item57,

        /// <remarks/>
        [XmlEnum("58")]
        Item58,

        /// <remarks/>
        [XmlEnum("59")]
        Item59,

        /// <remarks/>
        [XmlEnum("60")]
        Item60,

        /// <remarks/>
        [XmlEnum("61")]
        Item61,

        /// <remarks/>
        [XmlEnum("62")]
        Item62,

        /// <remarks/>
        [XmlEnum("63")]
        Item63,

        /// <remarks/>
        [XmlEnum("64")]
        Item64,

        /// <remarks/>
        [XmlEnum("65")]
        Item65,

        /// <remarks/>
        [XmlEnum("66")]
        Item66,

        /// <remarks/>
        [XmlEnum("67")]
        Item67,

        /// <remarks/>
        [XmlEnum("68")]
        Item68,

        /// <remarks/>
        [XmlEnum("69")]
        Item69,

        /// <remarks/>
        [XmlEnum("70")]
        Item70,

        /// <remarks/>
        [XmlEnum("71")]
        Item71,

        /// <remarks/>
        [XmlEnum("72")]
        Item72,

        /// <remarks/>
        [XmlEnum("73")]
        Item73,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,

        /// <remarks/>
        [XmlEnum("76")]
        Item76,

        /// <remarks/>
        [XmlEnum("77")]
        Item77,

        /// <remarks/>
        [XmlEnum("78")]
        Item78,

        /// <remarks/>
        [XmlEnum("79")]
        Item79,

        /// <remarks/>
        [XmlEnum("80")]
        Item80,

        /// <remarks/>
        [XmlEnum("81")]
        Item81,
        [XmlEnum("82")]
        Item82,
        [XmlEnum("83")]
        Item83,
        [XmlEnum("84")]
        Item84,
        [XmlEnum("85")]
        Item85,
        [XmlEnum("86")]
        Item86,
        [XmlEnum("87")]
        Item87,
        [XmlEnum("88")]
        Item88,

        /// <remarks/>
        [XmlEnum("89")]
        Item89,

        /// <remarks/>
        [XmlEnum("90")]
        Item90,

        /// <remarks/>
        [XmlEnum("91")]
        Item91,

        /// <remarks/>
        [XmlEnum("92")]
        Item92,

        /// <remarks/>
        [XmlEnum("93")]
        Item93,

        /// <remarks/>
        [XmlEnum("94")]
        Item94,

        /// <remarks/>
        [XmlEnum("95")]
        Item95,

        /// <remarks/>
        [XmlEnum("96")]
        Item96,

        /// <remarks/>
        [XmlEnum("97")]
        Item97,
        [XmlEnum("98")]
        Item98,
        [XmlEnum("99")]
        Item99,
        [XmlEnum("100")]
        Item100,
        [XmlEnum("101")]
        Item101,
        [XmlEnum("102")]
        Item102,
        [XmlEnum("103")]
        Item103,
        [XmlEnum("104")]
        Item104,
        ZZZ,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:AllowanceChargeIdentificationCode:D16A")]
    public enum AllowanceChargeIdentificationCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,

        /// <remarks/>
        [XmlEnum("26")]
        Item26,

        /// <remarks/>
        [XmlEnum("27")]
        Item27,

        /// <remarks/>
        [XmlEnum("28")]
        Item28,

        /// <remarks/>
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,

        /// <remarks/>
        [XmlEnum("34")]
        Item34,

        /// <remarks/>
        [XmlEnum("35")]
        Item35,

        /// <remarks/>
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("42")]
        Item42,
        [XmlEnum("44")]
        Item44,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("46")]
        Item46,
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("49")]
        Item49,
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("54")]
        Item54,
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("58")]
        Item58,
        [XmlEnum("59")]
        Item59,
        [XmlEnum("60")]
        Item60,
        [XmlEnum("61")]
        Item61,
        [XmlEnum("62")]
        Item62,
        [XmlEnum("63")]
        Item63,
        [XmlEnum("64")]
        Item64,
        [XmlEnum("65")]
        Item65,
        [XmlEnum("66")]
        Item66,
        [XmlEnum("67")]
        Item67,
        [XmlEnum("68")]
        Item68,
        [XmlEnum("69")]
        Item69,
        [XmlEnum("70")]
        Item70,
        [XmlEnum("71")]
        Item71,
        [XmlEnum("72")]
        Item72,
        [XmlEnum("73")]
        Item73,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,
        [XmlEnum("76")]
        Item76,
        [XmlEnum("77")]
        Item77,
        [XmlEnum("78")]
        Item78,
        [XmlEnum("79")]
        Item79,
        [XmlEnum("80")]
        Item80,
        [XmlEnum("81")]
        Item81,
        [XmlEnum("82")]
        Item82,
        [XmlEnum("83")]
        Item83,
        [XmlEnum("84")]
        Item84,
        [XmlEnum("85")]
        Item85,
        [XmlEnum("86")]
        Item86,
        [XmlEnum("87")]
        Item87,
        [XmlEnum("88")]
        Item88,
        [XmlEnum("89")]
        Item89,
        [XmlEnum("90")]
        Item90,
        [XmlEnum("91")]
        Item91,
        [XmlEnum("92")]
        Item92,
        [XmlEnum("93")]
        Item93,
        [XmlEnum("94")]
        Item94,
        [XmlEnum("95")]
        Item95,
        [XmlEnum("96")]
        Item96,
        [XmlEnum("97")]
        Item97,
        [XmlEnum("98")]
        Item98,
        [XmlEnum("99")]
        Item99,
        [XmlEnum("100")]
        Item100,
        [XmlEnum("101")]
        Item101,
        [XmlEnum("102")]
        Item102,
        [XmlEnum("103")]
        Item103,
        [XmlEnum("104")]
        Item104,
        [XmlEnum("105")]
        Item105,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:identifierlist:standard:UNECE:FreightCostCode:4")]
    public enum FreightCostCodeContentType
    {
        [XmlEnum("100000")]
        Item100000,
        [XmlEnum("100999")]
        Item100999,
        [XmlEnum("101000")]
        Item101000,
        [XmlEnum("101002")]
        Item101002,
        [XmlEnum("101003")]
        Item101003,
        [XmlEnum("101004")]
        Item101004,
        [XmlEnum("101005")]
        Item101005,
        [XmlEnum("101006")]
        Item101006,
        [XmlEnum("101007")]
        Item101007,
        [XmlEnum("101008")]
        Item101008,
        [XmlEnum("101009")]
        Item101009,
        [XmlEnum("101010")]
        Item101010,

        /// <remarks/>
        [XmlEnum("101011")]
        Item101011,

        /// <remarks/>
        [XmlEnum("101012")]
        Item101012,

        /// <remarks/>
        [XmlEnum("101013")]
        Item101013,

        /// <remarks/>
        [XmlEnum("101014")]
        Item101014,
        [XmlEnum("101015")]
        Item101015,
        [XmlEnum("101016")]
        Item101016,

        /// <remarks/>
        [XmlEnum("101017")]
        Item101017,

        /// <remarks/>
        [XmlEnum("101018")]
        Item101018,

        /// <remarks/>
        [XmlEnum("101019")]
        Item101019,

        /// <remarks/>
        [XmlEnum("101020")]
        Item101020,

        /// <remarks/>
        [XmlEnum("101021")]
        Item101021,

        /// <remarks/>
        [XmlEnum("101021")]
        Item1010211,

        /// <remarks/>
        [XmlEnum("101021")]
        Item1010212,

        /// <remarks/>
        [XmlEnum("101021")]
        Item1010213,

        /// <remarks/>
        [XmlEnum("101021")]
        Item1010214,
        [XmlEnum("101021")]
        Item1010215,
        [XmlEnum("101021")]
        Item1010216,

        /// <remarks/>
        [XmlEnum("101021")]
        Item1010217,

        /// <remarks/>
        [XmlEnum("101022")]
        Item101022,

        /// <remarks/>
        [XmlEnum("101024")]
        Item101024,

        /// <remarks/>
        [XmlEnum("101027")]
        Item101027,
        [XmlEnum("101028")]
        Item101028,
        [XmlEnum("101029")]
        Item101029,

        /// <remarks/>
        [XmlEnum("101031")]
        Item101031,

        /// <remarks/>
        [XmlEnum("101033")]
        Item101033,

        /// <remarks/>
        [XmlEnum("101034")]
        Item101034,

        /// <remarks/>
        [XmlEnum("101035")]
        Item101035,

        /// <remarks/>
        [XmlEnum("101036")]
        Item101036,

        /// <remarks/>
        [XmlEnum("101037")]
        Item101037,

        /// <remarks/>
        [XmlEnum("101038")]
        Item101038,

        /// <remarks/>
        [XmlEnum("101039")]
        Item101039,

        /// <remarks/>
        [XmlEnum("101040")]
        Item101040,

        /// <remarks/>
        [XmlEnum("101041")]
        Item101041,

        /// <remarks/>
        [XmlEnum("101042")]
        Item101042,

        /// <remarks/>
        [XmlEnum("101043")]
        Item101043,
        [XmlEnum("101044")]
        Item101044,
        [XmlEnum("101045")]
        Item101045,
        [XmlEnum("101046")]
        Item101046,
        [XmlEnum("101047")]
        Item101047,

        /// <remarks/>
        [XmlEnum("101048")]
        Item101048,

        /// <remarks/>
        [XmlEnum("101049")]
        Item101049,

        /// <remarks/>
        [XmlEnum("101050")]
        Item101050,

        /// <remarks/>
        [XmlEnum("101051")]
        Item101051,

        /// <remarks/>
        [XmlEnum("101052")]
        Item101052,

        /// <remarks/>
        [XmlEnum("101053")]
        Item101053,

        /// <remarks/>
        [XmlEnum("101054")]
        Item101054,

        /// <remarks/>
        [XmlEnum("101056")]
        Item101056,

        /// <remarks/>
        [XmlEnum("101057")]
        Item101057,

        /// <remarks/>
        [XmlEnum("101058")]
        Item101058,

        /// <remarks/>
        [XmlEnum("101059")]
        Item101059,

        /// <remarks/>
        [XmlEnum("101060")]
        Item101060,

        /// <remarks/>
        [XmlEnum("101061")]
        Item101061,

        /// <remarks/>
        [XmlEnum("102000")]
        Item102000,

        /// <remarks/>
        [XmlEnum("102002")]
        Item102002,

        /// <remarks/>
        [XmlEnum("102003")]
        Item102003,

        /// <remarks/>
        [XmlEnum("102004")]
        Item102004,

        /// <remarks/>
        [XmlEnum("102005")]
        Item102005,

        /// <remarks/>
        [XmlEnum("102006")]
        Item102006,

        /// <remarks/>
        [XmlEnum("102011")]
        Item102011,

        /// <remarks/>
        [XmlEnum("102012")]
        Item102012,

        /// <remarks/>
        [XmlEnum("102013")]
        Item102013,
        [XmlEnum("102014")]
        Item102014,
        [XmlEnum("102015")]
        Item102015,
        [XmlEnum("102016")]
        Item102016,
        [XmlEnum("102017")]
        Item102017,

        /// <remarks/>
        [XmlEnum("102018")]
        Item102018,

        /// <remarks/>
        [XmlEnum("102019")]
        Item102019,

        /// <remarks/>
        [XmlEnum("102020")]
        Item102020,

        /// <remarks/>
        [XmlEnum("102021")]
        Item102021,

        /// <remarks/>
        [XmlEnum("102022")]
        Item102022,

        /// <remarks/>
        [XmlEnum("102023")]
        Item102023,

        /// <remarks/>
        [XmlEnum("102024")]
        Item102024,

        /// <remarks/>
        [XmlEnum("102025")]
        Item102025,

        /// <remarks/>
        [XmlEnum("102026")]
        Item102026,

        /// <remarks/>
        [XmlEnum("102027")]
        Item102027,

        /// <remarks/>
        [XmlEnum("102028")]
        Item102028,

        /// <remarks/>
        [XmlEnum("102029")]
        Item102029,

        /// <remarks/>
        [XmlEnum("102030")]
        Item102030,

        /// <remarks/>
        [XmlEnum("102041")]
        Item102041,

        /// <remarks/>
        [XmlEnum("102042")]
        Item102042,

        /// <remarks/>
        [XmlEnum("102043")]
        Item102043,

        /// <remarks/>
        [XmlEnum("102043")]
        Item1020431,

        /// <remarks/>
        [XmlEnum("102044")]
        Item102044,

        /// <remarks/>
        [XmlEnum("102045")]
        Item102045,

        /// <remarks/>
        [XmlEnum("102046")]
        Item102046,

        /// <remarks/>
        [XmlEnum("102047")]
        Item102047,

        /// <remarks/>
        [XmlEnum("102049")]
        Item102049,

        /// <remarks/>
        [XmlEnum("102050")]
        Item102050,

        /// <remarks/>
        [XmlEnum("102051")]
        Item102051,

        /// <remarks/>
        [XmlEnum("102052")]
        Item102052,

        /// <remarks/>
        [XmlEnum("102070")]
        Item102070,

        /// <remarks/>
        [XmlEnum("102071")]
        Item102071,

        /// <remarks/>
        [XmlEnum("102072")]
        Item102072,

        /// <remarks/>
        [XmlEnum("102073")]
        Item102073,

        /// <remarks/>
        [XmlEnum("102074")]
        Item102074,

        /// <remarks/>
        [XmlEnum("102075")]
        Item102075,

        /// <remarks/>
        [XmlEnum("102076")]
        Item102076,

        /// <remarks/>
        [XmlEnum("102077")]
        Item102077,

        /// <remarks/>
        [XmlEnum("102078")]
        Item102078,

        /// <remarks/>
        [XmlEnum("102079")]
        Item102079,

        /// <remarks/>
        [XmlEnum("102080")]
        Item102080,

        /// <remarks/>
        [XmlEnum("102081")]
        Item102081,

        /// <remarks/>
        [XmlEnum("102082")]
        Item102082,

        /// <remarks/>
        [XmlEnum("102083")]
        Item102083,

        /// <remarks/>
        [XmlEnum("102084")]
        Item102084,

        /// <remarks/>
        [XmlEnum("102085")]
        Item102085,

        /// <remarks/>
        [XmlEnum("102086")]
        Item102086,

        /// <remarks/>
        [XmlEnum("102087")]
        Item102087,

        /// <remarks/>
        [XmlEnum("102088")]
        Item102088,

        /// <remarks/>
        [XmlEnum("103000")]
        Item103000,

        /// <remarks/>
        [XmlEnum("103001")]
        Item103001,

        /// <remarks/>
        [XmlEnum("103002")]
        Item103002,

        /// <remarks/>
        [XmlEnum("103003")]
        Item103003,

        /// <remarks/>
        [XmlEnum("103004")]
        Item103004,

        /// <remarks/>
        [XmlEnum("103005")]
        Item103005,

        /// <remarks/>
        [XmlEnum("103006")]
        Item103006,

        /// <remarks/>
        [XmlEnum("103007")]
        Item103007,

        /// <remarks/>
        [XmlEnum("103008")]
        Item103008,

        /// <remarks/>
        [XmlEnum("103009")]
        Item103009,

        /// <remarks/>
        [XmlEnum("103010")]
        Item103010,

        /// <remarks/>
        [XmlEnum("103011")]
        Item103011,

        /// <remarks/>
        [XmlEnum("103012")]
        Item103012,

        /// <remarks/>
        [XmlEnum("103013")]
        Item103013,

        /// <remarks/>
        [XmlEnum("103015")]
        Item103015,

        /// <remarks/>
        [XmlEnum("103016")]
        Item103016,

        /// <remarks/>
        [XmlEnum("103017")]
        Item103017,

        /// <remarks/>
        [XmlEnum("103018")]
        Item103018,

        /// <remarks/>
        [XmlEnum("103019")]
        Item103019,

        /// <remarks/>
        [XmlEnum("104000")]
        Item104000,

        /// <remarks/>
        [XmlEnum("104002")]
        Item104002,

        /// <remarks/>
        [XmlEnum("104003")]
        Item104003,

        /// <remarks/>
        [XmlEnum("104004")]
        Item104004,

        /// <remarks/>
        [XmlEnum("104004")]
        Item1040041,

        /// <remarks/>
        [XmlEnum("104005")]
        Item104005,

        /// <remarks/>
        [XmlEnum("104006")]
        Item104006,

        /// <remarks/>
        [XmlEnum("104007")]
        Item104007,

        /// <remarks/>
        [XmlEnum("104008")]
        Item104008,

        /// <remarks/>
        [XmlEnum("104009")]
        Item104009,

        /// <remarks/>
        [XmlEnum("104010")]
        Item104010,

        /// <remarks/>
        [XmlEnum("104011")]
        Item104011,

        /// <remarks/>
        [XmlEnum("104012")]
        Item104012,

        /// <remarks/>
        [XmlEnum("104013")]
        Item104013,

        /// <remarks/>
        [XmlEnum("104014")]
        Item104014,

        /// <remarks/>
        [XmlEnum("104015")]
        Item104015,

        /// <remarks/>
        [XmlEnum("104016")]
        Item104016,

        /// <remarks/>
        [XmlEnum("104024")]
        Item104024,

        /// <remarks/>
        [XmlEnum("104024")]
        Item1040241,

        /// <remarks/>
        [XmlEnum("104024")]
        Item1040242,

        /// <remarks/>
        [XmlEnum("104025")]
        Item104025,

        /// <remarks/>
        [XmlEnum("104027")]
        Item104027,

        /// <remarks/>
        [XmlEnum("104028")]
        Item104028,

        /// <remarks/>
        [XmlEnum("104029")]
        Item104029,

        /// <remarks/>
        [XmlEnum("104030")]
        Item104030,

        /// <remarks/>
        [XmlEnum("104031")]
        Item104031,

        /// <remarks/>
        [XmlEnum("104032")]
        Item104032,

        /// <remarks/>
        [XmlEnum("104036")]
        Item104036,

        /// <remarks/>
        [XmlEnum("104037")]
        Item104037,

        /// <remarks/>
        [XmlEnum("104038")]
        Item104038,

        /// <remarks/>
        [XmlEnum("104039")]
        Item104039,

        /// <remarks/>
        [XmlEnum("104041")]
        Item104041,

        /// <remarks/>
        [XmlEnum("104042")]
        Item104042,

        /// <remarks/>
        [XmlEnum("104043")]
        Item104043,

        /// <remarks/>
        [XmlEnum("104044")]
        Item104044,

        /// <remarks/>
        [XmlEnum("104045")]
        Item104045,

        /// <remarks/>
        [XmlEnum("104046")]
        Item104046,

        /// <remarks/>
        [XmlEnum("104052")]
        Item104052,

        /// <remarks/>
        [XmlEnum("104052")]
        Item1040521,

        /// <remarks/>
        [XmlEnum("104052")]
        Item1040522,
        [XmlEnum("104052")]
        Item1040523,
        [XmlEnum("104055")]
        Item104055,
        [XmlEnum("104056")]
        Item104056,
        [XmlEnum("104059")]
        Item104059,
        [XmlEnum("104060")]
        Item104060,
        [XmlEnum("104063")]
        Item104063,
        [XmlEnum("104064")]
        Item104064,
        [XmlEnum("104068")]
        Item104068,

        /// <remarks/>
        [XmlEnum("104069")]
        Item104069,

        /// <remarks/>
        [XmlEnum("104070")]
        Item104070,

        /// <remarks/>
        [XmlEnum("104071")]
        Item104071,

        /// <remarks/>
        [XmlEnum("104072")]
        Item104072,

        /// <remarks/>
        [XmlEnum("104073")]
        Item104073,

        /// <remarks/>
        [XmlEnum("104074")]
        Item104074,

        /// <remarks/>
        [XmlEnum("104075")]
        Item104075,

        /// <remarks/>
        [XmlEnum("104076")]
        Item104076,

        /// <remarks/>
        [XmlEnum("104077")]
        Item104077,

        /// <remarks/>
        [XmlEnum("104078")]
        Item104078,

        /// <remarks/>
        [XmlEnum("104079")]
        Item104079,

        /// <remarks/>
        [XmlEnum("104080")]
        Item104080,

        /// <remarks/>
        [XmlEnum("104081")]
        Item104081,

        /// <remarks/>
        [XmlEnum("104082")]
        Item104082,

        /// <remarks/>
        [XmlEnum("104083")]
        Item104083,

        /// <remarks/>
        [XmlEnum("104084")]
        Item104084,

        /// <remarks/>
        [XmlEnum("104085")]
        Item104085,

        /// <remarks/>
        [XmlEnum("104102")]
        Item104102,

        /// <remarks/>
        [XmlEnum("104102")]
        Item1041021,

        /// <remarks/>
        [XmlEnum("104104")]
        Item104104,

        /// <remarks/>
        [XmlEnum("104106")]
        Item104106,

        /// <remarks/>
        [XmlEnum("104107")]
        Item104107,
        [XmlEnum("104108")]
        Item104108,
        [XmlEnum("104109")]
        Item104109,
        [XmlEnum("104110")]
        Item104110,
        [XmlEnum("104111")]
        Item104111,

        /// <remarks/>
        [XmlEnum("104112")]
        Item104112,

        /// <remarks/>
        [XmlEnum("104113")]
        Item104113,

        /// <remarks/>
        [XmlEnum("104114")]
        Item104114,

        /// <remarks/>
        [XmlEnum("104115")]
        Item104115,

        /// <remarks/>
        [XmlEnum("104116")]
        Item104116,

        /// <remarks/>
        [XmlEnum("104118")]
        Item104118,

        /// <remarks/>
        [XmlEnum("104119")]
        Item104119,

        /// <remarks/>
        [XmlEnum("104120")]
        Item104120,

        /// <remarks/>
        [XmlEnum("104121")]
        Item104121,

        /// <remarks/>
        [XmlEnum("104124")]
        Item104124,

        /// <remarks/>
        [XmlEnum("104125")]
        Item104125,

        /// <remarks/>
        [XmlEnum("104125")]
        Item1041251,

        /// <remarks/>
        [XmlEnum("104125")]
        Item1041252,
        [XmlEnum("104125")]
        Item1041253,

        /// <remarks/>
        [XmlEnum("104127")]
        Item104127,

        /// <remarks/>
        [XmlEnum("104129")]
        Item104129,

        /// <remarks/>
        [XmlEnum("104130")]
        Item104130,

        /// <remarks/>
        [XmlEnum("104131")]
        Item104131,

        /// <remarks/>
        [XmlEnum("104132")]
        Item104132,

        /// <remarks/>
        [XmlEnum("104134")]
        Item104134,

        /// <remarks/>
        [XmlEnum("104135")]
        Item104135,

        /// <remarks/>
        [XmlEnum("104135")]
        Item1041351,

        /// <remarks/>
        [XmlEnum("104135")]
        Item1041352,

        /// <remarks/>
        [XmlEnum("104135")]
        Item1041353,

        /// <remarks/>
        [XmlEnum("104136")]
        Item104136,

        /// <remarks/>
        [XmlEnum("104137")]
        Item104137,
        [XmlEnum("104137")]
        Item1041371,
        [XmlEnum("104137")]
        Item1041372,
        [XmlEnum("104138")]
        Item104138,

        /// <remarks/>
        [XmlEnum("104138")]
        Item1041381,

        /// <remarks/>
        [XmlEnum("104139")]
        Item104139,

        /// <remarks/>
        [XmlEnum("104139")]
        Item1041391,

        /// <remarks/>
        [XmlEnum("104139")]
        Item1041392,

        /// <remarks/>
        [XmlEnum("104139")]
        Item1041393,

        /// <remarks/>
        [XmlEnum("104140")]
        Item104140,

        /// <remarks/>
        [XmlEnum("104141")]
        Item104141,

        /// <remarks/>
        [XmlEnum("104142")]
        Item104142,

        /// <remarks/>
        [XmlEnum("104144")]
        Item104144,

        /// <remarks/>
        [XmlEnum("104144")]
        Item1041441,

        /// <remarks/>
        [XmlEnum("104144")]
        Item1041442,

        /// <remarks/>
        [XmlEnum("104145")]
        Item104145,

        /// <remarks/>
        [XmlEnum("104146")]
        Item104146,

        /// <remarks/>
        [XmlEnum("104148")]
        Item104148,

        /// <remarks/>
        [XmlEnum("104149")]
        Item104149,

        /// <remarks/>
        [XmlEnum("104150")]
        Item104150,

        /// <remarks/>
        [XmlEnum("104151")]
        Item104151,

        /// <remarks/>
        [XmlEnum("104152")]
        Item104152,

        /// <remarks/>
        [XmlEnum("104153")]
        Item104153,

        /// <remarks/>
        [XmlEnum("104154")]
        Item104154,

        /// <remarks/>
        [XmlEnum("104155")]
        Item104155,

        /// <remarks/>
        [XmlEnum("104156")]
        Item104156,

        /// <remarks/>
        [XmlEnum("104157")]
        Item104157,

        /// <remarks/>
        [XmlEnum("104158")]
        Item104158,

        /// <remarks/>
        [XmlEnum("104159")]
        Item104159,

        /// <remarks/>
        [XmlEnum("104159")]
        Item1041591,

        /// <remarks/>
        [XmlEnum("104160")]
        Item104160,

        /// <remarks/>
        [XmlEnum("104161")]
        Item104161,

        /// <remarks/>
        [XmlEnum("104162")]
        Item104162,

        /// <remarks/>
        [XmlEnum("104163")]
        Item104163,

        /// <remarks/>
        [XmlEnum("104164")]
        Item104164,

        /// <remarks/>
        [XmlEnum("104165")]
        Item104165,

        /// <remarks/>
        [XmlEnum("104166")]
        Item104166,

        /// <remarks/>
        [XmlEnum("104167")]
        Item104167,

        /// <remarks/>
        [XmlEnum("104168")]
        Item104168,

        /// <remarks/>
        [XmlEnum("104169")]
        Item104169,

        /// <remarks/>
        [XmlEnum("104170")]
        Item104170,

        /// <remarks/>
        [XmlEnum("104172")]
        Item104172,

        /// <remarks/>
        [XmlEnum("104173")]
        Item104173,

        /// <remarks/>
        [XmlEnum("104175")]
        Item104175,

        /// <remarks/>
        [XmlEnum("104176")]
        Item104176,

        /// <remarks/>
        [XmlEnum("104177")]
        Item104177,

        /// <remarks/>
        [XmlEnum("104178")]
        Item104178,

        /// <remarks/>
        [XmlEnum("104179")]
        Item104179,

        /// <remarks/>
        [XmlEnum("104180")]
        Item104180,

        /// <remarks/>
        [XmlEnum("104181")]
        Item104181,

        /// <remarks/>
        [XmlEnum("104182")]
        Item104182,

        /// <remarks/>
        [XmlEnum("104183")]
        Item104183,

        /// <remarks/>
        [XmlEnum("104185")]
        Item104185,

        /// <remarks/>
        [XmlEnum("104186")]
        Item104186,

        /// <remarks/>
        [XmlEnum("104188")]
        Item104188,

        /// <remarks/>
        [XmlEnum("104189")]
        Item104189,

        /// <remarks/>
        [XmlEnum("104190")]
        Item104190,

        /// <remarks/>
        [XmlEnum("104191")]
        Item104191,

        /// <remarks/>
        [XmlEnum("104192")]
        Item104192,

        /// <remarks/>
        [XmlEnum("104193")]
        Item104193,

        /// <remarks/>
        [XmlEnum("104194")]
        Item104194,

        /// <remarks/>
        [XmlEnum("104195")]
        Item104195,

        /// <remarks/>
        [XmlEnum("104196")]
        Item104196,

        /// <remarks/>
        [XmlEnum("104197")]
        Item104197,

        /// <remarks/>
        [XmlEnum("104198")]
        Item104198,

        /// <remarks/>
        [XmlEnum("104199")]
        Item104199,

        /// <remarks/>
        [XmlEnum("104200")]
        Item104200,

        /// <remarks/>
        [XmlEnum("104201")]
        Item104201,

        /// <remarks/>
        [XmlEnum("104202")]
        Item104202,

        /// <remarks/>
        [XmlEnum("104203")]
        Item104203,

        /// <remarks/>
        [XmlEnum("105000")]
        Item105000,

        /// <remarks/>
        [XmlEnum("105001")]
        Item105001,

        /// <remarks/>
        [XmlEnum("105002")]
        Item105002,

        /// <remarks/>
        [XmlEnum("105003")]
        Item105003,

        /// <remarks/>
        [XmlEnum("105004")]
        Item105004,

        /// <remarks/>
        [XmlEnum("105005")]
        Item105005,

        /// <remarks/>
        [XmlEnum("105006")]
        Item105006,

        /// <remarks/>
        [XmlEnum("105007")]
        Item105007,

        /// <remarks/>
        [XmlEnum("105009")]
        Item105009,

        /// <remarks/>
        [XmlEnum("105010")]
        Item105010,

        /// <remarks/>
        [XmlEnum("105012")]
        Item105012,

        /// <remarks/>
        [XmlEnum("105013")]
        Item105013,

        /// <remarks/>
        [XmlEnum("105014")]
        Item105014,

        /// <remarks/>
        [XmlEnum("105015")]
        Item105015,

        /// <remarks/>
        [XmlEnum("105016")]
        Item105016,

        /// <remarks/>
        [XmlEnum("105017")]
        Item105017,

        /// <remarks/>
        [XmlEnum("105018")]
        Item105018,

        /// <remarks/>
        [XmlEnum("105020")]
        Item105020,

        /// <remarks/>
        [XmlEnum("106000")]
        Item106000,

        /// <remarks/>
        [XmlEnum("106001")]
        Item106001,

        /// <remarks/>
        [XmlEnum("106002")]
        Item106002,

        /// <remarks/>
        [XmlEnum("106003")]
        Item106003,

        /// <remarks/>
        [XmlEnum("106004")]
        Item106004,

        /// <remarks/>
        [XmlEnum("106005")]
        Item106005,

        /// <remarks/>
        [XmlEnum("106006")]
        Item106006,

        /// <remarks/>
        [XmlEnum("106007")]
        Item106007,

        /// <remarks/>
        [XmlEnum("106008")]
        Item106008,

        /// <remarks/>
        [XmlEnum("106009")]
        Item106009,

        /// <remarks/>
        [XmlEnum("106010")]
        Item106010,

        /// <remarks/>
        [XmlEnum("106011")]
        Item106011,

        /// <remarks/>
        [XmlEnum("106012")]
        Item106012,

        /// <remarks/>
        [XmlEnum("106013")]
        Item106013,

        /// <remarks/>
        [XmlEnum("106014")]
        Item106014,

        /// <remarks/>
        [XmlEnum("106015")]
        Item106015,

        /// <remarks/>
        [XmlEnum("106016")]
        Item106016,

        /// <remarks/>
        [XmlEnum("106018")]
        Item106018,

        /// <remarks/>
        [XmlEnum("107000")]
        Item107000,

        /// <remarks/>
        [XmlEnum("107001")]
        Item107001,

        /// <remarks/>
        [XmlEnum("107001")]
        Item1070011,

        /// <remarks/>
        [XmlEnum("107002")]
        Item107002,

        /// <remarks/>
        [XmlEnum("108000")]
        Item108000,

        /// <remarks/>
        [XmlEnum("108001")]
        Item108001,

        /// <remarks/>
        [XmlEnum("108002")]
        Item108002,

        /// <remarks/>
        [XmlEnum("108003")]
        Item108003,

        /// <remarks/>
        [XmlEnum("108004")]
        Item108004,

        /// <remarks/>
        [XmlEnum("108005")]
        Item108005,

        /// <remarks/>
        [XmlEnum("108006")]
        Item108006,

        /// <remarks/>
        [XmlEnum("109000")]
        Item109000,

        /// <remarks/>
        [XmlEnum("109001")]
        Item109001,

        /// <remarks/>
        [XmlEnum("110000")]
        Item110000,

        /// <remarks/>
        [XmlEnum("110001")]
        Item110001,

        /// <remarks/>
        [XmlEnum("110002")]
        Item110002,

        /// <remarks/>
        [XmlEnum("110003")]
        Item110003,

        /// <remarks/>
        [XmlEnum("110004")]
        Item110004,

        /// <remarks/>
        [XmlEnum("110005")]
        Item110005,

        /// <remarks/>
        [XmlEnum("110006")]
        Item110006,

        /// <remarks/>
        [XmlEnum("110007")]
        Item110007,

        /// <remarks/>
        [XmlEnum("110008")]
        Item110008,

        /// <remarks/>
        [XmlEnum("110009")]
        Item110009,

        /// <remarks/>
        [XmlEnum("110010")]
        Item110010,

        /// <remarks/>
        [XmlEnum("110011")]
        Item110011,

        /// <remarks/>
        [XmlEnum("200000")]
        Item200000,

        /// <remarks/>
        [XmlEnum("200999")]
        Item200999,

        /// <remarks/>
        [XmlEnum("202000")]
        Item202000,

        /// <remarks/>
        [XmlEnum("202001")]
        Item202001,

        /// <remarks/>
        [XmlEnum("202002")]
        Item202002,

        /// <remarks/>
        [XmlEnum("202003")]
        Item202003,

        /// <remarks/>
        [XmlEnum("202004")]
        Item202004,

        /// <remarks/>
        [XmlEnum("202005")]
        Item202005,

        /// <remarks/>
        [XmlEnum("202006")]
        Item202006,

        /// <remarks/>
        [XmlEnum("202007")]
        Item202007,

        /// <remarks/>
        [XmlEnum("202008")]
        Item202008,

        /// <remarks/>
        [XmlEnum("202009")]
        Item202009,

        /// <remarks/>
        [XmlEnum("202010")]
        Item202010,

        /// <remarks/>
        [XmlEnum("202011")]
        Item202011,

        /// <remarks/>
        [XmlEnum("202012")]
        Item202012,

        /// <remarks/>
        [XmlEnum("202013")]
        Item202013,

        /// <remarks/>
        [XmlEnum("203000")]
        Item203000,

        /// <remarks/>
        [XmlEnum("203001")]
        Item203001,

        /// <remarks/>
        [XmlEnum("203002")]
        Item203002,

        /// <remarks/>
        [XmlEnum("203003")]
        Item203003,

        /// <remarks/>
        [XmlEnum("203004")]
        Item203004,

        /// <remarks/>
        [XmlEnum("203005")]
        Item203005,

        /// <remarks/>
        [XmlEnum("203006")]
        Item203006,

        /// <remarks/>
        [XmlEnum("203007")]
        Item203007,

        /// <remarks/>
        [XmlEnum("203008")]
        Item203008,

        /// <remarks/>
        [XmlEnum("203009")]
        Item203009,

        /// <remarks/>
        [XmlEnum("203010")]
        Item203010,

        /// <remarks/>
        [XmlEnum("203011")]
        Item203011,

        /// <remarks/>
        [XmlEnum("203012")]
        Item203012,

        /// <remarks/>
        [XmlEnum("203013")]
        Item203013,

        /// <remarks/>
        [XmlEnum("203014")]
        Item203014,

        /// <remarks/>
        [XmlEnum("203015")]
        Item203015,

        /// <remarks/>
        [XmlEnum("203016")]
        Item203016,

        /// <remarks/>
        [XmlEnum("203017")]
        Item203017,

        /// <remarks/>
        [XmlEnum("203018")]
        Item203018,

        /// <remarks/>
        [XmlEnum("203019")]
        Item203019,

        /// <remarks/>
        [XmlEnum("203020")]
        Item203020,

        /// <remarks/>
        [XmlEnum("203021")]
        Item203021,

        /// <remarks/>
        [XmlEnum("203022")]
        Item203022,

        /// <remarks/>
        [XmlEnum("203023")]
        Item203023,

        /// <remarks/>
        [XmlEnum("203024")]
        Item203024,

        /// <remarks/>
        [XmlEnum("203025")]
        Item203025,

        /// <remarks/>
        [XmlEnum("203026")]
        Item203026,

        /// <remarks/>
        [XmlEnum("203027")]
        Item203027,

        /// <remarks/>
        [XmlEnum("203028")]
        Item203028,

        /// <remarks/>
        [XmlEnum("203029")]
        Item203029,

        /// <remarks/>
        [XmlEnum("203030")]
        Item203030,

        /// <remarks/>
        [XmlEnum("203031")]
        Item203031,

        /// <remarks/>
        [XmlEnum("203032")]
        Item203032,

        /// <remarks/>
        [XmlEnum("203033")]
        Item203033,

        /// <remarks/>
        [XmlEnum("203034")]
        Item203034,

        /// <remarks/>
        [XmlEnum("203035")]
        Item203035,

        /// <remarks/>
        [XmlEnum("203036")]
        Item203036,

        /// <remarks/>
        [XmlEnum("203037")]
        Item203037,

        /// <remarks/>
        [XmlEnum("203038")]
        Item203038,

        /// <remarks/>
        [XmlEnum("203039")]
        Item203039,

        /// <remarks/>
        [XmlEnum("203040")]
        Item203040,

        /// <remarks/>
        [XmlEnum("203041")]
        Item203041,

        /// <remarks/>
        [XmlEnum("203042")]
        Item203042,

        /// <remarks/>
        [XmlEnum("203043")]
        Item203043,

        /// <remarks/>
        [XmlEnum("203044")]
        Item203044,

        /// <remarks/>
        [XmlEnum("203045")]
        Item203045,

        /// <remarks/>
        [XmlEnum("203046")]
        Item203046,

        /// <remarks/>
        [XmlEnum("203047")]
        Item203047,

        /// <remarks/>
        [XmlEnum("203048")]
        Item203048,

        /// <remarks/>
        [XmlEnum("203049")]
        Item203049,

        /// <remarks/>
        [XmlEnum("203050")]
        Item203050,

        /// <remarks/>
        [XmlEnum("203051")]
        Item203051,

        /// <remarks/>
        [XmlEnum("203052")]
        Item203052,

        /// <remarks/>
        [XmlEnum("203053")]
        Item203053,

        /// <remarks/>
        [XmlEnum("203054")]
        Item203054,

        /// <remarks/>
        [XmlEnum("203055")]
        Item203055,

        /// <remarks/>
        [XmlEnum("203056")]
        Item203056,

        /// <remarks/>
        [XmlEnum("203057")]
        Item203057,

        /// <remarks/>
        [XmlEnum("203058")]
        Item203058,

        /// <remarks/>
        [XmlEnum("203059")]
        Item203059,

        /// <remarks/>
        [XmlEnum("203060")]
        Item203060,

        /// <remarks/>
        [XmlEnum("203061")]
        Item203061,

        /// <remarks/>
        [XmlEnum("203062")]
        Item203062,

        /// <remarks/>
        [XmlEnum("203063")]
        Item203063,

        /// <remarks/>
        [XmlEnum("203064")]
        Item203064,

        /// <remarks/>
        [XmlEnum("203065")]
        Item203065,

        /// <remarks/>
        [XmlEnum("203066")]
        Item203066,

        /// <remarks/>
        [XmlEnum("203067")]
        Item203067,

        /// <remarks/>
        [XmlEnum("203068")]
        Item203068,

        /// <remarks/>
        [XmlEnum("203069")]
        Item203069,

        /// <remarks/>
        [XmlEnum("203070")]
        Item203070,

        /// <remarks/>
        [XmlEnum("203071")]
        Item203071,

        /// <remarks/>
        [XmlEnum("203072")]
        Item203072,

        /// <remarks/>
        [XmlEnum("203073")]
        Item203073,

        /// <remarks/>
        [XmlEnum("203074")]
        Item203074,

        /// <remarks/>
        [XmlEnum("203075")]
        Item203075,

        /// <remarks/>
        [XmlEnum("203076")]
        Item203076,

        /// <remarks/>
        [XmlEnum("203077")]
        Item203077,

        /// <remarks/>
        [XmlEnum("203078")]
        Item203078,

        /// <remarks/>
        [XmlEnum("203079")]
        Item203079,

        /// <remarks/>
        [XmlEnum("203080")]
        Item203080,

        /// <remarks/>
        [XmlEnum("203081")]
        Item203081,

        /// <remarks/>
        [XmlEnum("203082")]
        Item203082,

        /// <remarks/>
        [XmlEnum("203083")]
        Item203083,

        /// <remarks/>
        [XmlEnum("203084")]
        Item203084,

        /// <remarks/>
        [XmlEnum("203085")]
        Item203085,

        /// <remarks/>
        [XmlEnum("203086")]
        Item203086,

        /// <remarks/>
        [XmlEnum("203087")]
        Item203087,

        /// <remarks/>
        [XmlEnum("203088")]
        Item203088,

        /// <remarks/>
        [XmlEnum("203089")]
        Item203089,

        /// <remarks/>
        [XmlEnum("203090")]
        Item203090,

        /// <remarks/>
        [XmlEnum("203091")]
        Item203091,

        /// <remarks/>
        [XmlEnum("203092")]
        Item203092,

        /// <remarks/>
        [XmlEnum("203093")]
        Item203093,

        /// <remarks/>
        [XmlEnum("203094")]
        Item203094,

        /// <remarks/>
        [XmlEnum("203095")]
        Item203095,

        /// <remarks/>
        [XmlEnum("203096")]
        Item203096,

        /// <remarks/>
        [XmlEnum("203097")]
        Item203097,

        /// <remarks/>
        [XmlEnum("203098")]
        Item203098,

        /// <remarks/>
        [XmlEnum("203099")]
        Item203099,

        /// <remarks/>
        [XmlEnum("203100")]
        Item203100,

        /// <remarks/>
        [XmlEnum("203102")]
        Item203102,

        /// <remarks/>
        [XmlEnum("203104")]
        Item203104,

        /// <remarks/>
        [XmlEnum("203105")]
        Item203105,

        /// <remarks/>
        [XmlEnum("203106")]
        Item203106,

        /// <remarks/>
        [XmlEnum("203107")]
        Item203107,

        /// <remarks/>
        [XmlEnum("203108")]
        Item203108,

        /// <remarks/>
        [XmlEnum("203109")]
        Item203109,

        /// <remarks/>
        [XmlEnum("203110")]
        Item203110,

        /// <remarks/>
        [XmlEnum("203111")]
        Item203111,

        /// <remarks/>
        [XmlEnum("203112")]
        Item203112,

        /// <remarks/>
        [XmlEnum("203113")]
        Item203113,

        /// <remarks/>
        [XmlEnum("203114")]
        Item203114,

        /// <remarks/>
        [XmlEnum("203115")]
        Item203115,

        /// <remarks/>
        [XmlEnum("203116")]
        Item203116,

        /// <remarks/>
        [XmlEnum("203117")]
        Item203117,

        /// <remarks/>
        [XmlEnum("203118")]
        Item203118,

        /// <remarks/>
        [XmlEnum("203119")]
        Item203119,

        /// <remarks/>
        [XmlEnum("203120")]
        Item203120,

        /// <remarks/>
        [XmlEnum("203121")]
        Item203121,

        /// <remarks/>
        [XmlEnum("203122")]
        Item203122,

        /// <remarks/>
        [XmlEnum("203123")]
        Item203123,

        /// <remarks/>
        [XmlEnum("203124")]
        Item203124,

        /// <remarks/>
        [XmlEnum("203125")]
        Item203125,

        /// <remarks/>
        [XmlEnum("203126")]
        Item203126,

        /// <remarks/>
        [XmlEnum("203127")]
        Item203127,

        /// <remarks/>
        [XmlEnum("203130")]
        Item203130,

        /// <remarks/>
        [XmlEnum("203130")]
        Item2031301,

        /// <remarks/>
        [XmlEnum("203131")]
        Item203131,

        /// <remarks/>
        [XmlEnum("203133")]
        Item203133,

        /// <remarks/>
        [XmlEnum("203134")]
        Item203134,

        /// <remarks/>
        [XmlEnum("203134")]
        Item2031341,

        /// <remarks/>
        [XmlEnum("203134")]
        Item2031342,

        /// <remarks/>
        [XmlEnum("203135")]
        Item203135,

        /// <remarks/>
        [XmlEnum("203136")]
        Item203136,

        /// <remarks/>
        [XmlEnum("203137")]
        Item203137,

        /// <remarks/>
        [XmlEnum("203138")]
        Item203138,

        /// <remarks/>
        [XmlEnum("203139")]
        Item203139,

        /// <remarks/>
        [XmlEnum("203140")]
        Item203140,

        /// <remarks/>
        [XmlEnum("203141")]
        Item203141,

        /// <remarks/>
        [XmlEnum("203142")]
        Item203142,

        /// <remarks/>
        [XmlEnum("203143")]
        Item203143,

        /// <remarks/>
        [XmlEnum("203144")]
        Item203144,

        /// <remarks/>
        [XmlEnum("203145")]
        Item203145,

        /// <remarks/>
        [XmlEnum("203146")]
        Item203146,

        /// <remarks/>
        [XmlEnum("203147")]
        Item203147,

        /// <remarks/>
        [XmlEnum("203148")]
        Item203148,

        /// <remarks/>
        [XmlEnum("203149")]
        Item203149,

        /// <remarks/>
        [XmlEnum("203150")]
        Item203150,

        /// <remarks/>
        [XmlEnum("203151")]
        Item203151,

        /// <remarks/>
        [XmlEnum("203152")]
        Item203152,

        /// <remarks/>
        [XmlEnum("203153")]
        Item203153,

        /// <remarks/>
        [XmlEnum("203154")]
        Item203154,

        /// <remarks/>
        [XmlEnum("203155")]
        Item203155,

        /// <remarks/>
        [XmlEnum("203156")]
        Item203156,

        /// <remarks/>
        [XmlEnum("203157")]
        Item203157,

        /// <remarks/>
        [XmlEnum("203158")]
        Item203158,

        /// <remarks/>
        [XmlEnum("203159")]
        Item203159,

        /// <remarks/>
        [XmlEnum("203160")]
        Item203160,

        /// <remarks/>
        [XmlEnum("203161")]
        Item203161,

        /// <remarks/>
        [XmlEnum("203162")]
        Item203162,

        /// <remarks/>
        [XmlEnum("203163")]
        Item203163,

        /// <remarks/>
        [XmlEnum("203164")]
        Item203164,

        /// <remarks/>
        [XmlEnum("203165")]
        Item203165,

        /// <remarks/>
        [XmlEnum("203166")]
        Item203166,

        /// <remarks/>
        [XmlEnum("203167")]
        Item203167,

        /// <remarks/>
        [XmlEnum("203168")]
        Item203168,

        /// <remarks/>
        [XmlEnum("203169")]
        Item203169,

        /// <remarks/>
        [XmlEnum("203170")]
        Item203170,

        /// <remarks/>
        [XmlEnum("203171")]
        Item203171,

        /// <remarks/>
        [XmlEnum("203172")]
        Item203172,

        /// <remarks/>
        [XmlEnum("203173")]
        Item203173,

        /// <remarks/>
        [XmlEnum("203174")]
        Item203174,

        /// <remarks/>
        [XmlEnum("203175")]
        Item203175,

        /// <remarks/>
        [XmlEnum("203176")]
        Item203176,

        /// <remarks/>
        [XmlEnum("203177")]
        Item203177,

        /// <remarks/>
        [XmlEnum("203178")]
        Item203178,

        /// <remarks/>
        [XmlEnum("203179")]
        Item203179,

        /// <remarks/>
        [XmlEnum("203180")]
        Item203180,

        /// <remarks/>
        [XmlEnum("203181")]
        Item203181,

        /// <remarks/>
        [XmlEnum("203182")]
        Item203182,

        /// <remarks/>
        [XmlEnum("203183")]
        Item203183,

        /// <remarks/>
        [XmlEnum("203184")]
        Item203184,

        /// <remarks/>
        [XmlEnum("203185")]
        Item203185,

        /// <remarks/>
        [XmlEnum("203186")]
        Item203186,

        /// <remarks/>
        [XmlEnum("203187")]
        Item203187,

        /// <remarks/>
        [XmlEnum("203188")]
        Item203188,

        /// <remarks/>
        [XmlEnum("203189")]
        Item203189,

        /// <remarks/>
        [XmlEnum("203190")]
        Item203190,

        /// <remarks/>
        [XmlEnum("203191")]
        Item203191,

        /// <remarks/>
        [XmlEnum("203192")]
        Item203192,

        /// <remarks/>
        [XmlEnum("203193")]
        Item203193,

        /// <remarks/>
        [XmlEnum("203194")]
        Item203194,

        /// <remarks/>
        [XmlEnum("203195")]
        Item203195,

        /// <remarks/>
        [XmlEnum("203196")]
        Item203196,

        /// <remarks/>
        [XmlEnum("204000")]
        Item204000,

        /// <remarks/>
        [XmlEnum("204001")]
        Item204001,

        /// <remarks/>
        [XmlEnum("204002")]
        Item204002,

        /// <remarks/>
        [XmlEnum("204003")]
        Item204003,

        /// <remarks/>
        [XmlEnum("204004")]
        Item204004,

        /// <remarks/>
        [XmlEnum("204005")]
        Item204005,

        /// <remarks/>
        [XmlEnum("204006")]
        Item204006,

        /// <remarks/>
        [XmlEnum("204007")]
        Item204007,

        /// <remarks/>
        [XmlEnum("204008")]
        Item204008,

        /// <remarks/>
        [XmlEnum("204009")]
        Item204009,

        /// <remarks/>
        [XmlEnum("204010")]
        Item204010,

        /// <remarks/>
        [XmlEnum("204011")]
        Item204011,

        /// <remarks/>
        [XmlEnum("204012")]
        Item204012,

        /// <remarks/>
        [XmlEnum("204013")]
        Item204013,

        /// <remarks/>
        [XmlEnum("204014")]
        Item204014,

        /// <remarks/>
        [XmlEnum("204015")]
        Item204015,

        /// <remarks/>
        [XmlEnum("204016")]
        Item204016,

        /// <remarks/>
        [XmlEnum("204017")]
        Item204017,

        /// <remarks/>
        [XmlEnum("204018")]
        Item204018,

        /// <remarks/>
        [XmlEnum("204019")]
        Item204019,

        /// <remarks/>
        [XmlEnum("204020")]
        Item204020,

        /// <remarks/>
        [XmlEnum("204021")]
        Item204021,

        /// <remarks/>
        [XmlEnum("204022")]
        Item204022,

        /// <remarks/>
        [XmlEnum("204023")]
        Item204023,

        /// <remarks/>
        [XmlEnum("204024")]
        Item204024,

        /// <remarks/>
        [XmlEnum("204025")]
        Item204025,

        /// <remarks/>
        [XmlEnum("204026")]
        Item204026,

        /// <remarks/>
        [XmlEnum("204027")]
        Item204027,

        /// <remarks/>
        [XmlEnum("204028")]
        Item204028,

        /// <remarks/>
        [XmlEnum("204029")]
        Item204029,

        /// <remarks/>
        [XmlEnum("204030")]
        Item204030,

        /// <remarks/>
        [XmlEnum("204031")]
        Item204031,

        /// <remarks/>
        [XmlEnum("204032")]
        Item204032,

        /// <remarks/>
        [XmlEnum("204033")]
        Item204033,

        /// <remarks/>
        [XmlEnum("204034")]
        Item204034,

        /// <remarks/>
        [XmlEnum("204035")]
        Item204035,

        /// <remarks/>
        [XmlEnum("204036")]
        Item204036,

        /// <remarks/>
        [XmlEnum("204037")]
        Item204037,

        /// <remarks/>
        [XmlEnum("204038")]
        Item204038,

        /// <remarks/>
        [XmlEnum("204039")]
        Item204039,

        /// <remarks/>
        [XmlEnum("204040")]
        Item204040,

        /// <remarks/>
        [XmlEnum("204041")]
        Item204041,

        /// <remarks/>
        [XmlEnum("204042")]
        Item204042,

        /// <remarks/>
        [XmlEnum("204043")]
        Item204043,

        /// <remarks/>
        [XmlEnum("204044")]
        Item204044,

        /// <remarks/>
        [XmlEnum("204045")]
        Item204045,

        /// <remarks/>
        [XmlEnum("204046")]
        Item204046,

        /// <remarks/>
        [XmlEnum("204047")]
        Item204047,

        /// <remarks/>
        [XmlEnum("204048")]
        Item204048,

        /// <remarks/>
        [XmlEnum("204049")]
        Item204049,

        /// <remarks/>
        [XmlEnum("204050")]
        Item204050,

        /// <remarks/>
        [XmlEnum("204051")]
        Item204051,

        /// <remarks/>
        [XmlEnum("204052")]
        Item204052,

        /// <remarks/>
        [XmlEnum("204053")]
        Item204053,

        /// <remarks/>
        [XmlEnum("204054")]
        Item204054,

        /// <remarks/>
        [XmlEnum("204055")]
        Item204055,

        /// <remarks/>
        [XmlEnum("204056")]
        Item204056,

        /// <remarks/>
        [XmlEnum("204057")]
        Item204057,

        /// <remarks/>
        [XmlEnum("204058")]
        Item204058,

        /// <remarks/>
        [XmlEnum("204059")]
        Item204059,

        /// <remarks/>
        [XmlEnum("204060")]
        Item204060,

        /// <remarks/>
        [XmlEnum("204061")]
        Item204061,

        /// <remarks/>
        [XmlEnum("204062")]
        Item204062,

        /// <remarks/>
        [XmlEnum("204063")]
        Item204063,

        /// <remarks/>
        [XmlEnum("204064")]
        Item204064,

        /// <remarks/>
        [XmlEnum("204065")]
        Item204065,

        /// <remarks/>
        [XmlEnum("204066")]
        Item204066,

        /// <remarks/>
        [XmlEnum("204067")]
        Item204067,

        /// <remarks/>
        [XmlEnum("204068")]
        Item204068,

        /// <remarks/>
        [XmlEnum("204069")]
        Item204069,

        /// <remarks/>
        [XmlEnum("204070")]
        Item204070,

        /// <remarks/>
        [XmlEnum("204071")]
        Item204071,

        /// <remarks/>
        [XmlEnum("204072")]
        Item204072,

        /// <remarks/>
        [XmlEnum("204073")]
        Item204073,

        /// <remarks/>
        [XmlEnum("204074")]
        Item204074,

        /// <remarks/>
        [XmlEnum("204075")]
        Item204075,

        /// <remarks/>
        [XmlEnum("204076")]
        Item204076,

        /// <remarks/>
        [XmlEnum("204077")]
        Item204077,

        /// <remarks/>
        [XmlEnum("204078")]
        Item204078,

        /// <remarks/>
        [XmlEnum("204079")]
        Item204079,

        /// <remarks/>
        [XmlEnum("204080")]
        Item204080,

        /// <remarks/>
        [XmlEnum("204081")]
        Item204081,

        /// <remarks/>
        [XmlEnum("204082")]
        Item204082,

        /// <remarks/>
        [XmlEnum("204083")]
        Item204083,

        /// <remarks/>
        [XmlEnum("204084")]
        Item204084,

        /// <remarks/>
        [XmlEnum("204085")]
        Item204085,

        /// <remarks/>
        [XmlEnum("204086")]
        Item204086,

        /// <remarks/>
        [XmlEnum("204087")]
        Item204087,

        /// <remarks/>
        [XmlEnum("204088")]
        Item204088,

        /// <remarks/>
        [XmlEnum("204089")]
        Item204089,

        /// <remarks/>
        [XmlEnum("204090")]
        Item204090,

        /// <remarks/>
        [XmlEnum("204091")]
        Item204091,

        /// <remarks/>
        [XmlEnum("204092")]
        Item204092,

        /// <remarks/>
        [XmlEnum("204093")]
        Item204093,

        /// <remarks/>
        [XmlEnum("204094")]
        Item204094,

        /// <remarks/>
        [XmlEnum("204095")]
        Item204095,

        /// <remarks/>
        [XmlEnum("204096")]
        Item204096,

        /// <remarks/>
        [XmlEnum("204097")]
        Item204097,

        /// <remarks/>
        [XmlEnum("204098")]
        Item204098,

        /// <remarks/>
        [XmlEnum("204099")]
        Item204099,

        /// <remarks/>
        [XmlEnum("204100")]
        Item204100,

        /// <remarks/>
        [XmlEnum("204101")]
        Item204101,

        /// <remarks/>
        [XmlEnum("204102")]
        Item204102,

        /// <remarks/>
        [XmlEnum("204103")]
        Item204103,

        /// <remarks/>
        [XmlEnum("204104")]
        Item204104,

        /// <remarks/>
        [XmlEnum("204105")]
        Item204105,

        /// <remarks/>
        [XmlEnum("204106")]
        Item204106,

        /// <remarks/>
        [XmlEnum("204107")]
        Item204107,

        /// <remarks/>
        [XmlEnum("204108")]
        Item204108,

        /// <remarks/>
        [XmlEnum("204109")]
        Item204109,

        /// <remarks/>
        [XmlEnum("204110")]
        Item204110,

        /// <remarks/>
        [XmlEnum("204111")]
        Item204111,

        /// <remarks/>
        [XmlEnum("204112")]
        Item204112,

        /// <remarks/>
        [XmlEnum("204113")]
        Item204113,

        /// <remarks/>
        [XmlEnum("204114")]
        Item204114,

        /// <remarks/>
        [XmlEnum("204115")]
        Item204115,

        /// <remarks/>
        [XmlEnum("204116")]
        Item204116,

        /// <remarks/>
        [XmlEnum("204117")]
        Item204117,

        /// <remarks/>
        [XmlEnum("204118")]
        Item204118,

        /// <remarks/>
        [XmlEnum("204119")]
        Item204119,

        /// <remarks/>
        [XmlEnum("204120")]
        Item204120,

        /// <remarks/>
        [XmlEnum("204121")]
        Item204121,

        /// <remarks/>
        [XmlEnum("204122")]
        Item204122,

        /// <remarks/>
        [XmlEnum("204123")]
        Item204123,

        /// <remarks/>
        [XmlEnum("204124")]
        Item204124,

        /// <remarks/>
        [XmlEnum("204125")]
        Item204125,

        /// <remarks/>
        [XmlEnum("204126")]
        Item204126,

        /// <remarks/>
        [XmlEnum("204127")]
        Item204127,

        /// <remarks/>
        [XmlEnum("204128")]
        Item204128,

        /// <remarks/>
        [XmlEnum("204129")]
        Item204129,

        /// <remarks/>
        [XmlEnum("204130")]
        Item204130,

        /// <remarks/>
        [XmlEnum("204131")]
        Item204131,

        /// <remarks/>
        [XmlEnum("204132")]
        Item204132,

        /// <remarks/>
        [XmlEnum("204133")]
        Item204133,

        /// <remarks/>
        [XmlEnum("204134")]
        Item204134,

        /// <remarks/>
        [XmlEnum("204135")]
        Item204135,

        /// <remarks/>
        [XmlEnum("204136")]
        Item204136,

        /// <remarks/>
        [XmlEnum("204137")]
        Item204137,

        /// <remarks/>
        [XmlEnum("204138")]
        Item204138,

        /// <remarks/>
        [XmlEnum("204139")]
        Item204139,

        /// <remarks/>
        [XmlEnum("204140")]
        Item204140,

        /// <remarks/>
        [XmlEnum("204141")]
        Item204141,

        /// <remarks/>
        [XmlEnum("204142")]
        Item204142,

        /// <remarks/>
        [XmlEnum("204143")]
        Item204143,

        /// <remarks/>
        [XmlEnum("204144")]
        Item204144,

        /// <remarks/>
        [XmlEnum("204145")]
        Item204145,

        /// <remarks/>
        [XmlEnum("204146")]
        Item204146,

        /// <remarks/>
        [XmlEnum("204148")]
        Item204148,

        /// <remarks/>
        [XmlEnum("204150")]
        Item204150,

        /// <remarks/>
        [XmlEnum("204151")]
        Item204151,

        /// <remarks/>
        [XmlEnum("204152")]
        Item204152,

        /// <remarks/>
        [XmlEnum("204153")]
        Item204153,

        /// <remarks/>
        [XmlEnum("204154")]
        Item204154,

        /// <remarks/>
        [XmlEnum("204155")]
        Item204155,

        /// <remarks/>
        [XmlEnum("204156")]
        Item204156,

        /// <remarks/>
        [XmlEnum("204157")]
        Item204157,

        /// <remarks/>
        [XmlEnum("204158")]
        Item204158,

        /// <remarks/>
        [XmlEnum("204159")]
        Item204159,

        /// <remarks/>
        [XmlEnum("204160")]
        Item204160,

        /// <remarks/>
        [XmlEnum("204161")]
        Item204161,

        /// <remarks/>
        [XmlEnum("204162")]
        Item204162,

        /// <remarks/>
        [XmlEnum("204163")]
        Item204163,

        /// <remarks/>
        [XmlEnum("204164")]
        Item204164,

        /// <remarks/>
        [XmlEnum("204165")]
        Item204165,

        /// <remarks/>
        [XmlEnum("204166")]
        Item204166,

        /// <remarks/>
        [XmlEnum("204167")]
        Item204167,

        /// <remarks/>
        [XmlEnum("204168")]
        Item204168,

        /// <remarks/>
        [XmlEnum("204169")]
        Item204169,

        /// <remarks/>
        [XmlEnum("204170")]
        Item204170,

        /// <remarks/>
        [XmlEnum("204171")]
        Item204171,

        /// <remarks/>
        [XmlEnum("204172")]
        Item204172,

        /// <remarks/>
        [XmlEnum("204173")]
        Item204173,

        /// <remarks/>
        [XmlEnum("204175")]
        Item204175,

        /// <remarks/>
        [XmlEnum("204176")]
        Item204176,

        /// <remarks/>
        [XmlEnum("204177")]
        Item204177,

        /// <remarks/>
        [XmlEnum("204178")]
        Item204178,

        /// <remarks/>
        [XmlEnum("204179")]
        Item204179,

        /// <remarks/>
        [XmlEnum("204180")]
        Item204180,

        /// <remarks/>
        [XmlEnum("204181")]
        Item204181,

        /// <remarks/>
        [XmlEnum("204182")]
        Item204182,

        /// <remarks/>
        [XmlEnum("204183")]
        Item204183,

        /// <remarks/>
        [XmlEnum("204184")]
        Item204184,

        /// <remarks/>
        [XmlEnum("204185")]
        Item204185,

        /// <remarks/>
        [XmlEnum("204186")]
        Item204186,

        /// <remarks/>
        [XmlEnum("204187")]
        Item204187,

        /// <remarks/>
        [XmlEnum("204188")]
        Item204188,

        /// <remarks/>
        [XmlEnum("204189")]
        Item204189,

        /// <remarks/>
        [XmlEnum("204190")]
        Item204190,

        /// <remarks/>
        [XmlEnum("204191")]
        Item204191,

        /// <remarks/>
        [XmlEnum("204192")]
        Item204192,

        /// <remarks/>
        [XmlEnum("204193")]
        Item204193,

        /// <remarks/>
        [XmlEnum("204194")]
        Item204194,

        /// <remarks/>
        [XmlEnum("204195")]
        Item204195,

        /// <remarks/>
        [XmlEnum("204196")]
        Item204196,

        /// <remarks/>
        [XmlEnum("204197")]
        Item204197,

        /// <remarks/>
        [XmlEnum("204198")]
        Item204198,

        /// <remarks/>
        [XmlEnum("204199")]
        Item204199,

        /// <remarks/>
        [XmlEnum("204200")]
        Item204200,

        /// <remarks/>
        [XmlEnum("204201")]
        Item204201,

        /// <remarks/>
        [XmlEnum("204202")]
        Item204202,

        /// <remarks/>
        [XmlEnum("204203")]
        Item204203,

        /// <remarks/>
        [XmlEnum("204204")]
        Item204204,

        /// <remarks/>
        [XmlEnum("204205")]
        Item204205,

        /// <remarks/>
        [XmlEnum("204206")]
        Item204206,

        /// <remarks/>
        [XmlEnum("204207")]
        Item204207,

        /// <remarks/>
        [XmlEnum("204208")]
        Item204208,

        /// <remarks/>
        [XmlEnum("204209")]
        Item204209,

        /// <remarks/>
        [XmlEnum("204210")]
        Item204210,

        /// <remarks/>
        [XmlEnum("205000")]
        Item205000,

        /// <remarks/>
        [XmlEnum("205001")]
        Item205001,

        /// <remarks/>
        [XmlEnum("205002")]
        Item205002,

        /// <remarks/>
        [XmlEnum("205003")]
        Item205003,

        /// <remarks/>
        [XmlEnum("205004")]
        Item205004,

        /// <remarks/>
        [XmlEnum("205005")]
        Item205005,

        /// <remarks/>
        [XmlEnum("205006")]
        Item205006,

        /// <remarks/>
        [XmlEnum("205007")]
        Item205007,

        /// <remarks/>
        [XmlEnum("205008")]
        Item205008,

        /// <remarks/>
        [XmlEnum("205009")]
        Item205009,

        /// <remarks/>
        [XmlEnum("205010")]
        Item205010,

        /// <remarks/>
        [XmlEnum("205011")]
        Item205011,

        /// <remarks/>
        [XmlEnum("205012")]
        Item205012,

        /// <remarks/>
        [XmlEnum("205013")]
        Item205013,

        /// <remarks/>
        [XmlEnum("205014")]
        Item205014,

        /// <remarks/>
        [XmlEnum("205015")]
        Item205015,

        /// <remarks/>
        [XmlEnum("205016")]
        Item205016,

        /// <remarks/>
        [XmlEnum("205017")]
        Item205017,

        /// <remarks/>
        [XmlEnum("205018")]
        Item205018,

        /// <remarks/>
        [XmlEnum("205019")]
        Item205019,

        /// <remarks/>
        [XmlEnum("205020")]
        Item205020,

        /// <remarks/>
        [XmlEnum("205021")]
        Item205021,

        /// <remarks/>
        [XmlEnum("205022")]
        Item205022,

        /// <remarks/>
        [XmlEnum("205023")]
        Item205023,

        /// <remarks/>
        [XmlEnum("205025")]
        Item205025,

        /// <remarks/>
        [XmlEnum("205027")]
        Item205027,

        /// <remarks/>
        [XmlEnum("205028")]
        Item205028,

        /// <remarks/>
        [XmlEnum("205029")]
        Item205029,

        /// <remarks/>
        [XmlEnum("205030")]
        Item205030,

        /// <remarks/>
        [XmlEnum("205031")]
        Item205031,

        /// <remarks/>
        [XmlEnum("205032")]
        Item205032,

        /// <remarks/>
        [XmlEnum("205033")]
        Item205033,

        /// <remarks/>
        [XmlEnum("205034")]
        Item205034,

        /// <remarks/>
        [XmlEnum("205035")]
        Item205035,

        /// <remarks/>
        [XmlEnum("205036")]
        Item205036,

        /// <remarks/>
        [XmlEnum("205037")]
        Item205037,

        /// <remarks/>
        [XmlEnum("205038")]
        Item205038,

        /// <remarks/>
        [XmlEnum("205039")]
        Item205039,

        /// <remarks/>
        [XmlEnum("205040")]
        Item205040,

        /// <remarks/>
        [XmlEnum("205041")]
        Item205041,

        /// <remarks/>
        [XmlEnum("205042")]
        Item205042,

        /// <remarks/>
        [XmlEnum("205043")]
        Item205043,

        /// <remarks/>
        [XmlEnum("205044")]
        Item205044,

        /// <remarks/>
        [XmlEnum("205045")]
        Item205045,

        /// <remarks/>
        [XmlEnum("205046")]
        Item205046,

        /// <remarks/>
        [XmlEnum("205047")]
        Item205047,

        /// <remarks/>
        [XmlEnum("205048")]
        Item205048,

        /// <remarks/>
        [XmlEnum("205049")]
        Item205049,

        /// <remarks/>
        [XmlEnum("205050")]
        Item205050,

        /// <remarks/>
        [XmlEnum("205051")]
        Item205051,

        /// <remarks/>
        [XmlEnum("205052")]
        Item205052,

        /// <remarks/>
        [XmlEnum("205053")]
        Item205053,

        /// <remarks/>
        [XmlEnum("205054")]
        Item205054,

        /// <remarks/>
        [XmlEnum("205055")]
        Item205055,

        /// <remarks/>
        [XmlEnum("205056")]
        Item205056,

        /// <remarks/>
        [XmlEnum("205057")]
        Item205057,

        /// <remarks/>
        [XmlEnum("205058")]
        Item205058,

        /// <remarks/>
        [XmlEnum("205059")]
        Item205059,

        /// <remarks/>
        [XmlEnum("205060")]
        Item205060,

        /// <remarks/>
        [XmlEnum("205061")]
        Item205061,

        /// <remarks/>
        [XmlEnum("205062")]
        Item205062,

        /// <remarks/>
        [XmlEnum("206000")]
        Item206000,

        /// <remarks/>
        [XmlEnum("206001")]
        Item206001,

        /// <remarks/>
        [XmlEnum("206002")]
        Item206002,

        /// <remarks/>
        [XmlEnum("206003")]
        Item206003,

        /// <remarks/>
        [XmlEnum("206004")]
        Item206004,

        /// <remarks/>
        [XmlEnum("206005")]
        Item206005,

        /// <remarks/>
        [XmlEnum("206006")]
        Item206006,

        /// <remarks/>
        [XmlEnum("206007")]
        Item206007,

        /// <remarks/>
        [XmlEnum("206008")]
        Item206008,

        /// <remarks/>
        [XmlEnum("206009")]
        Item206009,

        /// <remarks/>
        [XmlEnum("206010")]
        Item206010,

        /// <remarks/>
        [XmlEnum("206011")]
        Item206011,

        /// <remarks/>
        [XmlEnum("206012")]
        Item206012,

        /// <remarks/>
        [XmlEnum("206013")]
        Item206013,

        /// <remarks/>
        [XmlEnum("206014")]
        Item206014,

        /// <remarks/>
        [XmlEnum("206015")]
        Item206015,

        /// <remarks/>
        [XmlEnum("206016")]
        Item206016,

        /// <remarks/>
        [XmlEnum("206017")]
        Item206017,

        /// <remarks/>
        [XmlEnum("206018")]
        Item206018,

        /// <remarks/>
        [XmlEnum("206019")]
        Item206019,

        /// <remarks/>
        [XmlEnum("206020")]
        Item206020,

        /// <remarks/>
        [XmlEnum("206021")]
        Item206021,

        /// <remarks/>
        [XmlEnum("206023")]
        Item206023,

        /// <remarks/>
        [XmlEnum("206025")]
        Item206025,

        /// <remarks/>
        [XmlEnum("206026")]
        Item206026,

        /// <remarks/>
        [XmlEnum("206027")]
        Item206027,

        /// <remarks/>
        [XmlEnum("206028")]
        Item206028,

        /// <remarks/>
        [XmlEnum("206029")]
        Item206029,

        /// <remarks/>
        [XmlEnum("206030")]
        Item206030,

        /// <remarks/>
        [XmlEnum("206031")]
        Item206031,

        /// <remarks/>
        [XmlEnum("206032")]
        Item206032,

        /// <remarks/>
        [XmlEnum("206033")]
        Item206033,

        /// <remarks/>
        [XmlEnum("206034")]
        Item206034,

        /// <remarks/>
        [XmlEnum("206035")]
        Item206035,

        /// <remarks/>
        [XmlEnum("206036")]
        Item206036,

        /// <remarks/>
        [XmlEnum("206037")]
        Item206037,

        /// <remarks/>
        [XmlEnum("206038")]
        Item206038,

        /// <remarks/>
        [XmlEnum("206039")]
        Item206039,

        /// <remarks/>
        [XmlEnum("206040")]
        Item206040,

        /// <remarks/>
        [XmlEnum("206041")]
        Item206041,

        /// <remarks/>
        [XmlEnum("206042")]
        Item206042,

        /// <remarks/>
        [XmlEnum("206043")]
        Item206043,

        /// <remarks/>
        [XmlEnum("206044")]
        Item206044,

        /// <remarks/>
        [XmlEnum("206045")]
        Item206045,

        /// <remarks/>
        [XmlEnum("206046")]
        Item206046,

        /// <remarks/>
        [XmlEnum("206047")]
        Item206047,

        /// <remarks/>
        [XmlEnum("206048")]
        Item206048,

        /// <remarks/>
        [XmlEnum("206049")]
        Item206049,

        /// <remarks/>
        [XmlEnum("206050")]
        Item206050,

        /// <remarks/>
        [XmlEnum("206051")]
        Item206051,

        /// <remarks/>
        [XmlEnum("207000")]
        Item207000,

        /// <remarks/>
        [XmlEnum("207001")]
        Item207001,

        /// <remarks/>
        [XmlEnum("207002")]
        Item207002,

        /// <remarks/>
        [XmlEnum("207003")]
        Item207003,

        /// <remarks/>
        [XmlEnum("207004")]
        Item207004,

        /// <remarks/>
        [XmlEnum("207005")]
        Item207005,

        /// <remarks/>
        [XmlEnum("207006")]
        Item207006,

        /// <remarks/>
        [XmlEnum("207007")]
        Item207007,

        /// <remarks/>
        [XmlEnum("207008")]
        Item207008,

        /// <remarks/>
        [XmlEnum("207009")]
        Item207009,

        /// <remarks/>
        [XmlEnum("207010")]
        Item207010,

        /// <remarks/>
        [XmlEnum("207011")]
        Item207011,

        /// <remarks/>
        [XmlEnum("207012")]
        Item207012,

        /// <remarks/>
        [XmlEnum("207013")]
        Item207013,

        /// <remarks/>
        [XmlEnum("207014")]
        Item207014,

        /// <remarks/>
        [XmlEnum("207015")]
        Item207015,

        /// <remarks/>
        [XmlEnum("207016")]
        Item207016,

        /// <remarks/>
        [XmlEnum("207017")]
        Item207017,

        /// <remarks/>
        [XmlEnum("207018")]
        Item207018,

        /// <remarks/>
        [XmlEnum("207019")]
        Item207019,

        /// <remarks/>
        [XmlEnum("207020")]
        Item207020,

        /// <remarks/>
        [XmlEnum("207022")]
        Item207022,

        /// <remarks/>
        [XmlEnum("207023")]
        Item207023,

        /// <remarks/>
        [XmlEnum("207024")]
        Item207024,

        /// <remarks/>
        [XmlEnum("207025")]
        Item207025,

        /// <remarks/>
        [XmlEnum("207026")]
        Item207026,

        /// <remarks/>
        [XmlEnum("207027")]
        Item207027,

        /// <remarks/>
        [XmlEnum("207028")]
        Item207028,

        /// <remarks/>
        [XmlEnum("207029")]
        Item207029,

        /// <remarks/>
        [XmlEnum("207030")]
        Item207030,

        /// <remarks/>
        [XmlEnum("207032")]
        Item207032,

        /// <remarks/>
        [XmlEnum("207033")]
        Item207033,

        /// <remarks/>
        [XmlEnum("207034")]
        Item207034,

        /// <remarks/>
        [XmlEnum("207035")]
        Item207035,

        /// <remarks/>
        [XmlEnum("207036")]
        Item207036,

        /// <remarks/>
        [XmlEnum("207037")]
        Item207037,

        /// <remarks/>
        [XmlEnum("207038")]
        Item207038,

        /// <remarks/>
        [XmlEnum("207039")]
        Item207039,

        /// <remarks/>
        [XmlEnum("207040")]
        Item207040,

        /// <remarks/>
        [XmlEnum("207041")]
        Item207041,

        /// <remarks/>
        [XmlEnum("207042")]
        Item207042,

        /// <remarks/>
        [XmlEnum("207043")]
        Item207043,

        /// <remarks/>
        [XmlEnum("207044")]
        Item207044,

        /// <remarks/>
        [XmlEnum("207045")]
        Item207045,

        /// <remarks/>
        [XmlEnum("207046")]
        Item207046,

        /// <remarks/>
        [XmlEnum("207047")]
        Item207047,

        /// <remarks/>
        [XmlEnum("207048")]
        Item207048,

        /// <remarks/>
        [XmlEnum("207049")]
        Item207049,

        /// <remarks/>
        [XmlEnum("207050")]
        Item207050,

        /// <remarks/>
        [XmlEnum("207051")]
        Item207051,

        /// <remarks/>
        [XmlEnum("207052")]
        Item207052,

        /// <remarks/>
        [XmlEnum("207053")]
        Item207053,

        /// <remarks/>
        [XmlEnum("207054")]
        Item207054,

        /// <remarks/>
        [XmlEnum("207055")]
        Item207055,

        /// <remarks/>
        [XmlEnum("207056")]
        Item207056,

        /// <remarks/>
        [XmlEnum("207057")]
        Item207057,

        /// <remarks/>
        [XmlEnum("207058")]
        Item207058,

        /// <remarks/>
        [XmlEnum("207059")]
        Item207059,

        /// <remarks/>
        [XmlEnum("207060")]
        Item207060,

        /// <remarks/>
        [XmlEnum("208000")]
        Item208000,

        /// <remarks/>
        [XmlEnum("208001")]
        Item208001,

        /// <remarks/>
        [XmlEnum("208002")]
        Item208002,

        /// <remarks/>
        [XmlEnum("208003")]
        Item208003,

        /// <remarks/>
        [XmlEnum("208004")]
        Item208004,

        /// <remarks/>
        [XmlEnum("208005")]
        Item208005,

        /// <remarks/>
        [XmlEnum("208006")]
        Item208006,

        /// <remarks/>
        [XmlEnum("208007")]
        Item208007,

        /// <remarks/>
        [XmlEnum("208008")]
        Item208008,

        /// <remarks/>
        [XmlEnum("208009")]
        Item208009,

        /// <remarks/>
        [XmlEnum("208010")]
        Item208010,

        /// <remarks/>
        [XmlEnum("208011")]
        Item208011,

        /// <remarks/>
        [XmlEnum("208012")]
        Item208012,

        /// <remarks/>
        [XmlEnum("208013")]
        Item208013,

        /// <remarks/>
        [XmlEnum("208014")]
        Item208014,

        /// <remarks/>
        [XmlEnum("208015")]
        Item208015,

        /// <remarks/>
        [XmlEnum("208016")]
        Item208016,

        /// <remarks/>
        [XmlEnum("208017")]
        Item208017,

        /// <remarks/>
        [XmlEnum("208018")]
        Item208018,

        /// <remarks/>
        [XmlEnum("208019")]
        Item208019,

        /// <remarks/>
        [XmlEnum("208020")]
        Item208020,

        /// <remarks/>
        [XmlEnum("208021")]
        Item208021,

        /// <remarks/>
        [XmlEnum("208022")]
        Item208022,

        /// <remarks/>
        [XmlEnum("208023")]
        Item208023,

        /// <remarks/>
        [XmlEnum("208024")]
        Item208024,

        /// <remarks/>
        [XmlEnum("208025")]
        Item208025,

        /// <remarks/>
        [XmlEnum("208026")]
        Item208026,

        /// <remarks/>
        [XmlEnum("208027")]
        Item208027,

        /// <remarks/>
        [XmlEnum("208028")]
        Item208028,

        /// <remarks/>
        [XmlEnum("208030")]
        Item208030,

        /// <remarks/>
        [XmlEnum("208030")]
        Item2080301,

        /// <remarks/>
        [XmlEnum("208030")]
        Item2080302,

        /// <remarks/>
        [XmlEnum("208030")]
        Item2080303,

        /// <remarks/>
        [XmlEnum("208031")]
        Item208031,

        /// <remarks/>
        [XmlEnum("208032")]
        Item208032,

        /// <remarks/>
        [XmlEnum("208034")]
        Item208034,

        /// <remarks/>
        [XmlEnum("208035")]
        Item208035,

        /// <remarks/>
        [XmlEnum("208036")]
        Item208036,

        /// <remarks/>
        [XmlEnum("208037")]
        Item208037,

        /// <remarks/>
        [XmlEnum("208038")]
        Item208038,

        /// <remarks/>
        [XmlEnum("208039")]
        Item208039,

        /// <remarks/>
        [XmlEnum("208040")]
        Item208040,

        /// <remarks/>
        [XmlEnum("208041")]
        Item208041,

        /// <remarks/>
        [XmlEnum("208042")]
        Item208042,

        /// <remarks/>
        [XmlEnum("208043")]
        Item208043,

        /// <remarks/>
        [XmlEnum("208044")]
        Item208044,

        /// <remarks/>
        [XmlEnum("208045")]
        Item208045,

        /// <remarks/>
        [XmlEnum("208046")]
        Item208046,

        /// <remarks/>
        [XmlEnum("208047")]
        Item208047,

        /// <remarks/>
        [XmlEnum("208048")]
        Item208048,

        /// <remarks/>
        [XmlEnum("208049")]
        Item208049,

        /// <remarks/>
        [XmlEnum("209000")]
        Item209000,

        /// <remarks/>
        [XmlEnum("209001")]
        Item209001,

        /// <remarks/>
        [XmlEnum("209002")]
        Item209002,

        /// <remarks/>
        [XmlEnum("209003")]
        Item209003,

        /// <remarks/>
        [XmlEnum("209004")]
        Item209004,

        /// <remarks/>
        [XmlEnum("209005")]
        Item209005,

        /// <remarks/>
        [XmlEnum("209006")]
        Item209006,

        /// <remarks/>
        [XmlEnum("209007")]
        Item209007,

        /// <remarks/>
        [XmlEnum("209008")]
        Item209008,

        /// <remarks/>
        [XmlEnum("209009")]
        Item209009,

        /// <remarks/>
        [XmlEnum("209010")]
        Item209010,

        /// <remarks/>
        [XmlEnum("209011")]
        Item209011,

        /// <remarks/>
        [XmlEnum("209012")]
        Item209012,

        /// <remarks/>
        [XmlEnum("209013")]
        Item209013,

        /// <remarks/>
        [XmlEnum("209014")]
        Item209014,

        /// <remarks/>
        [XmlEnum("209015")]
        Item209015,

        /// <remarks/>
        [XmlEnum("209032")]
        Item209032,

        /// <remarks/>
        [XmlEnum("209033")]
        Item209033,

        /// <remarks/>
        [XmlEnum("209034")]
        Item209034,

        /// <remarks/>
        [XmlEnum("209058")]
        Item209058,

        /// <remarks/>
        [XmlEnum("209060")]
        Item209060,

        /// <remarks/>
        [XmlEnum("209061")]
        Item209061,

        /// <remarks/>
        [XmlEnum("209062")]
        Item209062,

        /// <remarks/>
        [XmlEnum("210000")]
        Item210000,

        /// <remarks/>
        [XmlEnum("210001")]
        Item210001,

        /// <remarks/>
        [XmlEnum("210002")]
        Item210002,

        /// <remarks/>
        [XmlEnum("210003")]
        Item210003,

        /// <remarks/>
        [XmlEnum("210004")]
        Item210004,

        /// <remarks/>
        [XmlEnum("210005")]
        Item210005,

        /// <remarks/>
        [XmlEnum("210006")]
        Item210006,

        /// <remarks/>
        [XmlEnum("210007")]
        Item210007,

        /// <remarks/>
        [XmlEnum("210008")]
        Item210008,

        /// <remarks/>
        [XmlEnum("210009")]
        Item210009,

        /// <remarks/>
        [XmlEnum("210010")]
        Item210010,

        /// <remarks/>
        [XmlEnum("210011")]
        Item210011,

        /// <remarks/>
        [XmlEnum("210012")]
        Item210012,

        /// <remarks/>
        [XmlEnum("210013")]
        Item210013,

        /// <remarks/>
        [XmlEnum("210014")]
        Item210014,

        /// <remarks/>
        [XmlEnum("210015")]
        Item210015,

        /// <remarks/>
        [XmlEnum("210016")]
        Item210016,

        /// <remarks/>
        [XmlEnum("210017")]
        Item210017,

        /// <remarks/>
        [XmlEnum("210018")]
        Item210018,

        /// <remarks/>
        [XmlEnum("210019")]
        Item210019,

        /// <remarks/>
        [XmlEnum("210020")]
        Item210020,

        /// <remarks/>
        [XmlEnum("210021")]
        Item210021,

        /// <remarks/>
        [XmlEnum("210022")]
        Item210022,

        /// <remarks/>
        [XmlEnum("210023")]
        Item210023,

        /// <remarks/>
        [XmlEnum("210024")]
        Item210024,

        /// <remarks/>
        [XmlEnum("210025")]
        Item210025,

        /// <remarks/>
        [XmlEnum("210026")]
        Item210026,

        /// <remarks/>
        [XmlEnum("210027")]
        Item210027,

        /// <remarks/>
        [XmlEnum("210028")]
        Item210028,

        /// <remarks/>
        [XmlEnum("210029")]
        Item210029,

        /// <remarks/>
        [XmlEnum("210030")]
        Item210030,

        /// <remarks/>
        [XmlEnum("210031")]
        Item210031,

        /// <remarks/>
        [XmlEnum("210032")]
        Item210032,

        /// <remarks/>
        [XmlEnum("210033")]
        Item210033,

        /// <remarks/>
        [XmlEnum("210034")]
        Item210034,

        /// <remarks/>
        [XmlEnum("210035")]
        Item210035,

        /// <remarks/>
        [XmlEnum("210036")]
        Item210036,

        /// <remarks/>
        [XmlEnum("210037")]
        Item210037,

        /// <remarks/>
        [XmlEnum("210038")]
        Item210038,

        /// <remarks/>
        [XmlEnum("210039")]
        Item210039,

        /// <remarks/>
        [XmlEnum("210040")]
        Item210040,

        /// <remarks/>
        [XmlEnum("210041")]
        Item210041,

        /// <remarks/>
        [XmlEnum("210041")]
        Item2100411,

        /// <remarks/>
        [XmlEnum("210041")]
        Item2100412,

        /// <remarks/>
        [XmlEnum("210041")]
        Item2100413,

        /// <remarks/>
        [XmlEnum("210041")]
        Item2100414,

        /// <remarks/>
        [XmlEnum("210042")]
        Item210042,

        /// <remarks/>
        [XmlEnum("210043")]
        Item210043,

        /// <remarks/>
        [XmlEnum("210044")]
        Item210044,

        /// <remarks/>
        [XmlEnum("210045")]
        Item210045,

        /// <remarks/>
        [XmlEnum("210046")]
        Item210046,

        /// <remarks/>
        [XmlEnum("210047")]
        Item210047,

        /// <remarks/>
        [XmlEnum("210048")]
        Item210048,

        /// <remarks/>
        [XmlEnum("210049")]
        Item210049,

        /// <remarks/>
        [XmlEnum("210050")]
        Item210050,

        /// <remarks/>
        [XmlEnum("210051")]
        Item210051,

        /// <remarks/>
        [XmlEnum("210052")]
        Item210052,

        /// <remarks/>
        [XmlEnum("210053")]
        Item210053,

        /// <remarks/>
        [XmlEnum("210054")]
        Item210054,

        /// <remarks/>
        [XmlEnum("210055")]
        Item210055,

        /// <remarks/>
        [XmlEnum("210056")]
        Item210056,

        /// <remarks/>
        [XmlEnum("210057")]
        Item210057,

        /// <remarks/>
        [XmlEnum("210058")]
        Item210058,

        /// <remarks/>
        [XmlEnum("210059")]
        Item210059,

        /// <remarks/>
        [XmlEnum("210060")]
        Item210060,

        /// <remarks/>
        [XmlEnum("211000")]
        Item211000,

        /// <remarks/>
        [XmlEnum("211001")]
        Item211001,

        /// <remarks/>
        [XmlEnum("211002")]
        Item211002,

        /// <remarks/>
        [XmlEnum("211003")]
        Item211003,

        /// <remarks/>
        [XmlEnum("211004")]
        Item211004,

        /// <remarks/>
        [XmlEnum("211005")]
        Item211005,

        /// <remarks/>
        [XmlEnum("211006")]
        Item211006,

        /// <remarks/>
        [XmlEnum("211007")]
        Item211007,

        /// <remarks/>
        [XmlEnum("211008")]
        Item211008,

        /// <remarks/>
        [XmlEnum("211009")]
        Item211009,

        /// <remarks/>
        [XmlEnum("211010")]
        Item211010,

        /// <remarks/>
        [XmlEnum("211011")]
        Item211011,

        /// <remarks/>
        [XmlEnum("211012")]
        Item211012,

        /// <remarks/>
        [XmlEnum("211013")]
        Item211013,

        /// <remarks/>
        [XmlEnum("211014")]
        Item211014,

        /// <remarks/>
        [XmlEnum("211015")]
        Item211015,

        /// <remarks/>
        [XmlEnum("211016")]
        Item211016,

        /// <remarks/>
        [XmlEnum("211017")]
        Item211017,

        /// <remarks/>
        [XmlEnum("211018")]
        Item211018,

        /// <remarks/>
        [XmlEnum("211019")]
        Item211019,

        /// <remarks/>
        [XmlEnum("211020")]
        Item211020,

        /// <remarks/>
        [XmlEnum("211021")]
        Item211021,

        /// <remarks/>
        [XmlEnum("211022")]
        Item211022,

        /// <remarks/>
        [XmlEnum("211023")]
        Item211023,

        /// <remarks/>
        [XmlEnum("211024")]
        Item211024,

        /// <remarks/>
        [XmlEnum("211025")]
        Item211025,

        /// <remarks/>
        [XmlEnum("211026")]
        Item211026,

        /// <remarks/>
        [XmlEnum("211027")]
        Item211027,

        /// <remarks/>
        [XmlEnum("211028")]
        Item211028,

        /// <remarks/>
        [XmlEnum("211029")]
        Item211029,

        /// <remarks/>
        [XmlEnum("211030")]
        Item211030,

        /// <remarks/>
        [XmlEnum("211031")]
        Item211031,

        /// <remarks/>
        [XmlEnum("211032")]
        Item211032,

        /// <remarks/>
        [XmlEnum("211033")]
        Item211033,

        /// <remarks/>
        [XmlEnum("211034")]
        Item211034,

        /// <remarks/>
        [XmlEnum("211035")]
        Item211035,

        /// <remarks/>
        [XmlEnum("211036")]
        Item211036,

        /// <remarks/>
        [XmlEnum("211037")]
        Item211037,

        /// <remarks/>
        [XmlEnum("211038")]
        Item211038,

        /// <remarks/>
        [XmlEnum("211039")]
        Item211039,

        /// <remarks/>
        [XmlEnum("211040")]
        Item211040,

        /// <remarks/>
        [XmlEnum("211041")]
        Item211041,

        /// <remarks/>
        [XmlEnum("211042")]
        Item211042,

        /// <remarks/>
        [XmlEnum("211043")]
        Item211043,

        /// <remarks/>
        [XmlEnum("211044")]
        Item211044,

        /// <remarks/>
        [XmlEnum("212000")]
        Item212000,

        /// <remarks/>
        [XmlEnum("212001")]
        Item212001,

        /// <remarks/>
        [XmlEnum("212002")]
        Item212002,

        /// <remarks/>
        [XmlEnum("212003")]
        Item212003,

        /// <remarks/>
        [XmlEnum("212004")]
        Item212004,

        /// <remarks/>
        [XmlEnum("213000")]
        Item213000,

        /// <remarks/>
        [XmlEnum("213001")]
        Item213001,

        /// <remarks/>
        [XmlEnum("213002")]
        Item213002,

        /// <remarks/>
        [XmlEnum("213003")]
        Item213003,

        /// <remarks/>
        [XmlEnum("213004")]
        Item213004,

        /// <remarks/>
        [XmlEnum("213005")]
        Item213005,

        /// <remarks/>
        [XmlEnum("214000")]
        Item214000,

        /// <remarks/>
        [XmlEnum("214001")]
        Item214001,

        /// <remarks/>
        [XmlEnum("214002")]
        Item214002,

        /// <remarks/>
        [XmlEnum("214003")]
        Item214003,

        /// <remarks/>
        [XmlEnum("214004")]
        Item214004,

        /// <remarks/>
        [XmlEnum("214004")]
        Item2140041,

        /// <remarks/>
        [XmlEnum("214004")]
        Item2140042,

        /// <remarks/>
        [XmlEnum("215000")]
        Item215000,

        /// <remarks/>
        [XmlEnum("215001")]
        Item215001,

        /// <remarks/>
        [XmlEnum("215002")]
        Item215002,

        /// <remarks/>
        [XmlEnum("215002")]
        Item2150021,

        /// <remarks/>
        [XmlEnum("215004")]
        Item215004,

        /// <remarks/>
        [XmlEnum("215005")]
        Item215005,

        /// <remarks/>
        [XmlEnum("215005")]
        Item2150051,

        /// <remarks/>
        [XmlEnum("215005")]
        Item2150052,

        /// <remarks/>
        [XmlEnum("215005")]
        Item2150053,

        /// <remarks/>
        [XmlEnum("215006")]
        Item215006,

        /// <remarks/>
        [XmlEnum("215007")]
        Item215007,

        /// <remarks/>
        [XmlEnum("215008")]
        Item215008,

        /// <remarks/>
        [XmlEnum("215009")]
        Item215009,

        /// <remarks/>
        [XmlEnum("215010")]
        Item215010,

        /// <remarks/>
        [XmlEnum("215011")]
        Item215011,

        /// <remarks/>
        [XmlEnum("216000")]
        Item216000,

        /// <remarks/>
        [XmlEnum("216001")]
        Item216001,

        /// <remarks/>
        [XmlEnum("216002")]
        Item216002,

        /// <remarks/>
        [XmlEnum("216003")]
        Item216003,

        /// <remarks/>
        [XmlEnum("216004")]
        Item216004,

        /// <remarks/>
        [XmlEnum("216005")]
        Item216005,

        /// <remarks/>
        [XmlEnum("216006")]
        Item216006,

        /// <remarks/>
        [XmlEnum("216007")]
        Item216007,

        /// <remarks/>
        [XmlEnum("216008")]
        Item216008,

        /// <remarks/>
        [XmlEnum("216009")]
        Item216009,

        /// <remarks/>
        [XmlEnum("216010")]
        Item216010,

        /// <remarks/>
        [XmlEnum("216011")]
        Item216011,

        /// <remarks/>
        [XmlEnum("216012")]
        Item216012,

        /// <remarks/>
        [XmlEnum("216013")]
        Item216013,

        /// <remarks/>
        [XmlEnum("216014")]
        Item216014,

        /// <remarks/>
        [XmlEnum("216015")]
        Item216015,

        /// <remarks/>
        [XmlEnum("216016")]
        Item216016,

        /// <remarks/>
        [XmlEnum("216016")]
        Item2160161,

        /// <remarks/>
        [XmlEnum("216016")]
        Item2160162,

        /// <remarks/>
        [XmlEnum("216016")]
        Item2160163,

        /// <remarks/>
        [XmlEnum("216017")]
        Item216017,

        /// <remarks/>
        [XmlEnum("216019")]
        Item216019,

        /// <remarks/>
        [XmlEnum("216020")]
        Item216020,

        /// <remarks/>
        [XmlEnum("216021")]
        Item216021,

        /// <remarks/>
        [XmlEnum("216022")]
        Item216022,

        /// <remarks/>
        [XmlEnum("216023")]
        Item216023,

        /// <remarks/>
        [XmlEnum("216024")]
        Item216024,

        /// <remarks/>
        [XmlEnum("216025")]
        Item216025,

        /// <remarks/>
        [XmlEnum("216026")]
        Item216026,

        /// <remarks/>
        [XmlEnum("216027")]
        Item216027,

        /// <remarks/>
        [XmlEnum("216028")]
        Item216028,

        /// <remarks/>
        [XmlEnum("216029")]
        Item216029,

        /// <remarks/>
        [XmlEnum("216030")]
        Item216030,

        /// <remarks/>
        [XmlEnum("216031")]
        Item216031,

        /// <remarks/>
        [XmlEnum("216031")]
        Item2160311,

        /// <remarks/>
        [XmlEnum("216031")]
        Item2160312,

        /// <remarks/>
        [XmlEnum("216032")]
        Item216032,

        /// <remarks/>
        [XmlEnum("216033")]
        Item216033,

        /// <remarks/>
        [XmlEnum("216034")]
        Item216034,

        /// <remarks/>
        [XmlEnum("216035")]
        Item216035,

        /// <remarks/>
        [XmlEnum("216036")]
        Item216036,

        /// <remarks/>
        [XmlEnum("216037")]
        Item216037,

        /// <remarks/>
        [XmlEnum("216038")]
        Item216038,

        /// <remarks/>
        [XmlEnum("216039")]
        Item216039,

        /// <remarks/>
        [XmlEnum("216040")]
        Item216040,

        /// <remarks/>
        [XmlEnum("216041")]
        Item216041,

        /// <remarks/>
        [XmlEnum("216042")]
        Item216042,

        /// <remarks/>
        [XmlEnum("216044")]
        Item216044,

        /// <remarks/>
        [XmlEnum("216045")]
        Item216045,

        /// <remarks/>
        [XmlEnum("216046")]
        Item216046,

        /// <remarks/>
        [XmlEnum("216047")]
        Item216047,

        /// <remarks/>
        [XmlEnum("216048")]
        Item216048,

        /// <remarks/>
        [XmlEnum("216049")]
        Item216049,

        /// <remarks/>
        [XmlEnum("216050")]
        Item216050,

        /// <remarks/>
        [XmlEnum("216051")]
        Item216051,

        /// <remarks/>
        [XmlEnum("216052")]
        Item216052,

        /// <remarks/>
        [XmlEnum("216053")]
        Item216053,

        /// <remarks/>
        [XmlEnum("216054")]
        Item216054,

        /// <remarks/>
        [XmlEnum("216055")]
        Item216055,

        /// <remarks/>
        [XmlEnum("216056")]
        Item216056,

        /// <remarks/>
        [XmlEnum("216057")]
        Item216057,

        /// <remarks/>
        [XmlEnum("216058")]
        Item216058,

        /// <remarks/>
        [XmlEnum("216059")]
        Item216059,

        /// <remarks/>
        [XmlEnum("216060")]
        Item216060,

        /// <remarks/>
        [XmlEnum("216061")]
        Item216061,

        /// <remarks/>
        [XmlEnum("216062")]
        Item216062,

        /// <remarks/>
        [XmlEnum("216063")]
        Item216063,

        /// <remarks/>
        [XmlEnum("216064")]
        Item216064,

        /// <remarks/>
        [XmlEnum("216065")]
        Item216065,

        /// <remarks/>
        [XmlEnum("216066")]
        Item216066,

        /// <remarks/>
        [XmlEnum("216067")]
        Item216067,

        /// <remarks/>
        [XmlEnum("216068")]
        Item216068,

        /// <remarks/>
        [XmlEnum("216069")]
        Item216069,

        /// <remarks/>
        [XmlEnum("216070")]
        Item216070,

        /// <remarks/>
        [XmlEnum("216071")]
        Item216071,

        /// <remarks/>
        [XmlEnum("216072")]
        Item216072,

        /// <remarks/>
        [XmlEnum("216073")]
        Item216073,

        /// <remarks/>
        [XmlEnum("216074")]
        Item216074,

        /// <remarks/>
        [XmlEnum("216075")]
        Item216075,

        /// <remarks/>
        [XmlEnum("216076")]
        Item216076,

        /// <remarks/>
        [XmlEnum("216077")]
        Item216077,

        /// <remarks/>
        [XmlEnum("216078")]
        Item216078,

        /// <remarks/>
        [XmlEnum("216079")]
        Item216079,

        /// <remarks/>
        [XmlEnum("216080")]
        Item216080,

        /// <remarks/>
        [XmlEnum("216081")]
        Item216081,

        /// <remarks/>
        [XmlEnum("216082")]
        Item216082,

        /// <remarks/>
        [XmlEnum("216083")]
        Item216083,

        /// <remarks/>
        [XmlEnum("216084")]
        Item216084,

        /// <remarks/>
        [XmlEnum("216085")]
        Item216085,

        /// <remarks/>
        [XmlEnum("216086")]
        Item216086,

        /// <remarks/>
        [XmlEnum("300000")]
        Item300000,

        /// <remarks/>
        [XmlEnum("300999")]
        Item300999,

        /// <remarks/>
        [XmlEnum("301000")]
        Item301000,

        /// <remarks/>
        [XmlEnum("301001")]
        Item301001,

        /// <remarks/>
        [XmlEnum("301001")]
        Item3010011,

        /// <remarks/>
        [XmlEnum("301001")]
        Item3010012,

        /// <remarks/>
        [XmlEnum("301002")]
        Item301002,

        /// <remarks/>
        [XmlEnum("301002")]
        Item3010021,

        /// <remarks/>
        [XmlEnum("301002")]
        Item3010022,

        /// <remarks/>
        [XmlEnum("301002")]
        Item3010023,

        /// <remarks/>
        [XmlEnum("301003")]
        Item301003,

        /// <remarks/>
        [XmlEnum("301004")]
        Item301004,

        /// <remarks/>
        [XmlEnum("301005")]
        Item301005,

        /// <remarks/>
        [XmlEnum("301006")]
        Item301006,

        /// <remarks/>
        [XmlEnum("301007")]
        Item301007,

        /// <remarks/>
        [XmlEnum("301008")]
        Item301008,

        /// <remarks/>
        [XmlEnum("301009")]
        Item301009,

        /// <remarks/>
        [XmlEnum("301010")]
        Item301010,

        /// <remarks/>
        [XmlEnum("301011")]
        Item301011,

        /// <remarks/>
        [XmlEnum("301011")]
        Item3010111,

        /// <remarks/>
        [XmlEnum("301011")]
        Item3010112,

        /// <remarks/>
        [XmlEnum("301011")]
        Item3010113,

        [XmlEnum("301012")]
        Item301012,

        [XmlEnum("301013")]
        Item301013,

        [XmlEnum("301013")]
        Item3010131,

        [XmlEnum("301014")]
        Item301014,

        [XmlEnum("301015")]
        Item301015,

        [XmlEnum("301016")]
        Item301016,

        [XmlEnum("301017")]
        Item301017,

        [XmlEnum("301018")]
        Item301018,

        [XmlEnum("301019")]
        Item301019,

        /// <remarks/>
        [XmlEnum("301020")]
        Item301020,

        /// <remarks/>
        [XmlEnum("301021")]
        Item301021,

        /// <remarks/>
        [XmlEnum("301022")]
        Item301022,

        /// <remarks/>
        [XmlEnum("301023")]
        Item301023,

        [XmlEnum("301024")]
        Item301024,

        [XmlEnum("301025")]
        Item301025,

        [XmlEnum("301026")]
        Item301026,

        [XmlEnum("301027")]
        Item301027,

        [XmlEnum("301028")]
        Item301028,

        [XmlEnum("301029")]
        Item301029,

        [XmlEnum("301030")]
        Item301030,

        [XmlEnum("301031")]
        Item301031,

        [XmlEnum("301031")]
        Item3010311,

        [XmlEnum("301032")]
        Item301032,

        [XmlEnum("301033")]
        Item301033,

        [XmlEnum("301034")]
        Item301034,

        [XmlEnum("301035")]
        Item301035,

        [XmlEnum("301036")]
        Item301036,

        [XmlEnum("301037")]
        Item301037,

        [XmlEnum("301038")]
        Item301038,

        [XmlEnum("301039")]
        Item301039,

        [XmlEnum("301040")]
        Item301040,

        [XmlEnum("301041")]
        Item301041,

        [XmlEnum("301042")]
        Item301042,

        [XmlEnum("301043")]
        Item301043,

        [XmlEnum("301044")]
        Item301044,

        [XmlEnum("301045")]
        Item301045,

        [XmlEnum("301046")]
        Item301046,

        [XmlEnum("301047")]
        Item301047,

        [XmlEnum("301048")]
        Item301048,

        [XmlEnum("301048")]
        Item3010481,

        /// <remarks/>
        [XmlEnum("301048")]
        Item3010482,

        /// <remarks/>
        [XmlEnum("301048")]
        Item3010483,

        /// <remarks/>
        [XmlEnum("301048")]
        Item3010484,

        /// <remarks/>
        [XmlEnum("301048")]
        Item3010485,

        /// <remarks/>
        [XmlEnum("301048")]
        Item3010486,

        /// <remarks/>
        [XmlEnum("301049")]
        Item301049,

        /// <remarks/>
        [XmlEnum("301050")]
        Item301050,

        /// <remarks/>
        [XmlEnum("301051")]
        Item301051,

        /// <remarks/>
        [XmlEnum("301052")]
        Item301052,

        /// <remarks/>
        [XmlEnum("301053")]
        Item301053,

        /// <remarks/>
        [XmlEnum("301054")]
        Item301054,

        /// <remarks/>
        [XmlEnum("301055")]
        Item301055,

        /// <remarks/>
        [XmlEnum("301056")]
        Item301056,

        /// <remarks/>
        [XmlEnum("301057")]
        Item301057,

        /// <remarks/>
        [XmlEnum("301058")]
        Item301058,

        /// <remarks/>
        [XmlEnum("301059")]
        Item301059,

        /// <remarks/>
        [XmlEnum("301060")]
        Item301060,

        /// <remarks/>
        [XmlEnum("301061")]
        Item301061,

        /// <remarks/>
        [XmlEnum("301062")]
        Item301062,

        /// <remarks/>
        [XmlEnum("301063")]
        Item301063,

        /// <remarks/>
        [XmlEnum("301064")]
        Item301064,

        /// <remarks/>
        [XmlEnum("301065")]
        Item301065,

        /// <remarks/>
        [XmlEnum("301066")]
        Item301066,

        /// <remarks/>
        [XmlEnum("301067")]
        Item301067,

        /// <remarks/>
        [XmlEnum("301068")]
        Item301068,

        /// <remarks/>
        [XmlEnum("301069")]
        Item301069,

        /// <remarks/>
        [XmlEnum("301070")]
        Item301070,

        /// <remarks/>
        [XmlEnum("301072")]
        Item301072,

        /// <remarks/>
        [XmlEnum("301073")]
        Item301073,

        /// <remarks/>
        [XmlEnum("301074")]
        Item301074,

        /// <remarks/>
        [XmlEnum("301075")]
        Item301075,

        /// <remarks/>
        [XmlEnum("301076")]
        Item301076,

        /// <remarks/>
        [XmlEnum("301077")]
        Item301077,

        /// <remarks/>
        [XmlEnum("301078")]
        Item301078,

        /// <remarks/>
        [XmlEnum("302000")]
        Item302000,

        /// <remarks/>
        [XmlEnum("302001")]
        Item302001,

        /// <remarks/>
        [XmlEnum("302002")]
        Item302002,

        /// <remarks/>
        [XmlEnum("302003")]
        Item302003,

        /// <remarks/>
        [XmlEnum("302004")]
        Item302004,

        /// <remarks/>
        [XmlEnum("302004")]
        Item3020041,

        /// <remarks/>
        [XmlEnum("302004")]
        Item3020042,

        /// <remarks/>
        [XmlEnum("302004")]
        Item3020043,

        /// <remarks/>
        [XmlEnum("302004")]
        Item3020044,

        /// <remarks/>
        [XmlEnum("302005")]
        Item302005,

        /// <remarks/>
        [XmlEnum("302006")]
        Item302006,

        /// <remarks/>
        [XmlEnum("302007")]
        Item302007,

        /// <remarks/>
        [XmlEnum("302008")]
        Item302008,

        /// <remarks/>
        [XmlEnum("302009")]
        Item302009,

        /// <remarks/>
        [XmlEnum("302010")]
        Item302010,

        /// <remarks/>
        [XmlEnum("302011")]
        Item302011,

        /// <remarks/>
        [XmlEnum("302012")]
        Item302012,

        /// <remarks/>
        [XmlEnum("302013")]
        Item302013,

        /// <remarks/>
        [XmlEnum("302014")]
        Item302014,

        /// <remarks/>
        [XmlEnum("302016")]
        Item302016,

        /// <remarks/>
        [XmlEnum("302017")]
        Item302017,

        /// <remarks/>
        [XmlEnum("302018")]
        Item302018,

        /// <remarks/>
        [XmlEnum("400000")]
        Item400000,

        /// <remarks/>
        [XmlEnum("400999")]
        Item400999,

        /// <remarks/>
        [XmlEnum("401000")]
        Item401000,

        /// <remarks/>
        [XmlEnum("401001")]
        Item401001,

        /// <remarks/>
        [XmlEnum("401003")]
        Item401003,

        /// <remarks/>
        [XmlEnum("401004")]
        Item401004,

        /// <remarks/>
        [XmlEnum("401005")]
        Item401005,

        /// <remarks/>
        [XmlEnum("401006")]
        Item401006,

        /// <remarks/>
        [XmlEnum("401009")]
        Item401009,

        /// <remarks/>
        [XmlEnum("401015")]
        Item401015,

        /// <remarks/>
        [XmlEnum("401015")]
        Item4010151,

        /// <remarks/>
        [XmlEnum("401016")]
        Item401016,

        /// <remarks/>
        [XmlEnum("401017")]
        Item401017,

        /// <remarks/>
        [XmlEnum("401018")]
        Item401018,

        /// <remarks/>
        [XmlEnum("402000")]
        Item402000,

        /// <remarks/>
        [XmlEnum("402001")]
        Item402001,

        /// <remarks/>
        [XmlEnum("402002")]
        Item402002,

        /// <remarks/>
        [XmlEnum("402003")]
        Item402003,

        /// <remarks/>
        [XmlEnum("402004")]
        Item402004,

        /// <remarks/>
        [XmlEnum("402005")]
        Item402005,

        /// <remarks/>
        [XmlEnum("402006")]
        Item402006,

        /// <remarks/>
        [XmlEnum("402007")]
        Item402007,

        /// <remarks/>
        [XmlEnum("500000")]
        Item500000,

        /// <remarks/>
        [XmlEnum("500999")]
        Item500999,

        /// <remarks/>
        [XmlEnum("501000")]
        Item501000,

        /// <remarks/>
        [XmlEnum("501001")]
        Item501001,

        /// <remarks/>
        [XmlEnum("501002")]
        Item501002,

        /// <remarks/>
        [XmlEnum("501003")]
        Item501003,

        /// <remarks/>
        [XmlEnum("501004")]
        Item501004,

        /// <remarks/>
        [XmlEnum("501005")]
        Item501005,

        /// <remarks/>
        [XmlEnum("501005")]
        Item5010051,

        /// <remarks/>
        [XmlEnum("501005")]
        Item5010052,

        /// <remarks/>
        [XmlEnum("501005")]
        Item5010053,

        /// <remarks/>
        [XmlEnum("501006")]
        Item501006,

        /// <remarks/>
        [XmlEnum("501006")]
        Item5010061,

        /// <remarks/>
        [XmlEnum("501006")]
        Item5010062,

        /// <remarks/>
        [XmlEnum("501006")]
        Item5010063,

        /// <remarks/>
        [XmlEnum("501007")]
        Item501007,

        /// <remarks/>
        [XmlEnum("501007")]
        Item5010071,

        /// <remarks/>
        [XmlEnum("501008")]
        Item501008,

        /// <remarks/>
        [XmlEnum("501009")]
        Item501009,

        /// <remarks/>
        [XmlEnum("501009")]
        Item5010091,

        /// <remarks/>
        [XmlEnum("501009")]
        Item5010092,

        /// <remarks/>
        [XmlEnum("501009")]
        Item5010093,

        /// <remarks/>
        [XmlEnum("502000")]
        Item502000,

        /// <remarks/>
        [XmlEnum("502001")]
        Item502001,

        /// <remarks/>
        [XmlEnum("502002")]
        Item502002,

        /// <remarks/>
        [XmlEnum("502002")]
        Item5020021,

        /// <remarks/>
        [XmlEnum("502002")]
        Item5020022,

        /// <remarks/>
        [XmlEnum("502003")]
        Item502003,

        /// <remarks/>
        [XmlEnum("502004")]
        Item502004,

        /// <remarks/>
        [XmlEnum("502005")]
        Item502005,

        /// <remarks/>
        [XmlEnum("502006")]
        Item502006,

        /// <remarks/>
        [XmlEnum("600000")]
        Item600000,

        /// <remarks/>
        [XmlEnum("600018")]
        Item600018,

        /// <remarks/>
        [XmlEnum("600926")]
        Item600926,

        /// <remarks/>
        [XmlEnum("600999")]
        Item600999,

        /// <remarks/>
        [XmlEnum("601000")]
        Item601000,

        /// <remarks/>
        [XmlEnum("601001")]
        Item601001,

        /// <remarks/>
        [XmlEnum("601002")]
        Item601002,

        /// <remarks/>
        [XmlEnum("601003")]
        Item601003,

        /// <remarks/>
        [XmlEnum("601003")]
        Item6010031,

        /// <remarks/>
        [XmlEnum("601003")]
        Item6010032,

        /// <remarks/>
        [XmlEnum("601003")]
        Item6010033,

        /// <remarks/>
        [XmlEnum("601004")]
        Item601004,

        /// <remarks/>
        [XmlEnum("601005")]
        Item601005,

        /// <remarks/>
        [XmlEnum("601006")]
        Item601006,

        /// <remarks/>
        [XmlEnum("601007")]
        Item601007,

        /// <remarks/>
        [XmlEnum("601008")]
        Item601008,

        /// <remarks/>
        [XmlEnum("602000")]
        Item602000,

        /// <remarks/>
        [XmlEnum("602001")]
        Item602001,

        /// <remarks/>
        [XmlEnum("602002")]
        Item602002,

        /// <remarks/>
        [XmlEnum("602003")]
        Item602003,

        /// <remarks/>
        [XmlEnum("603000")]
        Item603000,

        /// <remarks/>
        [XmlEnum("603001")]
        Item603001,

        /// <remarks/>
        [XmlEnum("603002")]
        Item603002,

        /// <remarks/>
        [XmlEnum("603003")]
        Item603003,

        /// <remarks/>
        [XmlEnum("603004")]
        Item603004,

        /// <remarks/>
        [XmlEnum("603005")]
        Item603005,

        /// <remarks/>
        [XmlEnum("603006")]
        Item603006,

        /// <remarks/>
        [XmlEnum("603007")]
        Item603007,

        /// <remarks/>
        [XmlEnum("603008")]
        Item603008,

        /// <remarks/>
        [XmlEnum("603009")]
        Item603009,

        /// <remarks/>
        [XmlEnum("603010")]
        Item603010,

        /// <remarks/>
        [XmlEnum("604000")]
        Item604000,

        /// <remarks/>
        [XmlEnum("604001")]
        Item604001,

        /// <remarks/>
        [XmlEnum("604001")]
        Item6040011,

        /// <remarks/>
        [XmlEnum("604001")]
        Item6040012,

        /// <remarks/>
        [XmlEnum("604002")]
        Item604002,

        /// <remarks/>
        [XmlEnum("605000")]
        Item605000,

        /// <remarks/>
        [XmlEnum("606000")]
        Item606000,

        /// <remarks/>
        [XmlEnum("606003")]
        Item606003,

        /// <remarks/>
        [XmlEnum("606003")]
        Item6060031,

        /// <remarks/>
        [XmlEnum("606004")]
        Item606004,

        /// <remarks/>
        [XmlEnum("606005")]
        Item606005,

        /// <remarks/>
        [XmlEnum("606006")]
        Item606006,

        /// <remarks/>
        [XmlEnum("606007")]
        Item606007,

        /// <remarks/>
        [XmlEnum("606008")]
        Item606008,

        /// <remarks/>
        [XmlEnum("606009")]
        Item606009,

        /// <remarks/>
        [XmlEnum("607000")]
        Item607000,

        /// <remarks/>
        [XmlEnum("607001")]
        Item607001,

        /// <remarks/>
        [XmlEnum("607001")]
        Item6070011,

        /// <remarks/>
        [XmlEnum("607001")]
        Item6070012,

        /// <remarks/>
        [XmlEnum("608000")]
        Item608000,

        /// <remarks/>
        [XmlEnum("608001")]
        Item608001,

        /// <remarks/>
        [XmlEnum("608001")]
        Item6080011,

        /// <remarks/>
        [XmlEnum("608001")]
        Item6080012,

        /// <remarks/>
        [XmlEnum("608001")]
        Item6080013,

        /// <remarks/>
        [XmlEnum("608002")]
        Item608002,

        /// <remarks/>
        [XmlEnum("608003")]
        Item608003,

        /// <remarks/>
        [XmlEnum("608003")]
        Item6080031,

        /// <remarks/>
        [XmlEnum("608003")]
        Item6080032,

        /// <remarks/>
        [XmlEnum("608003")]
        Item6080033,

        /// <remarks/>
        [XmlEnum("608003")]
        Item6080034,

        /// <remarks/>
        [XmlEnum("609000")]
        Item609000,

        /// <remarks/>
        [XmlEnum("609001")]
        Item609001,

        /// <remarks/>
        [XmlEnum("609002")]
        Item609002,

        /// <remarks/>
        [XmlEnum("609003")]
        Item609003,
        [XmlEnum("609004")]
        Item609004,
        [XmlEnum("609005")]
        Item609005,
        [XmlEnum("609006")]
        Item609006,
        [XmlEnum("609007")]
        Item609007,
        [XmlEnum("609008")]
        Item609008,
        [XmlEnum("609008")]
        Item6090081,

        /// <remarks/>
        [XmlEnum("609008")]
        Item6090082,

        /// <remarks/>
        [XmlEnum("609008")]
        Item6090083,

        /// <remarks/>
        [XmlEnum("609008")]
        Item6090084,

        /// <remarks/>
        [XmlEnum("609009")]
        Item609009,

        /// <remarks/>
        [XmlEnum("609010")]
        Item609010,

        /// <remarks/>
        [XmlEnum("609011")]
        Item609011,

        /// <remarks/>
        [XmlEnum("609012")]
        Item609012,

        /// <remarks/>
        [XmlEnum("609013")]
        Item609013,

        /// <remarks/>
        [XmlEnum("609015")]
        Item609015,

        /// <remarks/>
        [XmlEnum("609016")]
        Item609016,

        /// <remarks/>
        [XmlEnum("609017")]
        Item609017,

        /// <remarks/>
        [XmlEnum("609018")]
        Item609018,

        /// <remarks/>
        [XmlEnum("609019")]
        Item609019,

        /// <remarks/>
        [XmlEnum("609020")]
        Item609020,

        /// <remarks/>
        [XmlEnum("609022")]
        Item609022,

        /// <remarks/>
        [XmlEnum("609023")]
        Item609023,

        /// <remarks/>
        [XmlEnum("609024")]
        Item609024,

        /// <remarks/>
        [XmlEnum("609025")]
        Item609025,

        /// <remarks/>
        [XmlEnum("609026")]
        Item609026,

        /// <remarks/>
        [XmlEnum("609027")]
        Item609027,

        /// <remarks/>
        [XmlEnum("609028")]
        Item609028,

        /// <remarks/>
        [XmlEnum("609029")]
        Item609029,

        /// <remarks/>
        [XmlEnum("609030")]
        Item609030,

        /// <remarks/>
        [XmlEnum("609031")]
        Item609031,

        /// <remarks/>
        [XmlEnum("609031")]
        Item6090311,

        /// <remarks/>
        [XmlEnum("609032")]
        Item609032,

        /// <remarks/>
        [XmlEnum("609032")]
        Item6090321,

        /// <remarks/>
        [XmlEnum("609033")]
        Item609033,

        /// <remarks/>
        [XmlEnum("609034")]
        Item609034,

        /// <remarks/>
        [XmlEnum("609035")]
        Item609035,

        /// <remarks/>
        [XmlEnum("609036")]
        Item609036,

        /// <remarks/>
        [XmlEnum("609037")]
        Item609037,

        /// <remarks/>
        [XmlEnum("609038")]
        Item609038,

        /// <remarks/>
        [XmlEnum("609039")]
        Item609039,

        /// <remarks/>
        [XmlEnum("609040")]
        Item609040,

        /// <remarks/>
        [XmlEnum("609041")]
        Item609041,

        /// <remarks/>
        [XmlEnum("609041")]
        Item6090411,

        /// <remarks/>
        [XmlEnum("609042")]
        Item609042,
        [XmlEnum("609043")]
        Item609043,
        [XmlEnum("609043")]
        Item6090431,
        [XmlEnum("609044")]
        Item609044,
        [XmlEnum("609045")]
        Item609045,

        /// <remarks/>
        [XmlEnum("609046")]
        Item609046,

        /// <remarks/>
        [XmlEnum("609047")]
        Item609047,

        /// <remarks/>
        [XmlEnum("609049")]
        Item609049,

        /// <remarks/>
        [XmlEnum("609050")]
        Item609050,

        /// <remarks/>
        [XmlEnum("609051")]
        Item609051,

        /// <remarks/>
        [XmlEnum("609052")]
        Item609052,

        /// <remarks/>
        [XmlEnum("609053")]
        Item609053,

        /// <remarks/>
        [XmlEnum("609054")]
        Item609054,

        /// <remarks/>
        [XmlEnum("609055")]
        Item609055,

        /// <remarks/>
        [XmlEnum("609056")]
        Item609056,

        /// <remarks/>
        [XmlEnum("609056")]
        Item6090561,

        /// <remarks/>
        [XmlEnum("609056")]
        Item6090562,

        /// <remarks/>
        [XmlEnum("609057")]
        Item609057,

        /// <remarks/>
        [XmlEnum("609058")]
        Item609058,

        /// <remarks/>
        [XmlEnum("609059")]
        Item609059,

        /// <remarks/>
        [XmlEnum("609060")]
        Item609060,

        /// <remarks/>
        [XmlEnum("609061")]
        Item609061,

        /// <remarks/>
        [XmlEnum("609062")]
        Item609062,

        /// <remarks/>
        [XmlEnum("609063")]
        Item609063,

        /// <remarks/>
        [XmlEnum("609064")]
        Item609064,

        /// <remarks/>
        [XmlEnum("609065")]
        Item609065,

        /// <remarks/>
        [XmlEnum("609067")]
        Item609067,

        /// <remarks/>
        [XmlEnum("609068")]
        Item609068,

        /// <remarks/>
        [XmlEnum("609069")]
        Item609069,

        /// <remarks/>
        [XmlEnum("609070")]
        Item609070,

        /// <remarks/>
        [XmlEnum("609071")]
        Item609071,

        /// <remarks/>
        [XmlEnum("609072")]
        Item609072,

        /// <remarks/>
        [XmlEnum("609073")]
        Item609073,

        /// <remarks/>
        [XmlEnum("609074")]
        Item609074,

        /// <remarks/>
        [XmlEnum("609075")]
        Item609075,

        /// <remarks/>
        [XmlEnum("609077")]
        Item609077,

        /// <remarks/>
        [XmlEnum("609078")]
        Item609078,

        /// <remarks/>
        [XmlEnum("609079")]
        Item609079,

        /// <remarks/>
        [XmlEnum("609080")]
        Item609080,

        /// <remarks/>
        [XmlEnum("609081")]
        Item609081,

        /// <remarks/>
        [XmlEnum("609082")]
        Item609082,

        /// <remarks/>
        [XmlEnum("609083")]
        Item609083,

        /// <remarks/>
        [XmlEnum("609084")]
        Item609084,

        /// <remarks/>
        [XmlEnum("609085")]
        Item609085,

        /// <remarks/>
        [XmlEnum("609087")]
        Item609087,

        /// <remarks/>
        [XmlEnum("609088")]
        Item609088,

        /// <remarks/>
        [XmlEnum("609089")]
        Item609089,

        /// <remarks/>
        [XmlEnum("609090")]
        Item609090,
        [XmlEnum("609091")]
        Item609091,
        [XmlEnum("609092")]
        Item609092,
        [XmlEnum("609093")]
        Item609093,
        [XmlEnum("609094")]
        Item609094,
        [XmlEnum("609095")]
        Item609095,

        /// <remarks/>
        [XmlEnum("609096")]
        Item609096,

        /// <remarks/>
        [XmlEnum("609097")]
        Item609097,

        /// <remarks/>
        [XmlEnum("609098")]
        Item609098,

        /// <remarks/>
        [XmlEnum("609099")]
        Item609099,

        /// <remarks/>
        [XmlEnum("609100")]
        Item609100,

        /// <remarks/>
        [XmlEnum("609101")]
        Item609101,

        /// <remarks/>
        [XmlEnum("609102")]
        Item609102,

        /// <remarks/>
        [XmlEnum("609103")]
        Item609103,

        /// <remarks/>
        [XmlEnum("609104")]
        Item609104,

        /// <remarks/>
        [XmlEnum("609105")]
        Item609105,

        /// <remarks/>
        [XmlEnum("609106")]
        Item609106,

        /// <remarks/>
        [XmlEnum("609107")]
        Item609107,

        /// <remarks/>
        [XmlEnum("609111")]
        Item609111,

        /// <remarks/>
        [XmlEnum("609112")]
        Item609112,

        /// <remarks/>
        [XmlEnum("609113")]
        Item609113,

        /// <remarks/>
        [XmlEnum("609115")]
        Item609115,

        /// <remarks/>
        [XmlEnum("609116")]
        Item609116,

        /// <remarks/>
        [XmlEnum("609117")]
        Item609117,

        /// <remarks/>
        [XmlEnum("609118")]
        Item609118,

        /// <remarks/>
        [XmlEnum("609119")]
        Item609119,

        /// <remarks/>
        [XmlEnum("609120")]
        Item609120,

        /// <remarks/>
        [XmlEnum("609122")]
        Item609122,

        /// <remarks/>
        [XmlEnum("609123")]
        Item609123,

        /// <remarks/>
        [XmlEnum("609124")]
        Item609124,

        /// <remarks/>
        [XmlEnum("609125")]
        Item609125,

        /// <remarks/>
        [XmlEnum("609126")]
        Item609126,

        /// <remarks/>
        [XmlEnum("609128")]
        Item609128,

        /// <remarks/>
        [XmlEnum("609129")]
        Item609129,

        /// <remarks/>
        [XmlEnum("609130")]
        Item609130,

        /// <remarks/>
        [XmlEnum("609131")]
        Item609131,

        /// <remarks/>
        [XmlEnum("609132")]
        Item609132,

        /// <remarks/>
        [XmlEnum("609133")]
        Item609133,

        /// <remarks/>
        [XmlEnum("609134")]
        Item609134,

        /// <remarks/>
        [XmlEnum("609135")]
        Item609135,

        /// <remarks/>
        [XmlEnum("609136")]
        Item609136,

        /// <remarks/>
        [XmlEnum("609137")]
        Item609137,

        /// <remarks/>
        [XmlEnum("609138")]
        Item609138,

        /// <remarks/>
        [XmlEnum("609139")]
        Item609139,

        /// <remarks/>
        [XmlEnum("609140")]
        Item609140,

        /// <remarks/>
        [XmlEnum("609141")]
        Item609141,
        [XmlEnum("609142")]
        Item609142,
        [XmlEnum("609143")]
        Item609143,
        [XmlEnum("609144")]
        Item609144,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:FreightChargeTariffCode:D16A")]
    public enum FreightChargeTariffCodeContentType
    {
        A,
        B,
        C,
        D,
        E,
        F,
        K,
        M,
        N,
        Q,
        R,
        S,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PartyRoleCode_ChargePaying:D16A")]
    public enum PartyRoleCodeChargePayingContentType
    {
        AB,
        AE,
        AF,
        AH,
        AQ,
        AR,
        AT,
        AU,
        CA,
        CG,
        CN,
        CPD,
        CX,
        CZ,
        DGB,
        EX,
        FW,
        GS,
        IM,
        IV,
        PE,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:FreightChargeQuantityUnitBasisCode:D16A")]
    public enum FreightChargeQuantityUnitBasisCodeContentType
    {
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:EventTimeReferenceCodePaymentTermsEvent:D16A")]
    public enum EventTimeReferenceCodePaymentTermsEventContentType
    {
        [XmlEnum("5")]
        Item5,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("71")]
        Item71,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PaymentTermsTypeCode:D16A")]
    public enum PaymentTermsTypeCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("35")]
        Item35,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("42")]
        Item42,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("44")]
        Item44,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("46")]
        Item46,
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("49")]
        Item49,
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("54")]
        Item54,
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("58")]
        Item58,
        [XmlEnum("59")]
        Item59,
        [XmlEnum("60")]
        Item60,
        [XmlEnum("61")]
        Item61,
        [XmlEnum("62")]
        Item62,
        [XmlEnum("63")]
        Item63,
        [XmlEnum("64")]
        Item64,
        [XmlEnum("65")]
        Item65,
        [XmlEnum("66")]
        Item66,
        [XmlEnum("67")]
        Item67,
        [XmlEnum("68")]
        Item68,
        [XmlEnum("69")]
        Item69,
        [XmlEnum("70")]
        Item70,
        [XmlEnum("71")]
        Item71,
        [XmlEnum("72")]
        Item72,
        [XmlEnum("73")]
        Item73,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,
        [XmlEnum("76")]
        Item76,
        [XmlEnum("77")]
        Item77,
        [XmlEnum("78")]
        Item78,
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MeasurementUnitCommonCodeWeight:4")]
    public enum MeasurementUnitCommonCodeWeightContentType
    {
        KGM,
        TNE,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MeasurementUnitCommonCodeVolume:4")]
    public enum MeasurementUnitCommonCodeVolumeContentType
    {
        CMQ,
        FTQ,
        MMQ,
        MTQ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:GoodsTypeCode:D16A")]
    public enum GoodsTypeCodeContentType
    {
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:GoodsTypeExtensionCode:D16A")]
    public enum GoodsTypeExtensionCodeContentType
    {
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:CargoTypeCode:1996Rev2Final")]
    public enum CargoTypeCodeContentType
    {
        [XmlEnum("0")]
        Item0,
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("9")]
        Item9,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:CargoOperationalCategoryCode:D16A")]
    public enum CargoOperationalCategoryCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:CommodityIdentificationCode:D16A")]
    public enum CommodityIdentificationCodeContentType
    {
        ZZZ,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MeasurementUnitCommonCodeLinear:4")]
    public enum MeasurementUnitCommonCodeLinearContentType
    {
        CMT,
        FOT,
        INH,
        MTR,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TransportEquipmentCategoryCode:D16A")]
    public enum TransportEquipmentCategoryCodeContentType
    {
        AA,
        AB,
        AD,
        AE,
        AG,
        AH,
        AI,
        AJ,
        AK,
        AL,
        AM,
        AN,
        AO,
        AP,
        AQ,
        AT,
        BB,
        BL,
        BPN,
        BPO,
        BPP,
        BPQ,
        BPR,
        BPS,
        BPT,
        BPU,
        BPV,
        BPW,
        BPX,
        BPY,
        BPZ,
        BR,
        BX,
        CH,
        CN,
        DPA,
        DPB,
        DPC,
        DPD,
        DPE,
        DPF,
        DPG,
        DPH,
        DPI,
        DPJ,
        DPL,
        EFP,
        EYP,
        FPN,
        FPR,
        IL,
        LAR,
        LU,
        MPA,
        PA,
        PBP,
        PFP,
        PL,
        PPA,
        PST,
        RF,
        RG,
        RGF,
        RO,
        RR,
        SPP,
        STR,
        SW,
        TE,
        TP,
        TS,
        TSU,
        UL,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:EquipmentSizeTypeDescriptionCode:D16A")]
    public enum EquipmentSizeTypeDescriptionCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("35")]
        Item35,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("42")]
        Item42,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("44")]
        Item44,
        [XmlEnum("45")]
        Item45,
    }

    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TransportEquipmentFullnessCode:D16A")]
    public enum TransportEquipmentFullnessCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DimensionTypeCode:D16A")]
    public enum DimensionTypeCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
        [XmlEnum("8")]
        Item8,
        [XmlEnum("9")]
        Item9,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
    }


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TransportMovementStageCode:D16A")]
    public enum TransportMovementStageCodeContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
    }


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TransportModeCode:2")]
	public enum TransportModeCodeContentType
	{
		[XmlEnum("0")]
		Item0,
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:TransportMeansTypeCode:2007")]
	public enum TransportMeansTypeCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("34")]
		Item34,
		[XmlEnum("35")]
		Item35,
		[XmlEnum("36")]
		Item36,
		[XmlEnum("37")]
		Item37,
		[XmlEnum("38")]
		Item38,
		[XmlEnum("39")]
		Item39,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("70")]
		Item70,
		[XmlEnum("71")]
		Item71,
		[XmlEnum("72")]
		Item72,
		[XmlEnum("80")]
		Item80,
		[XmlEnum("81")]
		Item81,
		[XmlEnum("85")]
		Item85,
		[XmlEnum("86")]
		Item86,
		[XmlEnum("87")]
		Item87,
		[XmlEnum("88")]
		Item88,
		[XmlEnum("89")]
		Item89,
		[XmlEnum("150")]
		Item150,
		[XmlEnum("151")]
		Item151,
		[XmlEnum("152")]
		Item152,
		[XmlEnum("153")]
		Item153,

		/// <remarks/>
		[XmlEnum("154")]
		Item154,

		/// <remarks/>
		[XmlEnum("155")]
		Item155,
		[XmlEnum("157")]
		Item157,
		[XmlEnum("159")]
		Item159,

		/// <remarks/>
		[XmlEnum("160")]
		Item160,

		/// <remarks/>
		[XmlEnum("170")]
		Item170,

		/// <remarks/>
		[XmlEnum("172")]
		Item172,

		/// <remarks/>
		[XmlEnum("173")]
		Item173,

		/// <remarks/>
		[XmlEnum("174")]
		Item174,

		/// <remarks/>
		[XmlEnum("175")]
		Item175,

		/// <remarks/>
		[XmlEnum("176")]
		Item176,

		/// <remarks/>
		[XmlEnum("177")]
		Item177,

		/// <remarks/>
		[XmlEnum("178")]
		Item178,

		/// <remarks/>
		[XmlEnum("180")]
		Item180,

		/// <remarks/>
		[XmlEnum("181")]
		Item181,

		/// <remarks/>
		[XmlEnum("182")]
		Item182,

		/// <remarks/>
		[XmlEnum("183")]
		Item183,

		/// <remarks/>
		[XmlEnum("184")]
		Item184,

		/// <remarks/>
		[XmlEnum("185")]
		Item185,

		/// <remarks/>
		[XmlEnum("189")]
		Item189,

		/// <remarks/>
		[XmlEnum("190")]
		Item190,

		/// <remarks/>
		[XmlEnum("191")]
		Item191,

		/// <remarks/>
		[XmlEnum("192")]
		Item192,

		/// <remarks/>
		[XmlEnum("210")]
		Item210,

		/// <remarks/>
		[XmlEnum("220")]
		Item220,
		[XmlEnum("230")]
		Item230,
		[XmlEnum("310")]
		Item310,
		[XmlEnum("311")]
		Item311,
		[XmlEnum("312")]
		Item312,

		/// <remarks/>
		[XmlEnum("313")]
		Item313,

		/// <remarks/>
		[XmlEnum("314")]
		Item314,

		/// <remarks/>
		[XmlEnum("315")]
		Item315,

		/// <remarks/>
		[XmlEnum("320")]
		Item320,

		/// <remarks/>
		[XmlEnum("330")]
		Item330,
		[XmlEnum("341")]
		Item341,
		[XmlEnum("342")]
		Item342,
		[XmlEnum("343")]
		Item343,

		/// <remarks/>
		[XmlEnum("360")]
		Item360,

		/// <remarks/>
		[XmlEnum("362")]
		Item362,

		/// <remarks/>
		[XmlEnum("363")]
		Item363,

		/// <remarks/>
		[XmlEnum("364")]
		Item364,

		/// <remarks/>
		[XmlEnum("365")]
		Item365,

		/// <remarks/>
		[XmlEnum("366")]
		Item366,

		/// <remarks/>
		[XmlEnum("367")]
		Item367,

		/// <remarks/>
		[XmlEnum("368")]
		Item368,
		[XmlEnum("369")]
		Item369,
		[XmlEnum("370")]
		Item370,
		[XmlEnum("371")]
		Item371,
		[XmlEnum("372")]
		Item372,

		/// <remarks/>
		[XmlEnum("373")]
		Item373,

		/// <remarks/>
		[XmlEnum("374")]
		Item374,

		/// <remarks/>
		[XmlEnum("375")]
		Item375,

		/// <remarks/>
		[XmlEnum("376")]
		Item376,

		/// <remarks/>
		[XmlEnum("377")]
		Item377,

		/// <remarks/>
		[XmlEnum("378")]
		Item378,

		/// <remarks/>
		[XmlEnum("379")]
		Item379,

		/// <remarks/>
		[XmlEnum("380")]
		Item380,

		/// <remarks/>
		[XmlEnum("381")]
		Item381,

		/// <remarks/>
		[XmlEnum("382")]
		Item382,

		/// <remarks/>
		[XmlEnum("383")]
		Item383,

		/// <remarks/>
		[XmlEnum("384")]
		Item384,

		/// <remarks/>
		[XmlEnum("385")]
		Item385,

		/// <remarks/>
		[XmlEnum("386")]
		Item386,

		/// <remarks/>
		[XmlEnum("387")]
		Item387,

		/// <remarks/>
		[XmlEnum("388")]
		Item388,

		/// <remarks/>
		[XmlEnum("389")]
		Item389,

		/// <remarks/>
		[XmlEnum("390")]
		Item390,

		/// <remarks/>
		[XmlEnum("391")]
		Item391,

		/// <remarks/>
		[XmlEnum("392")]
		Item392,

		/// <remarks/>
		[XmlEnum("393")]
		Item393,

		/// <remarks/>
		[XmlEnum("394")]
		Item394,
		[XmlEnum("395")]
		Item395,
		[XmlEnum("396")]
		Item396,
		[XmlEnum("397")]
		Item397,

		/// <remarks/>
		[XmlEnum("398")]
		Item398,
		[XmlEnum("399")]
		Item399,

		/// <remarks/>
		[XmlEnum("802")]
		Item802,

		/// <remarks/>
		[XmlEnum("803")]
		Item803,

		/// <remarks/>
		[XmlEnum("804")]
		Item804,

		/// <remarks/>
		[XmlEnum("810")]
		Item810,

		/// <remarks/>
		[XmlEnum("811")]
		Item811,

		/// <remarks/>
		[XmlEnum("812")]
		Item812,

		/// <remarks/>
		[XmlEnum("813")]
		Item813,

		/// <remarks/>
		[XmlEnum("814")]
		Item814,

		/// <remarks/>
		[XmlEnum("815")]
		Item815,

		/// <remarks/>
		[XmlEnum("816")]
		Item816,

		/// <remarks/>
		[XmlEnum("817")]
		Item817,

		/// <remarks/>
		[XmlEnum("818")]
		Item818,

		/// <remarks/>
		[XmlEnum("821")]
		Item821,

		/// <remarks/>
		[XmlEnum("822")]
		Item822,

		/// <remarks/>
		[XmlEnum("823")]
		Item823,

		/// <remarks/>
		[XmlEnum("824")]
		Item824,

		/// <remarks/>
		[XmlEnum("825")]
		Item825,

		/// <remarks/>
		[XmlEnum("826")]
		Item826,

		/// <remarks/>
		[XmlEnum("827")]
		Item827,

		/// <remarks/>
		[XmlEnum("828")]
		Item828,

		/// <remarks/>
		[XmlEnum("829")]
		Item829,

		/// <remarks/>
		[XmlEnum("831")]
		Item831,

		/// <remarks/>
		[XmlEnum("832")]
		Item832,

		/// <remarks/>
		[XmlEnum("833")]
		Item833,

		/// <remarks/>
		[XmlEnum("834")]
		Item834,

		/// <remarks/>
		[XmlEnum("835")]
		Item835,

		/// <remarks/>
		[XmlEnum("836")]
		Item836,

		/// <remarks/>
		[XmlEnum("837")]
		Item837,

		/// <remarks/>
		[XmlEnum("838")]
		Item838,
		[XmlEnum("839")]
		Item839,

		/// <remarks/>
		[XmlEnum("840")]
		Item840,

		/// <remarks/>
		[XmlEnum("841")]
		Item841,

		/// <remarks/>
		[XmlEnum("842")]
		Item842,

		/// <remarks/>
		[XmlEnum("843")]
		Item843,

		/// <remarks/>
		[XmlEnum("844")]
		Item844,

		/// <remarks/>
		[XmlEnum("845")]
		Item845,

		/// <remarks/>
		[XmlEnum("846")]
		Item846,

		/// <remarks/>
		[XmlEnum("847")]
		Item847,

		/// <remarks/>
		[XmlEnum("848")]
		Item848,

		/// <remarks/>
		[XmlEnum("849")]
		Item849,

		/// <remarks/>
		[XmlEnum("850")]
		Item850,

		/// <remarks/>
		[XmlEnum("851")]
		Item851,

		/// <remarks/>
		[XmlEnum("1501")]
		Item1501,

		/// <remarks/>
		[XmlEnum("1502")]
		Item1502,

		/// <remarks/>
		[XmlEnum("1503")]
		Item1503,

		/// <remarks/>
		[XmlEnum("1504")]
		Item1504,

		/// <remarks/>
		[XmlEnum("1505")]
		Item1505,

		/// <remarks/>
		[XmlEnum("1506")]
		Item1506,

		/// <remarks/>
		[XmlEnum("1511")]
		Item1511,

		/// <remarks/>
		[XmlEnum("1512")]
		Item1512,

		/// <remarks/>
		[XmlEnum("1513")]
		Item1513,

		/// <remarks/>
		[XmlEnum("1514")]
		Item1514,

		/// <remarks/>
		[XmlEnum("1515")]
		Item1515,

		/// <remarks/>
		[XmlEnum("1516")]
		Item1516,

		/// <remarks/>
		[XmlEnum("1517")]
		Item1517,

		/// <remarks/>
		[XmlEnum("1518")]
		Item1518,

		/// <remarks/>
		[XmlEnum("1519")]
		Item1519,

		/// <remarks/>
		[XmlEnum("1521")]
		Item1521,

		/// <remarks/>
		[XmlEnum("1522")]
		Item1522,

		/// <remarks/>
		[XmlEnum("1523")]
		Item1523,

		/// <remarks/>
		[XmlEnum("1524")]
		Item1524,

		/// <remarks/>
		[XmlEnum("1525")]
		Item1525,

		/// <remarks/>
		[XmlEnum("1531")]
		Item1531,

		/// <remarks/>
		[XmlEnum("1532")]
		Item1532,

		/// <remarks/>
		[XmlEnum("1533")]
		Item1533,

		/// <remarks/>
		[XmlEnum("1534")]
		Item1534,

		/// <remarks/>
		[XmlEnum("1541")]
		Item1541,

		/// <remarks/>
		[XmlEnum("1542")]
		Item1542,

		/// <remarks/>
		[XmlEnum("1543")]
		Item1543,

		/// <remarks/>
		[XmlEnum("1551")]
		Item1551,

		/// <remarks/>
		[XmlEnum("1552")]
		Item1552,

		/// <remarks/>
		[XmlEnum("1553")]
		Item1553,

		/// <remarks/>
		[XmlEnum("1591")]
		Item1591,

		/// <remarks/>
		[XmlEnum("1592")]
		Item1592,

		/// <remarks/>
		[XmlEnum("1593")]
		Item1593,

		/// <remarks/>
		[XmlEnum("1594")]
		Item1594,

		/// <remarks/>
		[XmlEnum("1601")]
		Item1601,

		/// <remarks/>
		[XmlEnum("1602")]
		Item1602,

		/// <remarks/>
		[XmlEnum("1603")]
		Item1603,

		/// <remarks/>
		[XmlEnum("1604")]
		Item1604,

		/// <remarks/>
		[XmlEnum("1605")]
		Item1605,

		/// <remarks/>
		[XmlEnum("1606")]
		Item1606,

		/// <remarks/>
		[XmlEnum("1607")]
		Item1607,

		/// <remarks/>
		[XmlEnum("1711")]
		Item1711,

		/// <remarks/>
		[XmlEnum("1712")]
		Item1712,

		/// <remarks/>
		[XmlEnum("1721")]
		Item1721,

		/// <remarks/>
		[XmlEnum("1723")]
		Item1723,

		/// <remarks/>
		[XmlEnum("1724")]
		Item1724,

		/// <remarks/>
		[XmlEnum("1725")]
		Item1725,

		/// <remarks/>
		[XmlEnum("1726")]
		Item1726,

		/// <remarks/>
		[XmlEnum("1727")]
		Item1727,

		/// <remarks/>
		[XmlEnum("1728")]
		Item1728,

		/// <remarks/>
		[XmlEnum("1729")]
		Item1729,

		/// <remarks/>
		[XmlEnum("1751")]
		Item1751,
		[XmlEnum("1752")]
		Item1752,
		[XmlEnum("1753")]
		Item1753,
		[XmlEnum("1761")]
		Item1761,
		[XmlEnum("1762")]
		Item1762,
		[XmlEnum("1763")]
		Item1763,

		/// <remarks/>
		[XmlEnum("1764")]
		Item1764,

		/// <remarks/>
		[XmlEnum("1765")]
		Item1765,

		/// <remarks/>
		[XmlEnum("1766")]
		Item1766,

		/// <remarks/>
		[XmlEnum("1781")]
		Item1781,

		/// <remarks/>
		[XmlEnum("1782")]
		Item1782,

		/// <remarks/>
		[XmlEnum("2201")]
		Item2201,

		/// <remarks/>
		[XmlEnum("2202")]
		Item2202,

		/// <remarks/>
		[XmlEnum("2203")]
		Item2203,

		/// <remarks/>
		[XmlEnum("2301")]
		Item2301,

		/// <remarks/>
		[XmlEnum("2302")]
		Item2302,

		/// <remarks/>
		[XmlEnum("2303")]
		Item2303,

		/// <remarks/>
		[XmlEnum("2304")]
		Item2304,

		/// <remarks/>
		[XmlEnum("2305")]
		Item2305,

		/// <remarks/>
		[XmlEnum("3100")]
		Item3100,

		/// <remarks/>
		[XmlEnum("3101")]
		Item3101,

		/// <remarks/>
		[XmlEnum("3102")]
		Item3102,

		/// <remarks/>
		[XmlEnum("3103")]
		Item3103,

		/// <remarks/>
		[XmlEnum("3104")]
		Item3104,

		/// <remarks/>
		[XmlEnum("3105")]
		Item3105,

		/// <remarks/>
		[XmlEnum("3106")]
		Item3106,

		/// <remarks/>
		[XmlEnum("3107")]
		Item3107,

		/// <remarks/>
		[XmlEnum("3108")]
		Item3108,

		/// <remarks/>
		[XmlEnum("3109")]
		Item3109,

		/// <remarks/>
		[XmlEnum("3110")]
		Item3110,

		/// <remarks/>
		[XmlEnum("3111")]
		Item3111,

		/// <remarks/>
		[XmlEnum("3112")]
		Item3112,

		/// <remarks/>
		[XmlEnum("3113")]
		Item3113,

		/// <remarks/>
		[XmlEnum("3114")]
		Item3114,

		/// <remarks/>
		[XmlEnum("3115")]
		Item3115,

		/// <remarks/>
		[XmlEnum("3116")]
		Item3116,

		/// <remarks/>
		[XmlEnum("3117")]
		Item3117,

		/// <remarks/>
		[XmlEnum("3118")]
		Item3118,

		/// <remarks/>
		[XmlEnum("3119")]
		Item3119,

		/// <remarks/>
		[XmlEnum("3120")]
		Item3120,

		/// <remarks/>
		[XmlEnum("3121")]
		Item3121,
		[XmlEnum("3122")]
		Item3122,
		[XmlEnum("3123")]
		Item3123,
		[XmlEnum("3124")]
		Item3124,

		[XmlEnum("3125")]
		Item3125,
		[XmlEnum("3126")]
		Item3126,
		[XmlEnum("3127")]
		Item3127,
		[XmlEnum("3128")]
		Item3128,
		[XmlEnum("3129")]
		Item3129,
		[XmlEnum("3130")]
		Item3130,
		[XmlEnum("3131")]
		Item3131,

		/// <remarks/>
		[XmlEnum("3132")]
		Item3132,

		/// <remarks/>
		[XmlEnum("3133")]
		Item3133,

		/// <remarks/>
		[XmlEnum("3134")]
		Item3134,

		/// <remarks/>
		[XmlEnum("3135")]
		Item3135,

		/// <remarks/>
		[XmlEnum("3136")]
		Item3136,

		/// <remarks/>
		[XmlEnum("3137")]
		Item3137,

		/// <remarks/>
		[XmlEnum("3138")]
		Item3138,

		/// <remarks/>
		[XmlEnum("3201")]
		Item3201,

		/// <remarks/>
		[XmlEnum("3301")]
		Item3301,

		/// <remarks/>
		[XmlEnum("3302")]
		Item3302,

		/// <remarks/>
		[XmlEnum("3303")]
		Item3303,

		/// <remarks/>
		[XmlEnum("3304")]
		Item3304,

		/// <remarks/>
		[XmlEnum("4000")]
		Item4000,

		/// <remarks/>
		[XmlEnum("5000")]
		Item5000,
		[XmlEnum("8021")]
		Item8021,
		[XmlEnum("8022")]
		Item8022,
		[XmlEnum("8023")]
		Item8023,
		[XmlEnum("8161")]
		Item8161,
		[XmlEnum("8162")]
		Item8162,

		/// <remarks/>
		[XmlEnum("8163")]
		Item8163,

		/// <remarks/>
		[XmlEnum("8441")]
		Item8441,

		/// <remarks/>
		[XmlEnum("8442")]
		Item8442,

		/// <remarks/>
		[XmlEnum("8443")]
		Item8443,

		/// <remarks/>
		[XmlEnum("8444")]
		Item8444,

		/// <remarks/>
		[XmlEnum("8445")]
		Item8445,

		/// <remarks/>
		[XmlEnum("8446")]
		Item8446,

		/// <remarks/>
		[XmlEnum("8447")]
		Item8447,

		/// <remarks/>
		[XmlEnum("8448")]
		Item8448,
		[XmlEnum("8451")]
		Item8451,
		[XmlEnum("8452")]
		Item8452,
		[XmlEnum("8453")]
		Item8453,
		[XmlEnum("8454")]
		Item8454,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:DeliveryTermsCode:2010")]
	public enum DeliveryTermsCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		CFR,
		CIF,
		CIP,
		CPT,
		DAP,
		DAT,
		DDP,
		EXW,
		FAS,
		FCA,
		FOB,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PackageTypeCode:2006")]
	public enum PackageTypeCodeContentType
	{
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("1A")]
		Item1A,
		[XmlEnum("1B")]
		Item1B,
		[XmlEnum("1D")]
		Item1D,
		[XmlEnum("1F")]
		Item1F,
		[XmlEnum("1G")]
		Item1G,
		[XmlEnum("1W")]
		Item1W,
		[XmlEnum("2C")]
		Item2C,
		[XmlEnum("3A")]
		Item3A,
		[XmlEnum("3H")]
		Item3H,
		[XmlEnum("4A")]
		Item4A,
		[XmlEnum("4B")]
		Item4B,
		[XmlEnum("4C")]
		Item4C,
		[XmlEnum("4D")]
		Item4D,
		[XmlEnum("4F")]
		Item4F,
		[XmlEnum("4G")]
		Item4G,

		/// <remarks/>
		[XmlEnum("4H")]
		Item4H,

		/// <remarks/>
		[XmlEnum("5H")]
		Item5H,

		/// <remarks/>
		[XmlEnum("5L")]
		Item5L,

		/// <remarks/>
		[XmlEnum("5M")]
		Item5M,

		/// <remarks/>
		[XmlEnum("6H")]
		Item6H,

		/// <remarks/>
		[XmlEnum("6P")]
		Item6P,
		[XmlEnum("7A")]
		Item7A,
		[XmlEnum("7B")]
		Item7B,
		[XmlEnum("8A")]
		Item8A,
		[XmlEnum("8B")]
		Item8B,
		[XmlEnum("8C")]
		Item8C,
		AA,
		AB,
		AC,
		AD,
		AE,
		AF,
		AG,
		AH,
		AI,
		AJ,
		AL,
		AM,
		AP,
		AT,
		AV,
		B4,
		BA,
		BB,
		BC,
		BD,
		BE,

		/// <remarks/>
		BF,

		/// <remarks/>
		BG,

		/// <remarks/>
		BH,

		/// <remarks/>
		BI,

		/// <remarks/>
		BJ,

		/// <remarks/>
		BK,

		/// <remarks/>
		BL,

		/// <remarks/>
		BM,

		/// <remarks/>
		BN,

		/// <remarks/>
		BO,
		BP,
		BQ,
		BR,

		/// <remarks/>
		BS,

		/// <remarks/>
		BT,

		/// <remarks/>
		BU,

		/// <remarks/>
		BV,

		/// <remarks/>
		BW,

		/// <remarks/>
		BX,

		/// <remarks/>
		BY,

		/// <remarks/>
		BZ,

		/// <remarks/>
		CA,

		/// <remarks/>
		CB,

		/// <remarks/>
		CC,

		/// <remarks/>
		CD,

		/// <remarks/>
		CE,

		/// <remarks/>
		CF,

		/// <remarks/>
		CG,

		/// <remarks/>
		CH,

		/// <remarks/>
		CI,

		/// <remarks/>
		CJ,

		/// <remarks/>
		CK,

		/// <remarks/>
		CL,

		/// <remarks/>
		CM,

		/// <remarks/>
		CN,

		/// <remarks/>
		CO,

		/// <remarks/>
		CP,

		/// <remarks/>
		CQ,

		/// <remarks/>
		CR,

		/// <remarks/>
		CS,

		/// <remarks/>
		CT,

		/// <remarks/>
		CU,

		/// <remarks/>
		CV,

		/// <remarks/>
		CW,

		/// <remarks/>
		CX,

		/// <remarks/>
		CY,

		/// <remarks/>
		CZ,

		/// <remarks/>
		DA,

		/// <remarks/>
		DB,

		/// <remarks/>
		DC,

		/// <remarks/>
		DG,

		/// <remarks/>
		DH,

		/// <remarks/>
		DI,

		/// <remarks/>
		DJ,

		/// <remarks/>
		DK,

		/// <remarks/>
		DL,

		/// <remarks/>
		DM,

		/// <remarks/>
		DN,

		/// <remarks/>
		DP,

		/// <remarks/>
		DR,

		/// <remarks/>
		DS,
		DT,
		DU,
		DV,
		DW,
		DX,
		DY,
		EC,
		ED,
		EE,
		EF,

		/// <remarks/>
		EG,

		/// <remarks/>
		EH,

		/// <remarks/>
		EI,

		/// <remarks/>
		EN,

		/// <remarks/>
		FB,

		/// <remarks/>
		FC,

		/// <remarks/>
		FD,

		/// <remarks/>
		FE,

		/// <remarks/>
		FI,

		/// <remarks/>
		FL,

		/// <remarks/>
		FO,

		/// <remarks/>
		FP,

		/// <remarks/>
		FR,

		/// <remarks/>
		FT,

		/// <remarks/>
		FW,

		/// <remarks/>
		FX,

		/// <remarks/>
		GB,

		/// <remarks/>
		GI,

		/// <remarks/>
		GL,

		/// <remarks/>
		GR,

		/// <remarks/>
		GU,

		/// <remarks/>
		GY,

		/// <remarks/>
		GZ,

		/// <remarks/>
		HA,

		/// <remarks/>
		HB,

		/// <remarks/>
		HC,

		/// <remarks/>
		HG,

		/// <remarks/>
		HN,

		/// <remarks/>
		HR,

		/// <remarks/>
		IA,

		/// <remarks/>
		IB,

		/// <remarks/>
		IC,

		/// <remarks/>
		ID,

		/// <remarks/>
		IE,

		/// <remarks/>
		IF,

		/// <remarks/>
		IG,

		/// <remarks/>
		IH,

		/// <remarks/>
		IK,

		/// <remarks/>
		IL,
		IN,
		IZ,
		JB,
		JC,
		JG,
		JR,
		JT,
		JY,

		/// <remarks/>
		KG,

		/// <remarks/>
		KI,

		/// <remarks/>
		LE,

		/// <remarks/>
		LG,

		/// <remarks/>
		LT,

		/// <remarks/>
		LU,

		/// <remarks/>
		LV,

		/// <remarks/>
		LZ,

		/// <remarks/>
		MA,
		MB,
		MC,
		ME,
		MR,
		MS,
		MT,
		MW,
		MX,
		NA,

		/// <remarks/>
		NE,

		/// <remarks/>
		NF,

		/// <remarks/>
		NG,

		/// <remarks/>
		NS,
		NT,
		NU,
		NV,

		/// <remarks/>
		OA,

		/// <remarks/>
		OB,

		/// <remarks/>
		OC,

		/// <remarks/>
		OD,

		/// <remarks/>
		OE,

		/// <remarks/>
		OF,

		/// <remarks/>
		OK,

		/// <remarks/>
		OT,

		/// <remarks/>
		OU,

		/// <remarks/>
		P2,

		/// <remarks/>
		PA,

		/// <remarks/>
		PB,

		/// <remarks/>
		PC,

		/// <remarks/>
		PD,

		/// <remarks/>
		PE,

		/// <remarks/>
		PF,

		/// <remarks/>
		PG,
		PH,
		PI,
		PJ,
		PK,
		PL,
		PN,

		/// <remarks/>
		PO,

		/// <remarks/>
		PP,

		/// <remarks/>
		PR,

		/// <remarks/>
		PT,

		/// <remarks/>
		PU,

		/// <remarks/>
		PV,

		/// <remarks/>
		PX,

		/// <remarks/>
		PY,

		/// <remarks/>
		PZ,

		/// <remarks/>
		QA,

		/// <remarks/>
		QB,

		/// <remarks/>
		QC,

		/// <remarks/>
		QD,

		/// <remarks/>
		QF,

		/// <remarks/>
		QG,

		/// <remarks/>
		QH,

		/// <remarks/>
		QJ,

		/// <remarks/>
		QK,

		/// <remarks/>
		QL,

		/// <remarks/>
		QM,

		/// <remarks/>
		QN,

		/// <remarks/>
		QP,

		/// <remarks/>
		QQ,

		/// <remarks/>
		QR,
		QS,
		RD,
		RG,
		RJ,
		RK,
		RL,
		RO,
		RT,
		RZ,

		/// <remarks/>
		SA,

		/// <remarks/>
		SB,

		/// <remarks/>
		SC,

		/// <remarks/>
		SD,

		/// <remarks/>
		SE,

		/// <remarks/>
		SH,

		/// <remarks/>
		SI,

		/// <remarks/>
		SK,

		/// <remarks/>
		SL,

		/// <remarks/>
		SM,

		/// <remarks/>
		SO,

		/// <remarks/>
		SP,

		/// <remarks/>
		SS,

		/// <remarks/>
		ST,

		/// <remarks/>
		SU,

		/// <remarks/>
		SV,

		/// <remarks/>
		SW,

		/// <remarks/>
		SY,
		SZ,
		T1,
		TB,
		TC,
		TD,
		TE,
		TG,
		TI,
		TK,

		/// <remarks/>
		TL,

		/// <remarks/>
		TN,

		/// <remarks/>
		TO,

		/// <remarks/>
		TR,

		/// <remarks/>
		TS,

		/// <remarks/>
		TT,

		/// <remarks/>
		TU,

		/// <remarks/>
		TV,

		/// <remarks/>
		TW,

		/// <remarks/>
		TY,

		/// <remarks/>
		TZ,

		/// <remarks/>
		UC,
		UN,
		VA,

		/// <remarks/>
		VG,
		VI,

		/// <remarks/>
		VK,

		/// <remarks/>
		VL,

		/// <remarks/>
		VN,

		/// <remarks/>
		VO,

		/// <remarks/>
		VP,

		/// <remarks/>
		VQ,

		/// <remarks/>
		VR,

		/// <remarks/>
		VS,

		/// <remarks/>
		VY,
		WA,
		WB,
		WC,
		WD,
		WF,
		WG,
		WH,
		WJ,
		WK,
		WL,
		WM,
		WN,
		WP,
		WQ,
		WR,
		WS,
		WT,
		WU,
		WV,
		WW,
		WX,
		WY,
		WZ,
		XA,
		XB,
		XC,
		XD,
		XF,
		XG,
		XH,
		XJ,
		XK,
		YA,
		YB,

		YC,
		YD,
		YF,

		YG,

		YH,
		YJ,

		YK,

		YL,

		YM,

		YN,

		YP,

		/// <remarks/>
		YQ,

		/// <remarks/>
		YR,

		/// <remarks/>
		YS,

		/// <remarks/>
		YT,
		YV,
		YW,
		YX,
		YY,
		YZ,
		ZA,
		ZB,
		ZC,
		ZD,
		ZF,
		ZG,
		ZH,
		ZJ,
		ZK,
		ZL,

		ZM,

		ZN,

		ZP,
		ZQ,
		ZR,
		ZS,
		ZT,
		ZU,
		ZV,
		ZW,
		ZX,
		ZY,
		ZZ,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PackagingMarkingCode:D16A")]
	public enum PackagingMarkingCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
		[XmlEnum("10")]
		Item10,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("34")]
		Item34,
		[XmlEnum("35")]
		Item35,
		[XmlEnum("36")]
		Item36,
		[XmlEnum("37")]
		Item37,
		[XmlEnum("38")]
		Item38,
		[XmlEnum("39")]
		Item39,
		[XmlEnum("40")]
		Item40,
		[XmlEnum("41")]
		Item41,
		[XmlEnum("42")]
		Item42,
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("45")]
		Item45,
		[XmlEnum("46")]
		Item46,
		[XmlEnum("47")]
		Item47,
		[XmlEnum("48")]
		Item48,
		[XmlEnum("49")]
		Item49,
		[XmlEnum("53")]
		Item53,
		[XmlEnum("54")]
		Item54,
		[XmlEnum("55")]
		Item55,
		[XmlEnum("56")]
		Item56,
		[XmlEnum("57")]
		Item57,
		[XmlEnum("58")]
		Item58,
		[XmlEnum("59")]
		Item59,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("61")]
		Item61,
		[XmlEnum("62")]
		Item62,
		[XmlEnum("63")]
		Item63,
		[XmlEnum("66")]
		Item66,
		[XmlEnum("68")]
		Item68,
		[XmlEnum("69")]
		Item69,
		[XmlEnum("70")]
		Item70,
		[XmlEnum("71")]
		Item71,
		[XmlEnum("72")]
		Item72,
		[XmlEnum("73")]
		Item73,
		[XmlEnum("74")]
		Item74,
		[XmlEnum("75")]
		Item75,
		[XmlEnum("76")]
		Item76,
		[XmlEnum("77")]
		Item77,
		[XmlEnum("80")]
		Item80,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:AutomaticDataCaptureMethodCode:D16A")]
	public enum AutomaticDataCaptureMethodCodeContentType
	{
		[XmlEnum("50")]
		Item50,
		[XmlEnum("51")]
		Item51,
		[XmlEnum("52")]
		Item52,
		[XmlEnum("64")]
		Item64,
		[XmlEnum("65")]
		Item65,
		[XmlEnum("67")]
		Item67,
		[XmlEnum("78")]
		Item78,
		[XmlEnum("79")]
		Item79,
		[XmlEnum("81")]
		Item81,
		[XmlEnum("82")]
		Item82,
	}

	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:PriceTypeCode:D16A")]
	public enum PriceTypeCodeContentType
	{
		AA,
		AB,
		AC,
		AD,
		AE,
		AF,
		AI,
		AQ,
		CA,
		CT,
		CU,
		DI,
		EC,
		NW,
		PC,
		PE,
		PK,
		PL,
		PT,
		PU,
		PV,
		PW,
		QT,
		SR,
		TB,
		TU,
		TW,
		WH,
		WI,
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:AdjustmentReasonDescriptionCode:D16A")]
	public enum AdjustmentReasonDescriptionCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
		[XmlEnum("10")]
		Item10,
		[XmlEnum("11")]
		Item11,
		[XmlEnum("12")]
		Item12,
		[XmlEnum("13")]
		Item13,
		[XmlEnum("14")]
		Item14,
		[XmlEnum("15")]
		Item15,
		[XmlEnum("16")]
		Item16,
		[XmlEnum("17")]
		Item17,
		[XmlEnum("18")]
		Item18,
		[XmlEnum("19")]
		Item19,
		[XmlEnum("20")]
		Item20,
		[XmlEnum("21")]
		Item21,
		[XmlEnum("22")]
		Item22,
		[XmlEnum("23")]
		Item23,
		[XmlEnum("24")]
		Item24,
		[XmlEnum("25")]
		Item25,
		[XmlEnum("26")]
		Item26,
		[XmlEnum("27")]
		Item27,
		[XmlEnum("28")]
		Item28,
		[XmlEnum("29")]
		Item29,
		[XmlEnum("30")]
		Item30,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("34")]
		Item34,
		[XmlEnum("35")]
		Item35,
		[XmlEnum("36")]
		Item36,
		[XmlEnum("37")]
		Item37,
		[XmlEnum("38")]
		Item38,
		[XmlEnum("39")]
		Item39,
		[XmlEnum("40")]
		Item40,
		[XmlEnum("41")]
		Item41,
		[XmlEnum("42")]
		Item42,
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("45")]
		Item45,
		[XmlEnum("46")]
		Item46,
		[XmlEnum("47")]
		Item47,
		[XmlEnum("48")]
		Item48,
		[XmlEnum("49")]
		Item49,
		[XmlEnum("50")]
		Item50,
		[XmlEnum("51")]
		Item51,
		[XmlEnum("52")]
		Item52,
		[XmlEnum("53")]
		Item53,
		[XmlEnum("54")]
		Item54,
		[XmlEnum("55")]
		Item55,
		[XmlEnum("56")]
		Item56,
		[XmlEnum("57")]
		Item57,
		[XmlEnum("58")]
		Item58,
		[XmlEnum("59")]
		Item59,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("61")]
		Item61,
		[XmlEnum("62")]
		Item62,
		[XmlEnum("63")]
		Item63,
		[XmlEnum("64")]
		Item64,
		[XmlEnum("65")]
		Item65,
		[XmlEnum("66")]
		Item66,
		[XmlEnum("67")]
		Item67,
		[XmlEnum("68")]
		Item68,
		[XmlEnum("69")]
		Item69,
		[XmlEnum("70")]
		Item70,
		[XmlEnum("71")]
		Item71,
		[XmlEnum("72")]
		Item72,
		[XmlEnum("73")]
		Item73,
		[XmlEnum("74")]
		Item74,
		[XmlEnum("75")]
		Item75,
		[XmlEnum("76")]
		Item76,
		[XmlEnum("77")]
		Item77,
		[XmlEnum("78")]
		Item78,
		[XmlEnum("79")]
		Item79,
		[XmlEnum("80")]
		Item80,
		[XmlEnum("81")]
		Item81,
		[XmlEnum("82")]
		Item82,
		[XmlEnum("83")]
		Item83,
		[XmlEnum("84")]
		Item84,
		[XmlEnum("85")]
		Item85,
		[XmlEnum("86")]
		Item86,
		[XmlEnum("87")]
		Item87,
		[XmlEnum("88")]
		Item88,
		[XmlEnum("89")]
		Item89,
		[XmlEnum("90")]
		Item90,
		[XmlEnum("91")]
		Item91,
		[XmlEnum("92")]
		Item92,
		[XmlEnum("93")]
		Item93,
		[XmlEnum("94")]
		Item94,
		[XmlEnum("95")]
		Item95,
		[XmlEnum("96")]
		Item96,
		[XmlEnum("97")]
		Item97,
		[XmlEnum("98")]
		Item98,
		[XmlEnum("99")]
		Item99,
		[XmlEnum("100")]
		Item100,
		[XmlEnum("101")]
		Item101,
		[XmlEnum("102")]
		Item102,
		[XmlEnum("103")]
		Item103,
		[XmlEnum("104")]
		Item104,
		ZZZ,
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:ActionCode:D16A")]
	public enum ActionCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
		[XmlEnum("10")]
		Item10,
		[XmlEnum("11")]
		Item11,
		[XmlEnum("12")]
		Item12,
		[XmlEnum("13")]
		Item13,
		[XmlEnum("14")]
		Item14,
		[XmlEnum("15")]
		Item15,
		[XmlEnum("16")]
		Item16,
		[XmlEnum("17")]
		Item17,
		[XmlEnum("18")]
		Item18,
		[XmlEnum("19")]
		Item19,
		[XmlEnum("20")]
		Item20,
		[XmlEnum("21")]
		Item21,
		[XmlEnum("22")]
		Item22,
		[XmlEnum("23")]
		Item23,
		[XmlEnum("24")]
		Item24,
		[XmlEnum("25")]
		Item25,
		[XmlEnum("26")]
		Item26,
		[XmlEnum("27")]
		Item27,
		[XmlEnum("28")]
		Item28,
		[XmlEnum("29")]
		Item29,
		[XmlEnum("30")]
		Item30,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("34")]
		Item34,
		[XmlEnum("35")]
		Item35,
		[XmlEnum("36")]
		Item36,
		[XmlEnum("37")]
		Item37,
		[XmlEnum("38")]
		Item38,
		[XmlEnum("39")]
		Item39,
		[XmlEnum("40")]
		Item40,
		[XmlEnum("41")]
		Item41,
		[XmlEnum("42")]
		Item42,
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("45")]
		Item45,
		[XmlEnum("46")]
		Item46,
		[XmlEnum("47")]
		Item47,
		[XmlEnum("48")]
		Item48,
		[XmlEnum("49")]
		Item49,
		[XmlEnum("50")]
		Item50,
		[XmlEnum("51")]
		Item51,
		[XmlEnum("52")]
		Item52,
		[XmlEnum("53")]
		Item53,
		[XmlEnum("54")]
		Item54,
		[XmlEnum("55")]
		Item55,
		[XmlEnum("56")]
		Item56,
		[XmlEnum("57")]
		Item57,
		[XmlEnum("58")]
		Item58,
		[XmlEnum("59")]
		Item59,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("61")]
		Item61,
		[XmlEnum("62")]
		Item62,
		[XmlEnum("63")]
		Item63,
		[XmlEnum("64")]
		Item64,
		[XmlEnum("65")]
		Item65,
		[XmlEnum("66")]
		Item66,
		[XmlEnum("67")]
		Item67,
		[XmlEnum("68")]
		Item68,
		[XmlEnum("69")]
		Item69,
		[XmlEnum("70")]
		Item70,
		[XmlEnum("71")]
		Item71,
		[XmlEnum("72")]
		Item72,
		[XmlEnum("73")]
		Item73,
		[XmlEnum("74")]
		Item74,
		[XmlEnum("75")]
		Item75,
		[XmlEnum("76")]
		Item76,
		[XmlEnum("77")]
		Item77,
		[XmlEnum("78")]
		Item78,
		[XmlEnum("79")]
		Item79,
		[XmlEnum("80")]
		Item80,
		[XmlEnum("81")]
		Item81,
		[XmlEnum("82")]
		Item82,
		[XmlEnum("83")]
		Item83,
		[XmlEnum("84")]
		Item84,
		[XmlEnum("85")]
		Item85,
		[XmlEnum("86")]
		Item86,
		[XmlEnum("87")]
		Item87,
		[XmlEnum("88")]
		Item88,
		[XmlEnum("89")]
		Item89,
		[XmlEnum("90")]
		Item90,
		[XmlEnum("91")]
		Item91,
		[XmlEnum("92")]
		Item92,
		[XmlEnum("93")]
		Item93,
		[XmlEnum("94")]
		Item94,
		[XmlEnum("95")]
		Item95,
		[XmlEnum("96")]
		Item96,
		[XmlEnum("97")]
		Item97,
		[XmlEnum("98")]
		Item98,
		[XmlEnum("99")]
		Item99,
		[XmlEnum("100")]
		Item100,
		[XmlEnum("101")]
		Item101,
		[XmlEnum("102")]
		Item102,
		[XmlEnum("103")]
		Item103,
		[XmlEnum("104")]
		Item104,
		[XmlEnum("105")]
		Item105,
		[XmlEnum("106")]
		Item106,
		[XmlEnum("107")]
		Item107,
		[XmlEnum("108")]
		Item108,
		[XmlEnum("109")]
		Item109,
		[XmlEnum("110")]
		Item110,
		[XmlEnum("111")]
		Item111,
		[XmlEnum("112")]
		Item112,
		[XmlEnum("113")]
		Item113,
		[XmlEnum("114")]
		Item114,
		[XmlEnum("115")]
		Item115,
		[XmlEnum("116")]
		Item116,
		[XmlEnum("117")]
		Item117,
		[XmlEnum("118")]
		Item118,
	}


	[Serializable()]
	[XmlType(Namespace = "urn:un:unece:uncefact:codelist:standard:UNECE:MessageFunctionCode:D16A")]
	public enum MessageFunctionCodeContentType
	{
		[XmlEnum("1")]
		Item1,
		[XmlEnum("2")]
		Item2,
		[XmlEnum("3")]
		Item3,
		[XmlEnum("4")]
		Item4,
		[XmlEnum("5")]
		Item5,
		[XmlEnum("6")]
		Item6,
		[XmlEnum("7")]
		Item7,
		[XmlEnum("8")]
		Item8,
		[XmlEnum("9")]
		Item9,
		[XmlEnum("10")]
		Item10,
		[XmlEnum("11")]
		Item11,
		[XmlEnum("12")]
		Item12,
		[XmlEnum("13")]
		Item13,
		[XmlEnum("14")]
		Item14,
		[XmlEnum("15")]
		Item15,
		[XmlEnum("16")]
		Item16,
		[XmlEnum("17")]
		Item17,
		[XmlEnum("18")]
		Item18,
		[XmlEnum("19")]
		Item19,
		[XmlEnum("20")]
		Item20,
		[XmlEnum("21")]
		Item21,
		[XmlEnum("22")]
		Item22,
		[XmlEnum("23")]
		Item23,
		[XmlEnum("24")]
		Item24,
		[XmlEnum("25")]
		Item25,
		[XmlEnum("26")]
		Item26,
		[XmlEnum("27")]
		Item27,
		[XmlEnum("28")]
		Item28,
		[XmlEnum("29")]
		Item29,
		[XmlEnum("30")]
		Item30,
		[XmlEnum("31")]
		Item31,
		[XmlEnum("32")]
		Item32,
		[XmlEnum("33")]
		Item33,
		[XmlEnum("34")]
		Item34,
		[XmlEnum("35")]
		Item35,
		[XmlEnum("36")]
		Item36,
		[XmlEnum("37")]
		Item37,
		[XmlEnum("38")]
		Item38,
		[XmlEnum("39")]
		Item39,
		[XmlEnum("40")]
		Item40,
		[XmlEnum("41")]
		Item41,
		[XmlEnum("42")]
		Item42,
		[XmlEnum("43")]
		Item43,
		[XmlEnum("44")]
		Item44,
		[XmlEnum("45")]
		Item45,
		[XmlEnum("46")]
		Item46,
		[XmlEnum("47")]
		Item47,
		[XmlEnum("48")]
		Item48,
		[XmlEnum("49")]
		Item49,
		[XmlEnum("50")]
		Item50,
		[XmlEnum("51")]
		Item51,
		[XmlEnum("52")]
		Item52,
		[XmlEnum("53")]
		Item53,
		[XmlEnum("54")]
		Item54,
		[XmlEnum("55")]
		Item55,
		[XmlEnum("56")]
		Item56,
		[XmlEnum("57")]
		Item57,
		[XmlEnum("58")]
		Item58,
		[XmlEnum("59")]
		Item59,
		[XmlEnum("60")]
		Item60,
		[XmlEnum("61")]
		Item61,
		[XmlEnum("62")]
		Item62,
		[XmlEnum("63")]
		Item63,
		[XmlEnum("64")]
		Item64,
		[XmlEnum("65")]
		Item65,
		[XmlEnum("66")]
		Item66,
		[XmlEnum("67")]
		Item67,
		[XmlEnum("68")]
		Item68,
		[XmlEnum("69")]
		Item69,
	}


    [Serializable()]
    [XmlType(Namespace = "urn:un:unece:uncefact:identifierlist:standard:UNECE:PaymentTermsDescriptionIdentifier:D16A")]
    public enum PaymentTermsDescriptionIdentifierContentType
    {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
    }

}