namespace ConceptsPOO1
{
    [Serializable]
    internal class DayException : Exception
    {
        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}