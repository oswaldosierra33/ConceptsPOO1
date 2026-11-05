namespace ConceptsPOO1
{
    [Serializable]
    internal class MonthException : Exception
    {
        public MonthException()
        {
        }

        public MonthException(string? message) : base(message)
        {
        }

        public MonthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}