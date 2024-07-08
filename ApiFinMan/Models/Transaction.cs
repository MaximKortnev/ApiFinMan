namespace ApiFinMan.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public string Comment { get; set; }
        public string ViewType { get; set; }
        public DateTime Date { get; set; }

        public Transaction() { 

            Date = DateTime.Now;
        }
    }
}
