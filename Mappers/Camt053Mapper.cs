using MT950ToCamtConverter.Models; // your MT950 classes

namespace MT950ToCamtConverter.Mappers
{
    public class Camt053Mapper
    {
        public Document Map(MT950Statement statement)
        {
            var doc = new Document();
            doc.BkToCstmrStmt = new BankToCustomerStatementV13();

            doc.BkToCstmrStmt.GrpHdr = new GroupHeader116
            {
                MsgId = statement.TransactionReference,
                CreDtTm = DateTime.Now  // or any appropriate datetime you want here
            };


            var accountStatement = new AccountStatement14();
            accountStatement.CreDtTm = statement.StatementDate ?? DateTime.Now;


            // Set Account once:
            accountStatement.Acct = new CashAccount43
            {
                Id = new AccountIdentification4Choice
                {
                    Iban = statement.IBAN
                },
                Tp = new CashAccountType2Choice
                {
                    
                },

                Ccy = statement.Currency,
                Nm = statement.AccountName
            };

            // Initialize Balances collection if null
            if (accountStatement.Bal == null)
            {
                var balList = new System.Collections.ObjectModel.Collection<CashBalance8>();
                typeof(AccountStatement14)
                    .GetProperty("Bal")
                    .SetValue(accountStatement, balList);
            }

            // Opening balance
            if (statement.OpeningBalance != null)
            {
                Console.WriteLine($"Opening Balance Date: {statement.OpeningBalance.Date}");
                Console.WriteLine($"Opening Balance Date: {statement.OpeningBalance.Date:yyyy-MM-dd}");
                Console.WriteLine($"Closing Balance Date: {statement.ClosingBalance.Date:yyyy-MM-dd}");



                accountStatement.Bal.Add(new CashBalance8
                {
                    Amt = new ActiveOrHistoricCurrencyAndAmount
                    {
                        Value = statement.OpeningBalance.Amount,
                        Ccy = statement.OpeningBalance.Currency ?? "EUR"
                    },
                    CdtDbtInd = statement.OpeningBalance.CreditDebitIndicator switch
                    {
                        "CRDT" => CreditDebitCode.Crdt,
                        "DBIT" => CreditDebitCode.Dbit,
                        _ => CreditDebitCode.Crdt
                    },

                    Dt = new DateAndDateTime2Choice
                    {
                        Dt = statement.OpeningBalance.Date,
                        DtSpecified = true
                    }
                });
            }

            // Closing balance
            if (statement.ClosingBalance != null)
            {
                accountStatement.Bal.Add(new CashBalance8
                {
                    Amt = new ActiveOrHistoricCurrencyAndAmount
                    {
                        Value = statement.ClosingBalance.Amount,
                        Ccy = statement.ClosingBalance.Currency ?? "EUR"
                    },
                    CdtDbtInd = statement.ClosingBalance.CreditDebitIndicator switch
                    {
                        "CRDT" => CreditDebitCode.Crdt,
                        "DBIT" => CreditDebitCode.Dbit,
                        _ => CreditDebitCode.Crdt
                    },

                    Dt = new DateAndDateTime2Choice
                    {
                        Dt = statement.ClosingBalance.Date,
                        DtSpecified = true
                    }
                });
            }

            // Initialize Entries collection if null
            if (accountStatement.Ntry == null)
            {
                var ntryList = new System.Collections.ObjectModel.Collection<ReportEntry15>();
                typeof(AccountStatement14)
                    .GetProperty("Ntry")
                    .SetValue(accountStatement, ntryList);
            } 

            // Entries mapping
            foreach (var entry in statement.Entries)
            {
                var ntry = new ReportEntry15
                {
                    Amt = new ActiveOrHistoricCurrencyAndAmount
                    {
                        Value = entry.Amount,
                        Ccy = entry.Currency ?? statement.Currency ?? "EUR"
                    },
                    CdtDbtInd = entry.CreditDebitIndicator == "CRDT"
                        ? CreditDebitCode.Crdt
                        : CreditDebitCode.Dbit,
                    //Sts = EntryStatus1Choice.Book,
                    BookgDt = new DateAndDateTime2Choice { Dt = entry.BookingDate, DtSpecified = true },
                    ValDt = new DateAndDateTime2Choice { Dt = entry.ValueDate, DtSpecified = true },
                    AddtlNtryInf = entry.Description
                };

                accountStatement.Ntry.Add(ntry);
            }

            // Initialize Statements collection if null
            if (doc.BkToCstmrStmt.Stmt == null)
            {
                var stmtList = new System.Collections.ObjectModel.Collection<AccountStatement14>();
                typeof(BankToCustomerStatementV13)
                    .GetProperty("Stmt")
                    .SetValue(doc.BkToCstmrStmt, stmtList);
            }

            doc.BkToCstmrStmt.Stmt.Add(accountStatement);
 
            return doc;
        }
    }
}
 