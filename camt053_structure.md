# 📄 Overview of camt.053.001.13 Structure (Plain English)

**camt.053** is an ISO 20022 XML message for delivering **bank account statements**. It’s usually sent by banks daily or monthly, summarizing balances and transaction activity.

Version `001.13` is the latest and includes enhanced structures and more metadata.

---

## 🏗️ Message Hierarchy
Document
└── BankToCustomerStatementV13 (BkToCstmrStmt)
├── GroupHeader116 (GrpHdr)
└── Statement (Stmt): List of AccountStatement14
├── Id (Statement ID)
├── CreDtTm (Creation Date/Time)
├── Acct (CashAccount43)
├── Bal (List of CashBalance8)
└── Ntry (List of ReportEntry15)

---

## 🔹 Top-Level Components

### 1. `Document`
- Root XML node.

### 2. `BankToCustomerStatementV13`
- Contains metadata and actual account statements:
  - `GrpHdr`: Message-level info (ID, creation timestamp).
  - `Stmt`: One or more account statements.

### 3. `AccountStatement14` (`Stmt`)
- One full account statement.
  - `Acct`: The account (`CashAccount43`).
  - `Bal`: Balances (opening, closing, interim).
  - `Ntry`: List of transactions (`ReportEntry15`).

### 4. `CashAccount43` (`Acct`)
- Contains:
  - `Id`: IBAN or other ID.
  - `Ccy`: Currency.
  - `Nm`: Name.

### 5. `CashBalance8` (`Bal`)
- For each balance type:
  - `Amt`, `Ccy`, `CdtDbtInd`
  - `Tp`: Type (e.g. opening).
  - `Dt`: Associated date.

### 6. `ReportEntry15` (`Ntry`)
- Each transaction or transaction group:
  - `Amt`, `CdtDbtInd`, `BookgDt`, `AcctSvcrRef`, `NtryDtls`, `AddtlNtryInf` , `BkTxCd` optional details.

---

## 🧾 Sample (Simplified XML)

```xml
<Document>
  <BkToCstmrStmt>
    <GrpHdr>
      <MsgId>ABC123</MsgId>
      <CreDtTm>2025-07-25T10:00:00</CreDtTm>
    </GrpHdr>
    <Stmt>
      <Id>STMT001</Id>
      <CreDtTm>2025-07-24T00:00:00</CreDtTm>
      <Acct>
        <Id>
          <IBAN>IE29AIBK93115212345678</IBAN>
        </Id>
        <Ccy>EUR</Ccy>
        <Nm>Brian Tansey</Nm>
      </Acct>
      <Bal>
        <Tp>
          <CdOrPrtry>
            <Cd>OPBD</Cd>
          </CdOrPrtry>
        </Tp>
        <Amt Ccy="EUR">10000.00</Amt>
        <CdtDbtInd>CRDT</CdtDbtInd>
        <Dt>
          <Dt>2025-07-24</Dt>
        </Dt>
      </Bal>
      <Ntry>
        <Amt Ccy="EUR">-250.00</Amt>
        <CdtDbtInd>DBIT</CdtDbtInd>
        <BookgDt><Dt>2025-07-24</Dt></BookgDt>
        <ValDt><Dt>2025-07-24</Dt></ValDt>
      </Ntry>
    </Stmt>
  </BkToCstmrStmt>
</Document>

🔁 Mapping from MT950 to camt.053

| MT950 Element         | camt.053 Target Type     | Notes                             |
| --------------------- | ------------------------ | --------------------------------- |
| Transaction Reference | `GrpHdr.MsgId`           | Use as message ID                 |
| Statement Number      | `Stmt.Id`                | Statement ID                      |
| Statement Date        | `Stmt.CreDtTm`           | Date of the statement             |
| Account IBAN          | `Acct.Id.IBAN`           | Account identification            |
| Currency              | `Acct.Ccy`, `Amt.Ccy`    | Use everywhere currency is needed |
| Opening Balance       | `Bal` with type = "OPBD" | Credit or debit                   |
| Closing Balance       | `Bal` with type = "CLBD" |                                   |
| Transactions          | `Ntry` entries           | Each MT950 transaction = 1 Ntry   |
