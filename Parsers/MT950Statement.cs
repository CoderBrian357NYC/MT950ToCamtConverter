using MT950ToCamtConverter.Models;

namespace MT950ToCamtConverter.Parsers
{

    public class MT950Parser
    {
        public static MT950Statement Parse(string mt950Text)
        {
            var statement = new MT950Statement();
            var lines = mt950Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            MT950Entry currentEntry = null;

            foreach (var line in lines)
            {
                if (line.StartsWith(":20:")) statement.TransactionReference = line[4..].Trim();
                else if (line.StartsWith(":25:")) statement.IBAN = line[4..].Trim().Replace(" ", "").ToUpper();
                else if (line.StartsWith(":28C:")) statement.StatementNumber = line[5..].Trim();
                else if (line.StartsWith(":60F:")) statement.OpeningBalance = ParseBalance(line[5..]);
                else if (line.StartsWith(":61:"))
                {
                    if (currentEntry != null) statement.Entries.Add(currentEntry);
                    currentEntry = ParseEntry(line[4..]);
                }
                else if (line.StartsWith(":86:") && currentEntry != null)
                {
                    currentEntry.Description = line[4..].Trim();
                }
                else if (line.StartsWith(":62F:"))
                {
                    if (currentEntry != null) statement.Entries.Add(currentEntry);
                    statement.ClosingBalance = ParseBalance(line[5..]);
                }
            }

            return statement;
        }

        private static Balance ParseBalance(string data)
        {
            return new Balance
            {
                CreditDebitIndicator = data[0].ToString(),
                Date = ParseDate(data.Substring(1, 6)),
                Currency = data.Substring(7, 3),
                Amount = ParseAmount(data.Substring(10))
            };
        }

        internal static MT950Entry ParseEntry(string data)
        {
            var entry = new MT950Entry();

            // Booking date - first 6 chars YYMMDD
            entry.BookingDate = ParseDate(data.Substring(0, 6));

            // Optional value date (next 4 chars - MMDD) - check if valid date or fallback
            if (data.Length >= 10)
            {
                try
                {
                    entry.ValueDate = new DateTime(entry.BookingDate.Year,
                                                  int.Parse(data.Substring(6, 2)),
                                                  int.Parse(data.Substring(8, 2)));
                }
                catch
                {
                    // fallback or leave null
                    entry.ValueDate = entry.BookingDate;
                }
            }
            else
            {
                entry.ValueDate = entry.BookingDate;
            }

            // Determine credit/debit indicator
            entry.CreditDebitIndicator = data.Contains('D') ? "DBIT" : "CRDT";

            // Find the amount substring start and end
            int amountStart = data.IndexOf('D') > 0 ? data.IndexOf('D') + 1 : data.IndexOf('C') + 1;
            int amountEnd = data.IndexOf('N', amountStart);

            if (amountEnd < 0) amountEnd = data.Length;

            var amountString = data.Substring(amountStart, amountEnd - amountStart);

            entry.Amount = ParseAmount(amountString);

            // Transaction type is usually 4 chars after N
            if (amountEnd + 1 + 4 <= data.Length)
                entry.TransactionType = data.Substring(amountEnd + 1, 4);
            else
                entry.TransactionType = string.Empty;

            // Reference extraction after //
            var refSplit = data.Split(new[] { "//" }, StringSplitOptions.None);
            if (refSplit.Length > 1)
                entry.Reference = refSplit[1].Trim();

            return entry;
        }


        internal static DateTime ParseDate(string yymmdd)
        {
            if (yymmdd.Length != 6)
                throw new ArgumentException("Date string must be 6 characters in YYMMDD format.");

            // Parse year, month, day from the string
            int year = int.Parse(yymmdd.Substring(0, 2));
            int month = int.Parse(yymmdd.Substring(2, 2));
            int day = int.Parse(yymmdd.Substring(4, 2));

            // MT950 dates usually represent 2000+ years, so handle year accordingly
            year += (year >= 70) ? 1900 : 2000;

            return new DateTime(year, month, day);
        }

        private static decimal ParseAmount(string amountStr)
        {
            return decimal.Parse(amountStr.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}