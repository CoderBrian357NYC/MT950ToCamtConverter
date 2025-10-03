/*  namespace MT950ToCamtConverter.Models
{
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AccountIdentification4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AccountIdentification4Choice
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")]
            [System.Xml.Serialization.XmlElementAttribute("IBAN")]
            public string Iban { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public GenericAccountIdentification1 Othr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GenericAccountIdentification1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GenericAccountIdentification1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 34.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(34)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SchmeNm")]
            public AccountSchemeName1Choice SchmeNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AccountSchemeName1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AccountSchemeName1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AccountInterest2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AccountInterest2
        {

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public InterestType1Choice Tp { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<Rate3> _rate;

            [System.Xml.Serialization.XmlElementAttribute("Rate")]
            public System.Collections.ObjectModel.Collection<Rate3> Rate
            {
                get
                {
                    return _rate;
                }
                private set
                {
                    _rate = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Rate collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RateSpecified
            {
                get
                {
                    return (this.Rate.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="AccountInterest2" /> class.</para>
            /// </summary>
            public AccountInterest2()
            {
                this._rate = new System.Collections.ObjectModel.Collection<Rate3>();
            }

            [System.Xml.Serialization.XmlElementAttribute("FrToDt")]
            public DateTimePeriodDetails FrToDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Rsn")]
            public string Rsn { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("InterestType1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class InterestType1Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public InterestType1Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("InterestType1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum InterestType1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("INDY")]
            Indy,

            [System.Xml.Serialization.XmlEnumAttribute("OVRN")]
            Ovrn,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("Rate3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class Rate3
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public RateType4Choice Tp { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("VldtyRg")]
            public CurrencyAndAmountRange2 VldtyRg { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("RateType4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class RateType4Choice
        {

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 10.</para>
            /// <para xml:lang="en">Total number of digits: 11.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Pctg")]
            public decimal Pctg { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Pctg property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PctgSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public string Othr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CurrencyAndAmountRange2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CurrencyAndAmountRange2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ImpliedCurrencyAmountRangeChoice Amt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Ccy")]
            public string Ccy { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ImpliedCurrencyAmountRangeChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ImpliedCurrencyAmountRangeChoice
        {

            [System.Xml.Serialization.XmlElementAttribute("FrAmt")]
            public AmountRangeBoundary1 FrAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("ToAmt")]
            public AmountRangeBoundary1 ToAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("FrToAmt")]
            public FromToAmountRange FrToAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("EQAmt")]
            public decimal EqAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the EqAmt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EqAmtSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("NEQAmt")]
            public decimal NeqAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the NeqAmt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NeqAmtSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AmountRangeBoundary1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AmountRangeBoundary1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("BdryAmt")]
            public decimal BdryAmt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Incl")]
            public bool Incl { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("FromToAmountRange", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class FromToAmountRange
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("FrAmt")]
            public AmountRangeBoundary1 FrAmt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("ToAmt")]
            public AmountRangeBoundary1 ToAmt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CreditDebitCode", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum CreditDebitCode
        {

            [System.Xml.Serialization.XmlEnumAttribute("CRDT")]
            Crdt,

            [System.Xml.Serialization.XmlEnumAttribute("DBIT")]
            Dbit,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DateTimePeriodDetails", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class DateTimePeriodDetails
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("FrDtTm", DataType = "dateTime")]
            public System.DateTime FrDtTm { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("ToDtTm", DataType = "dateTime")]
            public System.DateTime ToDtTm { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AccountStatement2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AccountStatement2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 0.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("ElctrncSeqNb")]
            public long ElctrncSeqNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the ElctrncSeqNb property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ElctrncSeqNbSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 0.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("LglSeqNb")]
            public long LglSeqNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the LglSeqNb property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LglSeqNbSpecified { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CreDtTm", DataType = "dateTime")]
            public System.DateTime CreDtTm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("FrToDt")]
            public DateTimePeriodDetails FrToDt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CpyDplctInd")]
            public CopyDuplicate1Code CpyDplctInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CpyDplctInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CpyDplctIndSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RptgSrc")]
            public ReportingSource1Choice RptgSrc { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Acct")]
            public CashAccount20 Acct { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RltdAcct")]
            public CashAccount16 RltdAcct { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<AccountInterest2> _intrst;

            [System.Xml.Serialization.XmlElementAttribute("Intrst")]
            public System.Collections.ObjectModel.Collection<AccountInterest2> Intrst
            {
                get
                {
                    return _intrst;
                }
                private set
                {
                    _intrst = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Intrst collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IntrstSpecified
            {
                get
                {
                    return (this.Intrst.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="AccountStatement2" /> class.</para>
            /// </summary>
            public AccountStatement2()
            {
                this._intrst = new System.Collections.ObjectModel.Collection<AccountInterest2>();
                this._bal = new System.Collections.ObjectModel.Collection<CashBalance3>();
                this._ntry = new System.Collections.ObjectModel.Collection<ReportEntry2>();
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<CashBalance3> _bal;

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Bal")]
            public System.Collections.ObjectModel.Collection<CashBalance3> Bal
            {
                get
                {
                    return _bal;
                }
                private set
                {
                    _bal = value;
                }
            }

            [System.Xml.Serialization.XmlElementAttribute("TxsSummry")]
            public TotalTransactions2 TxsSummry { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ReportEntry2> _ntry;

            [System.Xml.Serialization.XmlElementAttribute("Ntry")]
            public System.Collections.ObjectModel.Collection<ReportEntry2> Ntry
            {
                get
                {
                    return _ntry;
                }
                private set
                {
                    _ntry = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Ntry collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NtrySpecified
            {
                get
                {
                    return (this.Ntry.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 500.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(500)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlStmtInf")]
            public string AddtlStmtInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CopyDuplicate1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum CopyDuplicate1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("CODU")]
            Codu,

            [System.Xml.Serialization.XmlEnumAttribute("COPY")]
            Copy,

            [System.Xml.Serialization.XmlEnumAttribute("DUPL")]
            Dupl,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReportingSource1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReportingSource1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashAccount20", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashAccount20
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public AccountIdentification4Choice Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public CashAccountType2 Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.Xml.Serialization.XmlElementAttribute("Ccy")]
            public string Ccy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 70.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Ownr")]
            public PartyIdentification32 Ownr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Svcr")]
            public BranchAndFinancialInstitutionIdentification4 Svcr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashAccountType2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashAccountType2
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public CashAccountType4Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashAccountType4Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum CashAccountType4Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("CASH")]
            Cash,

            [System.Xml.Serialization.XmlEnumAttribute("CHAR")]
            Char,

            [System.Xml.Serialization.XmlEnumAttribute("COMM")]
            Comm,

            [System.Xml.Serialization.XmlEnumAttribute("TAXE")]
            Taxe,

            [System.Xml.Serialization.XmlEnumAttribute("CISH")]
            Cish,

            [System.Xml.Serialization.XmlEnumAttribute("TRAS")]
            Tras,

            [System.Xml.Serialization.XmlEnumAttribute("SACC")]
            Sacc,

            [System.Xml.Serialization.XmlEnumAttribute("CACC")]
            Cacc,

            [System.Xml.Serialization.XmlEnumAttribute("SVGS")]
            Svgs,

            [System.Xml.Serialization.XmlEnumAttribute("ONDP")]
            Ondp,

            [System.Xml.Serialization.XmlEnumAttribute("MGLD")]
            Mgld,

            [System.Xml.Serialization.XmlEnumAttribute("NREX")]
            Nrex,

            [System.Xml.Serialization.XmlEnumAttribute("MOMA")]
            Moma,

            [System.Xml.Serialization.XmlEnumAttribute("LOAN")]
            Loan,

            [System.Xml.Serialization.XmlEnumAttribute("SLRY")]
            Slry,

            [System.Xml.Serialization.XmlEnumAttribute("ODFT")]
            Odft,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("PartyIdentification32", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class PartyIdentification32
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("PstlAdr")]
            public PostalAddress6 PstlAdr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public Party6Choice Id { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{2,2}")]
            [System.Xml.Serialization.XmlElementAttribute("CtryOfRes")]
            public string CtryOfRes { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CtctDtls")]
            public ContactDetails2 CtctDtls { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("PostalAddress6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class PostalAddress6
        {

            [System.Xml.Serialization.XmlElementAttribute("AdrTp")]
            public AddressType2Code AdrTp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the AdrTp property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AdrTpSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 70.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
            [System.Xml.Serialization.XmlElementAttribute("Dept")]
            public string Dept { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 70.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
            [System.Xml.Serialization.XmlElementAttribute("SubDept")]
            public string SubDept { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 70.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
            [System.Xml.Serialization.XmlElementAttribute("StrtNm")]
            public string StrtNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 16.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
            [System.Xml.Serialization.XmlElementAttribute("BldgNb")]
            public string BldgNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 16.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(16)]
            [System.Xml.Serialization.XmlElementAttribute("PstCd")]
            public string PstCd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TwnNm")]
            public string TwnNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("CtrySubDvsn")]
            public string CtrySubDvsn { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{2,2}")]
            [System.Xml.Serialization.XmlElementAttribute("Ctry")]
            public string Ctry { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<string> _adrLine;

            [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
            public System.Collections.ObjectModel.Collection<string> AdrLine
            {
                get
                {
                    return _adrLine;
                }
                private set
                {
                    _adrLine = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the AdrLine collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AdrLineSpecified
            {
                get
                {
                    return (this.AdrLine.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="PostalAddress6" /> class.</para>
            /// </summary>
            public PostalAddress6()
            {
                this._adrLine = new System.Collections.ObjectModel.Collection<string>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AddressType2Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum AddressType2Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("ADDR")]
            Addr,

            [System.Xml.Serialization.XmlEnumAttribute("PBOX")]
            Pbox,

            [System.Xml.Serialization.XmlEnumAttribute("HOME")]
            Home,

            [System.Xml.Serialization.XmlEnumAttribute("BIZZ")]
            Bizz,

            [System.Xml.Serialization.XmlEnumAttribute("MLTO")]
            Mlto,

            [System.Xml.Serialization.XmlEnumAttribute("DLVY")]
            Dlvy,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("Party6Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class Party6Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("OrgId")]
            public OrganisationIdentification4 OrgId { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("PrvtId")]
            public PersonIdentification5 PrvtId { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("OrganisationIdentification4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class OrganisationIdentification4
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
            [System.Xml.Serialization.XmlElementAttribute("BICOrBEI")]
            public string BicOrBei { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<GenericOrganisationIdentification1> _othr;

            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public System.Collections.ObjectModel.Collection<GenericOrganisationIdentification1> Othr
            {
                get
                {
                    return _othr;
                }
                private set
                {
                    _othr = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Othr collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool OthrSpecified
            {
                get
                {
                    return (this.Othr.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="OrganisationIdentification4" /> class.</para>
            /// </summary>
            public OrganisationIdentification4()
            {
                this._othr = new System.Collections.ObjectModel.Collection<GenericOrganisationIdentification1>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GenericOrganisationIdentification1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GenericOrganisationIdentification1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SchmeNm")]
            public OrganisationIdentificationSchemeName1Choice SchmeNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("OrganisationIdentificationSchemeName1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class OrganisationIdentificationSchemeName1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("PersonIdentification5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class PersonIdentification5
        {

            [System.Xml.Serialization.XmlElementAttribute("DtAndPlcOfBirth")]
            public DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<GenericPersonIdentification1> _othr;

            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public System.Collections.ObjectModel.Collection<GenericPersonIdentification1> Othr
            {
                get
                {
                    return _othr;
                }
                private set
                {
                    _othr = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Othr collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool OthrSpecified
            {
                get
                {
                    return (this.Othr.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="PersonIdentification5" /> class.</para>
            /// </summary>
            public PersonIdentification5()
            {
                this._othr = new System.Collections.ObjectModel.Collection<GenericPersonIdentification1>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DateAndPlaceOfBirth", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class DateAndPlaceOfBirth
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("BirthDt", DataType = "date")]
            public System.DateTime BirthDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("PrvcOfBirth")]
            public string PrvcOfBirth { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("CityOfBirth")]
            public string CityOfBirth { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{2,2}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{2,2}")]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CtryOfBirth")]
            public string CtryOfBirth { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GenericPersonIdentification1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GenericPersonIdentification1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SchmeNm")]
            public PersonIdentificationSchemeName1Choice SchmeNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("PersonIdentificationSchemeName1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class PersonIdentificationSchemeName1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ContactDetails2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ContactDetails2
        {

            [System.Xml.Serialization.XmlElementAttribute("NmPrfx")]
            public NamePrefix1Code NmPrfx { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the NmPrfx property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NmPrfxSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            [System.Xml.Serialization.XmlElementAttribute("PhneNb")]
            public string PhneNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            [System.Xml.Serialization.XmlElementAttribute("MobNb")]
            public string MobNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: \+[0-9]{1,3}-[0-9()+\-]{1,30}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\+[0-9]{1,3}-[0-9()+\\-]{1,30}")]
            [System.Xml.Serialization.XmlElementAttribute("FaxNb")]
            public string FaxNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 2048.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(2048)]
            [System.Xml.Serialization.XmlElementAttribute("EmailAdr")]
            public string EmailAdr { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public string Othr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("NamePrefix1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum NamePrefix1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("DOCT")]
            Doct,

            [System.Xml.Serialization.XmlEnumAttribute("MIST")]
            Mist,

            [System.Xml.Serialization.XmlEnumAttribute("MISS")]
            Miss,

            [System.Xml.Serialization.XmlEnumAttribute("MADM")]
            Madm,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BranchAndFinancialInstitutionIdentification4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BranchAndFinancialInstitutionIdentification4
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("FinInstnId")]
            public FinancialInstitutionIdentification7 FinInstnId { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("BrnchId")]
            public BranchData2 BrnchId { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("FinancialInstitutionIdentification7", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class FinancialInstitutionIdentification7
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}")]
            [System.Xml.Serialization.XmlElementAttribute("BIC")]
            public string Bic { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("ClrSysMmbId")]
            public ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("PstlAdr")]
            public PostalAddress6 PstlAdr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Othr")]
            public GenericFinancialIdentification1 Othr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ClearingSystemMemberIdentification2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ClearingSystemMemberIdentification2
        {

            [System.Xml.Serialization.XmlElementAttribute("ClrSysId")]
            public ClearingSystemIdentification2Choice ClrSysId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("MmbId")]
            public string MmbId { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ClearingSystemIdentification2Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ClearingSystemIdentification2Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 5.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(5)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GenericFinancialIdentification1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GenericFinancialIdentification1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SchmeNm")]
            public FinancialIdentificationSchemeName1Choice SchmeNm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("FinancialIdentificationSchemeName1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class FinancialIdentificationSchemeName1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BranchData2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BranchData2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("PstlAdr")]
            public PostalAddress6 PstlAdr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashAccount16", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashAccount16
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public AccountIdentification4Choice Id { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public CashAccountType2 Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.Xml.Serialization.XmlElementAttribute("Ccy")]
            public string Ccy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 70.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(70)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashBalance3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashBalance3
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public BalanceType12 Tp { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtLine")]
            public CreditLine2 CdtLine { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Dt")]
            public DateAndDateTimeChoice Dt { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

            [System.Xml.Serialization.XmlElementAttribute("Avlbty")]
            public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
            {
                get
                {
                    return _avlbty;
                }
                private set
                {
                    _avlbty = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AvlbtySpecified
            {
                get
                {
                    return (this.Avlbty.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="CashBalance3" /> class.</para>
            /// </summary>
            public CashBalance3()
            {
                this._avlbty = new System.Collections.ObjectModel.Collection<CashBalanceAvailability2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BalanceType12", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BalanceType12
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdOrPrtry")]
            public BalanceType5Choice CdOrPrtry { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SubTp")]
            public BalanceSubType1Choice SubTp { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BalanceType5Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BalanceType5Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public BalanceType12Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BalanceType12Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum BalanceType12Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("XPCD")]
            Xpcd,

            [System.Xml.Serialization.XmlEnumAttribute("OPAV")]
            Opav,

            [System.Xml.Serialization.XmlEnumAttribute("ITAV")]
            Itav,

            [System.Xml.Serialization.XmlEnumAttribute("CLAV")]
            Clav,

            [System.Xml.Serialization.XmlEnumAttribute("FWAV")]
            Fwav,

            [System.Xml.Serialization.XmlEnumAttribute("CLBD")]
            Clbd,

            [System.Xml.Serialization.XmlEnumAttribute("ITBD")]
            Itbd,

            [System.Xml.Serialization.XmlEnumAttribute("OPBD")]
            Opbd,

            [System.Xml.Serialization.XmlEnumAttribute("PRCD")]
            Prcd,

            [System.Xml.Serialization.XmlEnumAttribute("INFO")]
            Info,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BalanceSubType1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BalanceSubType1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CreditLine2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CreditLine2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Incl")]
            public bool Incl { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ActiveOrHistoricCurrencyAndAmount", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ActiveOrHistoricCurrencyAndAmount
        {

            /// <summary>
            /// <para xml:lang="en">Gets or sets the text value.</para>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlAttributeAttribute("Ccy")]
            public string Ccy { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DateAndDateTimeChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class DateAndDateTimeChoice
        {

            [System.Xml.Serialization.XmlElementAttribute("Dt", DataType = "date")]
            public System.DateTime Dt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Dt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("DtTm", DataType = "dateTime")]
            public System.DateTime DtTm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the DtTm property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DtTmSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashBalanceAvailability2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashBalanceAvailability2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Dt")]
            public CashBalanceAvailabilityDate1 Dt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CashBalanceAvailabilityDate1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CashBalanceAvailabilityDate1
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [+]{0,1}[0-9]{1,15}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[+]{0,1}[0-9]{1,15}")]
            [System.Xml.Serialization.XmlElementAttribute("NbOfDays")]
            public string NbOfDays { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("ActlDt", DataType = "date")]
            public System.DateTime ActlDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the ActlDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ActlDtSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TotalTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TotalTransactions2
        {

            [System.Xml.Serialization.XmlElementAttribute("TtlNtries")]
            public NumberAndSumOfTransactions2 TtlNtries { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlCdtNtries")]
            public NumberAndSumOfTransactions1 TtlCdtNtries { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlDbtNtries")]
            public NumberAndSumOfTransactions1 TtlDbtNtries { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TotalsPerBankTransactionCode2> _ttlNtriesPerBkTxCd;

            [System.Xml.Serialization.XmlElementAttribute("TtlNtriesPerBkTxCd")]
            public System.Collections.ObjectModel.Collection<TotalsPerBankTransactionCode2> TtlNtriesPerBkTxCd
            {
                get
                {
                    return _ttlNtriesPerBkTxCd;
                }
                private set
                {
                    _ttlNtriesPerBkTxCd = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the TtlNtriesPerBkTxCd collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TtlNtriesPerBkTxCdSpecified
            {
                get
                {
                    return (this.TtlNtriesPerBkTxCd.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TotalTransactions2" /> class.</para>
            /// </summary>
            public TotalTransactions2()
            {
                this._ttlNtriesPerBkTxCd = new System.Collections.ObjectModel.Collection<TotalsPerBankTransactionCode2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("NumberAndSumOfTransactions2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class NumberAndSumOfTransactions2
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,15}")]
            [System.Xml.Serialization.XmlElementAttribute("NbOfNtries")]
            public string NbOfNtries { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Sum")]
            public decimal Sum { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Sum property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SumSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("TtlNetNtryAmt")]
            public decimal TtlNetNtryAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the TtlNetNtryAmt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TtlNetNtryAmtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("NumberAndSumOfTransactions1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class NumberAndSumOfTransactions1
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,15}")]
            [System.Xml.Serialization.XmlElementAttribute("NbOfNtries")]
            public string NbOfNtries { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Sum")]
            public decimal Sum { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Sum property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SumSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TotalsPerBankTransactionCode2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TotalsPerBankTransactionCode2
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,15}")]
            [System.Xml.Serialization.XmlElementAttribute("NbOfNtries")]
            public string NbOfNtries { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Sum")]
            public decimal Sum { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Sum property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SumSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("TtlNetNtryAmt")]
            public decimal TtlNetNtryAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the TtlNetNtryAmt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TtlNetNtryAmtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("FcstInd")]
            public bool FcstInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the FcstInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool FcstIndSpecified { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("BkTxCd")]
            public BankTransactionCodeStructure4 BkTxCd { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

            [System.Xml.Serialization.XmlElementAttribute("Avlbty")]
            public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
            {
                get
                {
                    return _avlbty;
                }
                private set
                {
                    _avlbty = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AvlbtySpecified
            {
                get
                {
                    return (this.Avlbty.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TotalsPerBankTransactionCode2" /> class.</para>
            /// </summary>
            public TotalsPerBankTransactionCode2()
            {
                this._avlbty = new System.Collections.ObjectModel.Collection<CashBalanceAvailability2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BankTransactionCodeStructure4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BankTransactionCodeStructure4
        {

            [System.Xml.Serialization.XmlElementAttribute("Domn")]
            public BankTransactionCodeStructure5 Domn { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public ProprietaryBankTransactionCodeStructure1 Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BankTransactionCodeStructure5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BankTransactionCodeStructure5
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Fmly")]
            public BankTransactionCodeStructure6 Fmly { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BankTransactionCodeStructure6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BankTransactionCodeStructure6
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("SubFmlyCd")]
            public string SubFmlyCd { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryBankTransactionCodeStructure1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryBankTransactionCodeStructure1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReportEntry2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReportEntry2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("NtryRef")]
            public string NtryRef { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RvslInd")]
            public bool RvslInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the RvslInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RvslIndSpecified { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Sts")]
            public EntryStatus2Code Sts { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("BookgDt")]
            public DateAndDateTimeChoice BookgDt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("ValDt")]
            public DateAndDateTimeChoice ValDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("AcctSvcrRef")]
            public string AcctSvcrRef { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

            [System.Xml.Serialization.XmlElementAttribute("Avlbty")]
            public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
            {
                get
                {
                    return _avlbty;
                }
                private set
                {
                    _avlbty = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AvlbtySpecified
            {
                get
                {
                    return (this.Avlbty.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="ReportEntry2" /> class.</para>
            /// </summary>
            public ReportEntry2()
            {
                this._avlbty = new System.Collections.ObjectModel.Collection<CashBalanceAvailability2>();
                this._chrgs = new System.Collections.ObjectModel.Collection<ChargesInformation6>();
                this._intrst = new System.Collections.ObjectModel.Collection<TransactionInterest2>();
                this._ntryDtls = new System.Collections.ObjectModel.Collection<EntryDetails1>();
            }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("BkTxCd")]
            public BankTransactionCodeStructure4 BkTxCd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("ComssnWvrInd")]
            public bool ComssnWvrInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the ComssnWvrInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ComssnWvrIndSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("AddtlInfInd")]
            public MessageIdentification2 AddtlInfInd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("AmtDtls")]
            public AmountAndCurrencyExchange3 AmtDtls { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ChargesInformation6> _chrgs;

            [System.Xml.Serialization.XmlElementAttribute("Chrgs")]
            public System.Collections.ObjectModel.Collection<ChargesInformation6> Chrgs
            {
                get
                {
                    return _chrgs;
                }
                private set
                {
                    _chrgs = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Chrgs collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChrgsSpecified
            {
                get
                {
                    return (this.Chrgs.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlElementAttribute("TechInptChanl")]
            public TechnicalInputChannel1Choice TechInptChanl { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TransactionInterest2> _intrst;

            [System.Xml.Serialization.XmlElementAttribute("Intrst")]
            public System.Collections.ObjectModel.Collection<TransactionInterest2> Intrst
            {
                get
                {
                    return _intrst;
                }
                private set
                {
                    _intrst = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Intrst collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IntrstSpecified
            {
                get
                {
                    return (this.Intrst.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<EntryDetails1> _ntryDtls;

            [System.Xml.Serialization.XmlElementAttribute("NtryDtls")]
            public System.Collections.ObjectModel.Collection<EntryDetails1> NtryDtls
            {
                get
                {
                    return _ntryDtls;
                }
                private set
                {
                    _ntryDtls = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the NtryDtls collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NtryDtlsSpecified
            {
                get
                {
                    return (this.NtryDtls.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 500.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(500)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlNtryInf")]
            public string AddtlNtryInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("EntryStatus2Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum EntryStatus2Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("BOOK")]
            Book,

            [System.Xml.Serialization.XmlEnumAttribute("PDNG")]
            Pdng,

            [System.Xml.Serialization.XmlEnumAttribute("INFO")]
            Info,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("MessageIdentification2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class MessageIdentification2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("MsgNmId")]
            public string MsgNmId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("MsgId")]
            public string MsgId { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AmountAndCurrencyExchange3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AmountAndCurrencyExchange3
        {

            [System.Xml.Serialization.XmlElementAttribute("InstdAmt")]
            public AmountAndCurrencyExchangeDetails3 InstdAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TxAmt")]
            public AmountAndCurrencyExchangeDetails3 TxAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CntrValAmt")]
            public AmountAndCurrencyExchangeDetails3 CntrValAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("AnncdPstngAmt")]
            public AmountAndCurrencyExchangeDetails3 AnncdPstngAmt { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<AmountAndCurrencyExchangeDetails4> _prtryAmt;

            [System.Xml.Serialization.XmlElementAttribute("PrtryAmt")]
            public System.Collections.ObjectModel.Collection<AmountAndCurrencyExchangeDetails4> PrtryAmt
            {
                get
                {
                    return _prtryAmt;
                }
                private set
                {
                    _prtryAmt = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the PrtryAmt collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PrtryAmtSpecified
            {
                get
                {
                    return (this.PrtryAmt.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="AmountAndCurrencyExchange3" /> class.</para>
            /// </summary>
            public AmountAndCurrencyExchange3()
            {
                this._prtryAmt = new System.Collections.ObjectModel.Collection<AmountAndCurrencyExchangeDetails4>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AmountAndCurrencyExchangeDetails3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AmountAndCurrencyExchangeDetails3
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CcyXchg")]
            public CurrencyExchange5 CcyXchg { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CurrencyExchange5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CurrencyExchange5
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("SrcCcy")]
            public string SrcCcy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.Xml.Serialization.XmlElementAttribute("TrgtCcy")]
            public string TrgtCcy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z]{3,3}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z]{3,3}")]
            [System.Xml.Serialization.XmlElementAttribute("UnitCcy")]
            public string UnitCcy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 10.</para>
            /// <para xml:lang="en">Total number of digits: 11.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("XchgRate")]
            public decimal XchgRate { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("CtrctId")]
            public string CtrctId { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("QtnDt", DataType = "dateTime")]
            public System.DateTime QtnDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the QtnDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool QtnDtSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AmountAndCurrencyExchangeDetails4", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AmountAndCurrencyExchangeDetails4
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CcyXchg")]
            public CurrencyExchange5 CcyXchg { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ChargesInformation6", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ChargesInformation6
        {

            [System.Xml.Serialization.XmlElementAttribute("TtlChrgsAndTaxAmt")]
            public ActiveOrHistoricCurrencyAndAmount TtlChrgsAndTaxAmt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public ChargeType2Choice Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 10.</para>
            /// <para xml:lang="en">Total number of digits: 11.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Rate")]
            public decimal Rate { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RateSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Br")]
            public ChargeBearerType1Code Br { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Br property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool BrSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Pty")]
            public BranchAndFinancialInstitutionIdentification4 Pty { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tax")]
            public TaxCharges2 Tax { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ChargeType2Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ChargeType2Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public ChargeType1Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public GenericIdentification3 Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ChargeType1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum ChargeType1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("BRKF")]
            Brkf,

            [System.Xml.Serialization.XmlEnumAttribute("COMM")]
            Comm,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GenericIdentification3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GenericIdentification3
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ChargeBearerType1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum ChargeBearerType1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("DEBT")]
            Debt,

            [System.Xml.Serialization.XmlEnumAttribute("CRED")]
            Cred,

            [System.Xml.Serialization.XmlEnumAttribute("SHAR")]
            Shar,

            [System.Xml.Serialization.XmlEnumAttribute("SLEV")]
            Slev,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxCharges2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxCharges2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 10.</para>
            /// <para xml:lang="en">Total number of digits: 11.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Rate")]
            public decimal Rate { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RateSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TechnicalInputChannel1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TechnicalInputChannel1Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionInterest2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionInterest2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public InterestType1Choice Tp { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<Rate3> _rate;

            [System.Xml.Serialization.XmlElementAttribute("Rate")]
            public System.Collections.ObjectModel.Collection<Rate3> Rate
            {
                get
                {
                    return _rate;
                }
                private set
                {
                    _rate = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Rate collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RateSpecified
            {
                get
                {
                    return (this.Rate.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionInterest2" /> class.</para>
            /// </summary>
            public TransactionInterest2()
            {
                this._rate = new System.Collections.ObjectModel.Collection<Rate3>();
            }

            [System.Xml.Serialization.XmlElementAttribute("FrToDt")]
            public DateTimePeriodDetails FrToDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Rsn")]
            public string Rsn { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("EntryDetails1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class EntryDetails1
        {

            [System.Xml.Serialization.XmlElementAttribute("Btch")]
            public BatchInformation2 Btch { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<EntryTransaction2> _txDtls;

            [System.Xml.Serialization.XmlElementAttribute("TxDtls")]
            public System.Collections.ObjectModel.Collection<EntryTransaction2> TxDtls
            {
                get
                {
                    return _txDtls;
                }
                private set
                {
                    _txDtls = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the TxDtls collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TxDtlsSpecified
            {
                get
                {
                    return (this.TxDtls.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="EntryDetails1" /> class.</para>
            /// </summary>
            public EntryDetails1()
            {
                this._txDtls = new System.Collections.ObjectModel.Collection<EntryTransaction2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BatchInformation2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BatchInformation2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("MsgId")]
            public string MsgId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("PmtInfId")]
            public string PmtInfId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Pattern: [0-9]{1,15}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,15}")]
            [System.Xml.Serialization.XmlElementAttribute("NbOfTxs")]
            public string NbOfTxs { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlAmt")]
            public ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("EntryTransaction2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class EntryTransaction2
        {

            [System.Xml.Serialization.XmlElementAttribute("Refs")]
            public TransactionReferences2 Refs { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("AmtDtls")]
            public AmountAndCurrencyExchange3 AmtDtls { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<CashBalanceAvailability2> _avlbty;

            [System.Xml.Serialization.XmlElementAttribute("Avlbty")]
            public System.Collections.ObjectModel.Collection<CashBalanceAvailability2> Avlbty
            {
                get
                {
                    return _avlbty;
                }
                private set
                {
                    _avlbty = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Avlbty collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AvlbtySpecified
            {
                get
                {
                    return (this.Avlbty.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="EntryTransaction2" /> class.</para>
            /// </summary>
            public EntryTransaction2()
            {
                this._avlbty = new System.Collections.ObjectModel.Collection<CashBalanceAvailability2>();
                this._chrgs = new System.Collections.ObjectModel.Collection<ChargesInformation6>();
                this._intrst = new System.Collections.ObjectModel.Collection<TransactionInterest2>();
                this._rltdRmtInf = new System.Collections.ObjectModel.Collection<RemittanceLocation2>();
                this._rltdQties = new System.Collections.ObjectModel.Collection<TransactionQuantities1Choice>();
            }

            [System.Xml.Serialization.XmlElementAttribute("BkTxCd")]
            public BankTransactionCodeStructure4 BkTxCd { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ChargesInformation6> _chrgs;

            [System.Xml.Serialization.XmlElementAttribute("Chrgs")]
            public System.Collections.ObjectModel.Collection<ChargesInformation6> Chrgs
            {
                get
                {
                    return _chrgs;
                }
                private set
                {
                    _chrgs = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Chrgs collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChrgsSpecified
            {
                get
                {
                    return (this.Chrgs.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TransactionInterest2> _intrst;

            [System.Xml.Serialization.XmlElementAttribute("Intrst")]
            public System.Collections.ObjectModel.Collection<TransactionInterest2> Intrst
            {
                get
                {
                    return _intrst;
                }
                private set
                {
                    _intrst = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Intrst collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IntrstSpecified
            {
                get
                {
                    return (this.Intrst.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlElementAttribute("RltdPties")]
            public TransactionParty2 RltdPties { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RltdAgts")]
            public TransactionAgents2 RltdAgts { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Purp")]
            public Purpose2Choice Purp { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<RemittanceLocation2> _rltdRmtInf;

            [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
            public System.Collections.ObjectModel.Collection<RemittanceLocation2> RltdRmtInf
            {
                get
                {
                    return _rltdRmtInf;
                }
                private set
                {
                    _rltdRmtInf = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the RltdRmtInf collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RltdRmtInfSpecified
            {
                get
                {
                    return (this.RltdRmtInf.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlElementAttribute("RmtInf")]
            public RemittanceInformation5 RmtInf { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RltdDts")]
            public TransactionDates2 RltdDts { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RltdPric")]
            public TransactionPrice2Choice RltdPric { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TransactionQuantities1Choice> _rltdQties;

            [System.Xml.Serialization.XmlElementAttribute("RltdQties")]
            public System.Collections.ObjectModel.Collection<TransactionQuantities1Choice> RltdQties
            {
                get
                {
                    return _rltdQties;
                }
                private set
                {
                    _rltdQties = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the RltdQties collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RltdQtiesSpecified
            {
                get
                {
                    return (this.RltdQties.Count != 0);
                }
            }

            [System.Xml.Serialization.XmlElementAttribute("FinInstrmId")]
            public SecurityIdentification4Choice FinInstrmId { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tax")]
            public TaxInformation3 Tax { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RtrInf")]
            public ReturnReasonInformation10 RtrInf { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CorpActn")]
            public CorporateAction1 CorpActn { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SfkpgAcct")]
            public CashAccount16 SfkpgAcct { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 500.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(500)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlTxInf")]
            public string AddtlTxInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionReferences2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionReferences2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("MsgId")]
            public string MsgId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("AcctSvcrRef")]
            public string AcctSvcrRef { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("PmtInfId")]
            public string PmtInfId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("InstrId")]
            public string InstrId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("EndToEndId")]
            public string EndToEndId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TxId")]
            public string TxId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("MndtId")]
            public string MndtId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("ChqNb")]
            public string ChqNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("ClrSysRef")]
            public string ClrSysRef { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public ProprietaryReference1 Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryReference1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryReference1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Ref")]
            public string Ref { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionParty2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionParty2
        {

            [System.Xml.Serialization.XmlElementAttribute("InitgPty")]
            public PartyIdentification32 InitgPty { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Dbtr")]
            public PartyIdentification32 Dbtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("DbtrAcct")]
            public CashAccount16 DbtrAcct { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("UltmtDbtr")]
            public PartyIdentification32 UltmtDbtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Cdtr")]
            public PartyIdentification32 Cdtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtrAcct")]
            public CashAccount16 CdtrAcct { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("UltmtCdtr")]
            public PartyIdentification32 UltmtCdtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TradgPty")]
            public PartyIdentification32 TradgPty { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ProprietaryParty2> _prtry;

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public System.Collections.ObjectModel.Collection<ProprietaryParty2> Prtry
            {
                get
                {
                    return _prtry;
                }
                private set
                {
                    _prtry = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PrtrySpecified
            {
                get
                {
                    return (this.Prtry.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionParty2" /> class.</para>
            /// </summary>
            public TransactionParty2()
            {
                this._prtry = new System.Collections.ObjectModel.Collection<ProprietaryParty2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryParty2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryParty2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Pty")]
            public PartyIdentification32 Pty { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionAgents2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionAgents2
        {

            [System.Xml.Serialization.XmlElementAttribute("DbtrAgt")]
            public BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtrAgt")]
            public BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("IntrmyAgt1")]
            public BranchAndFinancialInstitutionIdentification4 IntrmyAgt1 { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("IntrmyAgt2")]
            public BranchAndFinancialInstitutionIdentification4 IntrmyAgt2 { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("IntrmyAgt3")]
            public BranchAndFinancialInstitutionIdentification4 IntrmyAgt3 { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RcvgAgt")]
            public BranchAndFinancialInstitutionIdentification4 RcvgAgt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("DlvrgAgt")]
            public BranchAndFinancialInstitutionIdentification4 DlvrgAgt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("IssgAgt")]
            public BranchAndFinancialInstitutionIdentification4 IssgAgt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("SttlmPlc")]
            public BranchAndFinancialInstitutionIdentification4 SttlmPlc { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ProprietaryAgent2> _prtry;

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public System.Collections.ObjectModel.Collection<ProprietaryAgent2> Prtry
            {
                get
                {
                    return _prtry;
                }
                private set
                {
                    _prtry = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PrtrySpecified
            {
                get
                {
                    return (this.Prtry.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionAgents2" /> class.</para>
            /// </summary>
            public TransactionAgents2()
            {
                this._prtry = new System.Collections.ObjectModel.Collection<ProprietaryAgent2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryAgent2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryAgent2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Agt")]
            public BranchAndFinancialInstitutionIdentification4 Agt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("Purpose2Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class Purpose2Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("RemittanceLocation2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class RemittanceLocation2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("RmtId")]
            public string RmtId { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RmtLctnMtd")]
            public RemittanceLocationMethod2Code RmtLctnMtd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the RmtLctnMtd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RmtLctnMtdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 2048.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(2048)]
            [System.Xml.Serialization.XmlElementAttribute("RmtLctnElctrncAdr")]
            public string RmtLctnElctrncAdr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RmtLctnPstlAdr")]
            public NameAndAddress10 RmtLctnPstlAdr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("RemittanceLocationMethod2Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum RemittanceLocationMethod2Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("FAXI")]
            Faxi,

            [System.Xml.Serialization.XmlEnumAttribute("EDIC")]
            Edic,

            [System.Xml.Serialization.XmlEnumAttribute("URID")]
            Urid,

            [System.Xml.Serialization.XmlEnumAttribute("EMAL")]
            Emal,

            [System.Xml.Serialization.XmlEnumAttribute("POST")]
            Post,

            [System.Xml.Serialization.XmlEnumAttribute("SMSM")]
            Smsm,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("NameAndAddress10", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class NameAndAddress10
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Adr")]
            public PostalAddress6 Adr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("RemittanceInformation5", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class RemittanceInformation5
        {

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<string> _ustrd;

            [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
            public System.Collections.ObjectModel.Collection<string> Ustrd
            {
                get
                {
                    return _ustrd;
                }
                private set
                {
                    _ustrd = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Ustrd collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool UstrdSpecified
            {
                get
                {
                    return (this.Ustrd.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="RemittanceInformation5" /> class.</para>
            /// </summary>
            public RemittanceInformation5()
            {
                this._ustrd = new System.Collections.ObjectModel.Collection<string>();
                this._strd = new System.Collections.ObjectModel.Collection<StructuredRemittanceInformation7>();
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<StructuredRemittanceInformation7> _strd;

            [System.Xml.Serialization.XmlElementAttribute("Strd")]
            public System.Collections.ObjectModel.Collection<StructuredRemittanceInformation7> Strd
            {
                get
                {
                    return _strd;
                }
                private set
                {
                    _strd = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Strd collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool StrdSpecified
            {
                get
                {
                    return (this.Strd.Count != 0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("StructuredRemittanceInformation7", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class StructuredRemittanceInformation7
        {

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ReferredDocumentInformation3> _rfrdDocInf;

            [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
            public System.Collections.ObjectModel.Collection<ReferredDocumentInformation3> RfrdDocInf
            {
                get
                {
                    return _rfrdDocInf;
                }
                private set
                {
                    _rfrdDocInf = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the RfrdDocInf collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RfrdDocInfSpecified
            {
                get
                {
                    return (this.RfrdDocInf.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="StructuredRemittanceInformation7" /> class.</para>
            /// </summary>
            public StructuredRemittanceInformation7()
            {
                this._rfrdDocInf = new System.Collections.ObjectModel.Collection<ReferredDocumentInformation3>();
                this._addtlRmtInf = new System.Collections.ObjectModel.Collection<string>();
            }

            [System.Xml.Serialization.XmlElementAttribute("RfrdDocAmt")]
            public RemittanceAmount1 RfrdDocAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtrRefInf")]
            public CreditorReferenceInformation2 CdtrRefInf { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Invcr")]
            public PartyIdentification32 Invcr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Invcee")]
            public PartyIdentification32 Invcee { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<string> _addtlRmtInf;

            [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
            public System.Collections.ObjectModel.Collection<string> AddtlRmtInf
            {
                get
                {
                    return _addtlRmtInf;
                }
                private set
                {
                    _addtlRmtInf = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the AddtlRmtInf collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AddtlRmtInfSpecified
            {
                get
                {
                    return (this.AddtlRmtInf.Count != 0);
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReferredDocumentInformation3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReferredDocumentInformation3
        {

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public ReferredDocumentType2 Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Nb")]
            public string Nb { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("RltdDt", DataType = "date")]
            public System.DateTime RltdDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the RltdDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RltdDtSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReferredDocumentType2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReferredDocumentType2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdOrPrtry")]
            public ReferredDocumentType1Choice CdOrPrtry { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReferredDocumentType1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReferredDocumentType1Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public DocumentType5Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DocumentType5Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum DocumentType5Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("MSIN")]
            Msin,

            [System.Xml.Serialization.XmlEnumAttribute("CNFA")]
            Cnfa,

            [System.Xml.Serialization.XmlEnumAttribute("DNFA")]
            Dnfa,

            [System.Xml.Serialization.XmlEnumAttribute("CINV")]
            Cinv,

            [System.Xml.Serialization.XmlEnumAttribute("CREN")]
            Cren,

            [System.Xml.Serialization.XmlEnumAttribute("DEBN")]
            Debn,

            [System.Xml.Serialization.XmlEnumAttribute("HIRI")]
            Hiri,

            [System.Xml.Serialization.XmlEnumAttribute("SBIN")]
            Sbin,

            [System.Xml.Serialization.XmlEnumAttribute("CMCN")]
            Cmcn,

            [System.Xml.Serialization.XmlEnumAttribute("SOAC")]
            Soac,

            [System.Xml.Serialization.XmlEnumAttribute("DISP")]
            Disp,

            [System.Xml.Serialization.XmlEnumAttribute("BOLD")]
            Bold,

            [System.Xml.Serialization.XmlEnumAttribute("VCHR")]
            Vchr,

            [System.Xml.Serialization.XmlEnumAttribute("AROI")]
            Aroi,

            [System.Xml.Serialization.XmlEnumAttribute("TSUT")]
            Tsut,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("RemittanceAmount1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class RemittanceAmount1
        {

            [System.Xml.Serialization.XmlElementAttribute("DuePyblAmt")]
            public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt")]
            public ActiveOrHistoricCurrencyAndAmount DscntApldAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtNoteAmt")]
            public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
            public ActiveOrHistoricCurrencyAndAmount TaxAmt { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<DocumentAdjustment1> _adjstmntAmtAndRsn;

            [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
            public System.Collections.ObjectModel.Collection<DocumentAdjustment1> AdjstmntAmtAndRsn
            {
                get
                {
                    return _adjstmntAmtAndRsn;
                }
                private set
                {
                    _adjstmntAmtAndRsn = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the AdjstmntAmtAndRsn collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AdjstmntAmtAndRsnSpecified
            {
                get
                {
                    return (this.AdjstmntAmtAndRsn.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="RemittanceAmount1" /> class.</para>
            /// </summary>
            public RemittanceAmount1()
            {
                this._adjstmntAmtAndRsn = new System.Collections.ObjectModel.Collection<DocumentAdjustment1>();
            }

            [System.Xml.Serialization.XmlElementAttribute("RmtdAmt")]
            public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DocumentAdjustment1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class DocumentAdjustment1
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("CdtDbtInd")]
            public CreditDebitCode CdtDbtInd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the CdtDbtInd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdtDbtIndSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Rsn")]
            public string Rsn { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
            public string AddtlInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CreditorReferenceInformation2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CreditorReferenceInformation2
        {

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public CreditorReferenceType2 Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Ref")]
            public string Ref { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CreditorReferenceType2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CreditorReferenceType2
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CdOrPrtry")]
            public CreditorReferenceType1Choice CdOrPrtry { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Issr")]
            public string Issr { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CreditorReferenceType1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CreditorReferenceType1Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public DocumentType3Code Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Cd property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CdSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DocumentType3Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum DocumentType3Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("RADM")]
            Radm,

            [System.Xml.Serialization.XmlEnumAttribute("RPIN")]
            Rpin,

            [System.Xml.Serialization.XmlEnumAttribute("FXDR")]
            Fxdr,

            [System.Xml.Serialization.XmlEnumAttribute("DISP")]
            Disp,

            [System.Xml.Serialization.XmlEnumAttribute("PUOR")]
            Puor,

            [System.Xml.Serialization.XmlEnumAttribute("SCOR")]
            Scor,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionDates2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionDates2
        {

            [System.Xml.Serialization.XmlElementAttribute("AccptncDtTm", DataType = "dateTime")]
            public System.DateTime AccptncDtTm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the AccptncDtTm property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AccptncDtTmSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TradActvtyCtrctlSttlmDt", DataType = "date")]
            public System.DateTime TradActvtyCtrctlSttlmDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the TradActvtyCtrctlSttlmDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TradActvtyCtrctlSttlmDtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TradDt", DataType = "date")]
            public System.DateTime TradDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the TradDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TradDtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("IntrBkSttlmDt", DataType = "date")]
            public System.DateTime IntrBkSttlmDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the IntrBkSttlmDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IntrBkSttlmDtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("StartDt", DataType = "date")]
            public System.DateTime StartDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the StartDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool StartDtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("EndDt", DataType = "date")]
            public System.DateTime EndDt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the EndDt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EndDtSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TxDtTm", DataType = "dateTime")]
            public System.DateTime TxDtTm { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the TxDtTm property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TxDtTmSpecified { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ProprietaryDate2> _prtry;

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public System.Collections.ObjectModel.Collection<ProprietaryDate2> Prtry
            {
                get
                {
                    return _prtry;
                }
                private set
                {
                    _prtry = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PrtrySpecified
            {
                get
                {
                    return (this.Prtry.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionDates2" /> class.</para>
            /// </summary>
            public TransactionDates2()
            {
                this._prtry = new System.Collections.ObjectModel.Collection<ProprietaryDate2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryDate2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryDate2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Dt")]
            public DateAndDateTimeChoice Dt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionPrice2Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionPrice2Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("DealPric")]
            public ActiveOrHistoricCurrencyAndAmount DealPric { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<ProprietaryPrice2> _prtry;

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public System.Collections.ObjectModel.Collection<ProprietaryPrice2> Prtry
            {
                get
                {
                    return _prtry;
                }
                private set
                {
                    _prtry = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Prtry collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PrtrySpecified
            {
                get
                {
                    return (this.Prtry.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TransactionPrice2Choice" /> class.</para>
            /// </summary>
            public TransactionPrice2Choice()
            {
                this._prtry = new System.Collections.ObjectModel.Collection<ProprietaryPrice2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryPrice2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryPrice2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Pric")]
            public ActiveOrHistoricCurrencyAndAmount Pric { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TransactionQuantities1Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TransactionQuantities1Choice
        {

            [System.Xml.Serialization.XmlElementAttribute("Qty")]
            public FinancialInstrumentQuantityChoice Qty { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public ProprietaryQuantity1 Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("FinancialInstrumentQuantityChoice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class FinancialInstrumentQuantityChoice
        {

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 17.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Unit")]
            public decimal Unit { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Unit property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool UnitSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("FaceAmt")]
            public decimal FaceAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the FaceAmt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool FaceAmtSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum inclusive value: 0.</para>
            /// <para xml:lang="en">Total number of digits in fraction: 5.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("AmtsdVal")]
            public decimal AmtsdVal { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the AmtsdVal property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AmtsdValSpecified { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ProprietaryQuantity1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ProprietaryQuantity1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Qty")]
            public string Qty { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("SecurityIdentification4Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class SecurityIdentification4Choice
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [A-Z0-9]{12,12}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[A-Z0-9]{12,12}")]
            [System.Xml.Serialization.XmlElementAttribute("ISIN")]
            public string Isin { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public AlternateSecurityIdentification2 Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("AlternateSecurityIdentification2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class AlternateSecurityIdentification2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("Id")]
            public string Id { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxInformation3", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxInformation3
        {

            [System.Xml.Serialization.XmlElementAttribute("Cdtr")]
            public TaxParty1 Cdtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Dbtr")]
            public TaxParty2 Dbtr { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("AdmstnZn")]
            public string AdmstnZn { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("RefNb")]
            public string RefNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Mtd")]
            public string Mtd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlTaxblBaseAmt")]
            public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlTaxAmt")]
            public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Dt", DataType = "date")]
            public System.DateTime Dt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Dt property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DtSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 0.</para>
            /// <para xml:lang="en">Total number of digits: 18.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("SeqNb")]
            public long SeqNb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the SeqNb property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SeqNbSpecified { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TaxRecord1> _rcrd;

            [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
            public System.Collections.ObjectModel.Collection<TaxRecord1> Rcrd
            {
                get
                {
                    return _rcrd;
                }
                private set
                {
                    _rcrd = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Rcrd collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RcrdSpecified
            {
                get
                {
                    return (this.Rcrd.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TaxInformation3" /> class.</para>
            /// </summary>
            public TaxInformation3()
            {
                this._rcrd = new System.Collections.ObjectModel.Collection<TaxRecord1>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxParty1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxParty1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TaxId")]
            public string TaxId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("RegnId")]
            public string RegnId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TaxTp")]
            public string TaxTp { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxParty2", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxParty2
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TaxId")]
            public string TaxId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("RegnId")]
            public string RegnId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("TaxTp")]
            public string TaxTp { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Authstn")]
            public TaxAuthorisation1 Authstn { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxAuthorisation1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxAuthorisation1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Titl")]
            public string Titl { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("Nm")]
            public string Nm { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxRecord1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxRecord1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public string Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Ctgy")]
            public string Ctgy { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("CtgyDtls")]
            public string CtgyDtls { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("DbtrSts")]
            public string DbtrSts { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("CertId")]
            public string CertId { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("FrmsCd")]
            public string FrmsCd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Prd")]
            public TaxPeriod1 Prd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
            public TaxAmount1 TaxAmt { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 140.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(140)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
            public string AddtlInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxPeriod1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxPeriod1
        {

            [System.Xml.Serialization.XmlElementAttribute("Yr", DataType = "date")]
            public System.DateTime Yr { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Yr property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool YrSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Tp")]
            public TaxRecordPeriod1Code Tp { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Tp property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TpSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("FrToDt")]
            public DatePeriodDetails FrToDt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxRecordPeriod1Code", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public enum TaxRecordPeriod1Code
        {

            [System.Xml.Serialization.XmlEnumAttribute("MM01")]
            Mm01,

            [System.Xml.Serialization.XmlEnumAttribute("MM02")]
            Mm02,

            [System.Xml.Serialization.XmlEnumAttribute("MM03")]
            Mm03,

            [System.Xml.Serialization.XmlEnumAttribute("MM04")]
            Mm04,

            [System.Xml.Serialization.XmlEnumAttribute("MM05")]
            Mm05,

            [System.Xml.Serialization.XmlEnumAttribute("MM06")]
            Mm06,

            [System.Xml.Serialization.XmlEnumAttribute("MM07")]
            Mm07,

            [System.Xml.Serialization.XmlEnumAttribute("MM08")]
            Mm08,

            [System.Xml.Serialization.XmlEnumAttribute("MM09")]
            Mm09,

            [System.Xml.Serialization.XmlEnumAttribute("MM10")]
            Mm10,

            [System.Xml.Serialization.XmlEnumAttribute("MM11")]
            Mm11,

            [System.Xml.Serialization.XmlEnumAttribute("MM12")]
            Mm12,

            [System.Xml.Serialization.XmlEnumAttribute("QTR1")]
            Qtr1,

            [System.Xml.Serialization.XmlEnumAttribute("QTR2")]
            Qtr2,

            [System.Xml.Serialization.XmlEnumAttribute("QTR3")]
            Qtr3,

            [System.Xml.Serialization.XmlEnumAttribute("QTR4")]
            Qtr4,

            [System.Xml.Serialization.XmlEnumAttribute("HLF1")]
            Hlf1,

            [System.Xml.Serialization.XmlEnumAttribute("HLF2")]
            Hlf2,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("DatePeriodDetails", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class DatePeriodDetails
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("FrDt", DataType = "date")]
            public System.DateTime FrDt { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("ToDt", DataType = "date")]
            public System.DateTime ToDt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxAmount1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxAmount1
        {

            /// <summary>
            /// <para xml:lang="en">Total number of digits in fraction: 10.</para>
            /// <para xml:lang="en">Total number of digits: 11.</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Rate")]
            public decimal Rate { get; set; }

            /// <summary>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Rate property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RateSpecified { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TaxblBaseAmt")]
            public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("TtlAmt")]
            public ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<TaxRecordDetails1> _dtls;

            [System.Xml.Serialization.XmlElementAttribute("Dtls")]
            public System.Collections.ObjectModel.Collection<TaxRecordDetails1> Dtls
            {
                get
                {
                    return _dtls;
                }
                private set
                {
                    _dtls = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the Dtls collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DtlsSpecified
            {
                get
                {
                    return (this.Dtls.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="TaxAmount1" /> class.</para>
            /// </summary>
            public TaxAmount1()
            {
                this._dtls = new System.Collections.ObjectModel.Collection<TaxRecordDetails1>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("TaxRecordDetails1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class TaxRecordDetails1
        {

            [System.Xml.Serialization.XmlElementAttribute("Prd")]
            public TaxPeriod1 Prd { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Amt")]
            public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReturnReasonInformation10", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReturnReasonInformation10
        {

            [System.Xml.Serialization.XmlElementAttribute("OrgnlBkTxCd")]
            public BankTransactionCodeStructure4 OrgnlBkTxCd { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Orgtr")]
            public PartyIdentification32 Orgtr { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("Rsn")]
            public ReturnReason5Choice Rsn { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<string> _addtlInf;

            [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
            public System.Collections.ObjectModel.Collection<string> AddtlInf
            {
                get
                {
                    return _addtlInf;
                }
                private set
                {
                    _addtlInf = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Gets a value indicating whether the AddtlInf collection is empty.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AddtlInfSpecified
            {
                get
                {
                    return (this.AddtlInf.Count != 0);
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="ReturnReasonInformation10" /> class.</para>
            /// </summary>
            public ReturnReasonInformation10()
            {
                this._addtlInf = new System.Collections.ObjectModel.Collection<string>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("ReturnReason5Choice", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class ReturnReason5Choice
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 4.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(4)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("CorporateAction1", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class CorporateAction1
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Cd")]
            public string Cd { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Nb")]
            public string Nb { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.Xml.Serialization.XmlElementAttribute("Prtry")]
            public string Prtry { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("BankToCustomerStatementV02", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class BankToCustomerStatementV02
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("GrpHdr")]
            public GroupHeader42 GrpHdr { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<AccountStatement2> _stmt;

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("Stmt")]
            public System.Collections.ObjectModel.Collection<AccountStatement2> Stmt
            {
                get
                {
                    return _stmt;
                }
                private set
                {
                    _stmt = value;
                }
            }

            /// <summary>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="BankToCustomerStatementV02" /> class.</para>
            /// </summary>
            public BankToCustomerStatementV02()
            {
                this._stmt = new System.Collections.ObjectModel.Collection<AccountStatement2>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("GroupHeader42", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class GroupHeader42
        {

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 35.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = false)]
            [System.Xml.Serialization.XmlElementAttribute("MsgId")]
            public string MsgId { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("CreDtTm", DataType = "dateTime")]
            public System.DateTime CreDtTm { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("MsgRcpt")]
            public PartyIdentification32 MsgRcpt { get; set; }

            [System.Xml.Serialization.XmlElementAttribute("MsgPgntn")]
            public Pagination MsgPgntn { get; set; }

            /// <summary>
            /// <para xml:lang="en">Minimum length: 1.</para>
            /// <para xml:lang="en">Maximum length: 500.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
            [System.ComponentModel.DataAnnotations.MaxLengthAttribute(500)]
            [System.Xml.Serialization.XmlElementAttribute("AddtlInf")]
            public string AddtlInf { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("Pagination", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        public partial class Pagination
        {

            /// <summary>
            /// <para xml:lang="en">Pattern: [0-9]{1,5}.</para>
            /// </summary>
            [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,5}")]
            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("PgNb")]
            public string PgNb { get; set; }

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("LastPgInd")]
            public bool LastPgInd { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1184.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute("Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlRootAttribute("Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
        public partial class Document
        {

            [System.ComponentModel.DataAnnotations.RequiredAttribute(AllowEmptyStrings = true)]
            [System.Xml.Serialization.XmlElementAttribute("BkToCstmrStmt")]
            public BankToCustomerStatementV02 BkToCstmrStmt { get; set; }
        }
    }





*/