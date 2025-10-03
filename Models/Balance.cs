namespace MT950ToCamtConverter.Models
{
    public class Balance
    {
        public string? CreditDebitIndicator { get; set; }
        public DateTime Date { get; set; }
        public string? Currency { get; set; }
        public decimal Amount { get; set; }
    }
}