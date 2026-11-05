namespace ConceptsPOO1
{
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }

        public required decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours:................: {$"{Hours:N2}",16}" +
                $"\n\tHour Value:...........: {$"{HourValue:C2}",16}" +
                $"\n\tValue to pay..........: {$"{GetValueToPay():C2}",16}";
        }
    }
}
