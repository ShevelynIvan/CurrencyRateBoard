namespace CurrencyRateBoard
{
    /// <summary>
    /// Dollar exchange rate board to uah 
    /// </summary>
    /// <typeparam name="T">Sets the type for the dollar exchange rate</typeparam>
    public class DollarRateBoard<T> where T : struct
    {
        private List<T> _exchangeRateHistory;

        /// <summary>
        /// Value of 1$ in uah 
        /// </summary>
        public T CurrentRate { get; private set; }

        /// <summary>
        /// Constructor to create dollar exchange rate board to uah. 
        /// </summary>
        /// <param name="currentRate">Value of current rate of dollar in uah</param>
        public DollarRateBoard(T currentRate)
        {
            _exchangeRateHistory = new List<T>();
            CurrentRate = currentRate;
            _exchangeRateHistory.Add(currentRate);
        }

        /// <summary>
        /// Changes current rate
        /// </summary>
        /// <param name="value">Value of current rate of dollar in uah</param>
        public void ChangeRate(T value)
        {
            CurrentRate = value;
            _exchangeRateHistory.Add(value);
            Console.WriteLine($"Rate has been changed. New value = {CurrentRate}");
        }

        /// <summary>
        /// Prints all history of changes currency rate 
        /// </summary>
        public void PrintHistory()
        {
            Console.WriteLine("Change History:");
            foreach(T rate in _exchangeRateHistory) 
            {
                Console.WriteLine($"1$ = {rate} uah");
            }
        }
    }
}
