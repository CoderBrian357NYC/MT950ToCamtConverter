/* using MT950ToCamtConverter.Models;

namespace MT950ToCamtConverter.Mappers
{ 

    public class Camt053Mapper02
{
    public Document Map(MT950Statement statement)
    {
        var doc = new Document
        {
            BkToCstmrStmt = new BankToCustomerStatementV13
            {
                GrpHdr = new GroupHeader116
                {
                    MsgId = statement.TransactionReference,
                    CreDtTm = DateTime.Now
                },
                var stmt = new List<AccountStatement14>
                {
                    new AccountStatement14
                    {
                        Id = new MessageIdentification2
                        {
                            Id = statement.TransactionReference
                        },
                        CreDtTm = statement.StatementDate ?? DateTime.Now,
                        FrToDt = new DateTimePeriod1
                        {
                            FrDtTm = statement.StatementDate ?? DateTime.Now,
                            ToDtTm = statement.StatementDate ?? DateTime.Now
                        },
                        Acct = new CashAccount43
                        {
                            Id = new AccountIdentification4Choice
                            {
                                Iban = statement.IBAN
                            },
                            Tp = new CashAccountType2Choice
                            {
                                Cd = "CASH"  // Or derive from logic
                            },
                            Ccy = statement.Currency,
                            Nm = statement.AccountName
                        },
                        Bal = BuildBalances(statement),
                        Ntry = BuildEntries(statement)
                    }
                }
            }
        };

        return doc;
    }

    private List<CashBalance8> BuildBalances(MT950Statement statement)
    {
        var balances = new List<CashBalance8>();

        if (statement.OpeningBalance != null)
        {
            balances.Add(new CashBalance8
            {
                Tp = new BalanceType13
                {
                    Cd = "OPBD"
                },
                Amt = new ActiveOrHistoricCurrencyAndAmount
                {
                    Ccy = statement.OpeningBalance.Currency ?? "EUR",
                    Value = statement.OpeningBalance.Amount
                },
                CdtDbtInd = statement.OpeningBalance.CreditDebitIndicator == "DBIT" ? CreditDebitCode.Dbit : CreditDebitCode.Crdt,
                Dt = new DateAndDateTime2Choice
                {
                    Dt = statement.OpeningBalance.Date
                }
            });
        }

        if (statement.ClosingBalance != null)
        {
            balances.Add(new CashBalance8
            {
                Tp = new BalanceType13
                {
                    Cd = "CLBD"
                },
                Amt = new ActiveOrHistoricCurrencyAndAmount
                {
                    Ccy = statement.ClosingBalance.Currency ?? "EUR",
                    Value = statement.ClosingBalance.Amount
                },
                CdtDbtInd = statement.ClosingBalance.CreditDebitIndicator == "DBIT" ? CreditDebitCode.Dbit : CreditDebitCode.Crdt,
                Dt = new DateAndDateTime2Choice
                {
                    Dt = statement.ClosingBalance.Date
                }
            });
        }

        return balances;
    }

    private List<ReportEntry15> BuildEntries(MT950Statement statement)
    {
        var entries = new List<ReportEntry15>();

        foreach (var tx in statement.Transactions)
        {
            entries.Add(new ReportEntry15
            {
                Amt = tx.Amount,
                CdtDbtInd = tx.CreditDebitIndicator == "DBIT" ? CreditDebitCode.Dbit : CreditDebitCode.Crdt,
                Sts = EntryStatus1Code.BOOK,
                BookgDt = new DateAndDateTime2Choice { Dt = tx.BookingDate },
                ValDt = new DateAndDateTime2Choice { Dt = tx.ValueDate },
                NtryDtls = new List<EntryDetails14>
                {
                    new EntryDetails14
                    {
                        TxDtls = new List<EntryTransaction13>
                        {
                            new EntryTransaction13
                            {
                                Amt = new ActiveOrHistoricCurrencyAndAmount
                                {
                                    Value = tx.Amount,
                                    Ccy = tx.Currency ?? "EUR"
                                },
                                RmtInf = new RemittanceInformation21
                                {
                                    Ustrd = new List<string> { tx.RemittanceInformation }
                                }
                            }
                        }
                    }
                }
            });
        }

        return entries;
    }
}




}
 */