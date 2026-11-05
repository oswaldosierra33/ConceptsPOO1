namespace ConceptsPOO1
{
    public class Invoice : Ipay
    {
        public int id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal GetValueToPay()
        {
            // Implementation for calculating invoice payment
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{id} - {Description}" +
                $"\n\tQuantity........: {$"{Quantity:N2}",18}" +
                $"\n\tPrice...........: {$"{Price:C2}",18}" +
                $"\n\tValue...........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
