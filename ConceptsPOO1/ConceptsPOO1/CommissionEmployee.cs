namespace ConceptsPOO1
{
    public class CommissionEmployee : Employee
    {


        public float CommissionPercentaje { get; set; }

        public int Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje.: {$"{CommissionPercentaje:P2}",16}" +
                $"\n\tSales:................: {$"{Sales:C2}",16}" +
                $"\n\tValue to pay..........: {$"{GetValueToPay():C2}",16}";
        }
    }
}
