namespace CurrencyRateBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DollarRateBoard<double> dollarRateBoard = new DollarRateBoard<double>(37.1);

            dollarRateBoard.ChangeRate(37.8);
            dollarRateBoard.ChangeRate(37.83);
            dollarRateBoard.ChangeRate(38.1);
            dollarRateBoard.ChangeRate(37.94);
            dollarRateBoard.ChangeRate(36.7);

            dollarRateBoard.PrintHistory();
        }
    }
}