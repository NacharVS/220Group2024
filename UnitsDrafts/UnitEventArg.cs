namespace UnitsDrafts
{
    internal class UnitEventArg
    {
        public UnitEventArg(string message, int healthDifferce)
        {
            Message = message;
            HealthDifferce = healthDifferce;
        }

        public string Message { get; set; }
        public int HealthDifferce { get; set; }
    }
}