namespace MT950ToCamtConverter.Models
{
    public class MT950Statement
    {
        public string? TransactionReference { get; set; }
        public string? AccountId { get; set; }
        public string? AccountName { get; set; }
        public string? IBAN { get; set; }
        public string? Currency { get; set; }
        public string? StatementNumber { get; set; }
        public DateTime? StatementDate { get; set; } 
        public Balance? OpeningBalance { get; set; }
        public List<MT950Entry> Entries { get; set; } = new();
        public Balance? ClosingBalance { get; set; }
    }




}