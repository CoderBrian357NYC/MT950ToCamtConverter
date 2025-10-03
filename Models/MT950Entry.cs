namespace MT950ToCamtConverter.Models
{
    public class MT950Entry
    {
        public DateTime BookingDate { get; set; }
        public DateTime ValueDate { get; set; } 
        public string? Currency { get; set; }
        public string? CreditDebitIndicator { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionType { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
    }
}