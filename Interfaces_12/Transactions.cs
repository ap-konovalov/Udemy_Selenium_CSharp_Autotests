namespace Interfaces_12
{
	public class Transactions : ITransactions
	{
		private string _tCode;
		private string _date;
		private double _amount;

		public Transactions()
		{
			_tCode = " ";
			_date = " ";
			_amount = 0.0;
		}

		public Transactions(string tCode, string date, double amount)
		{
			_tCode = tCode;
			_date = date;
			_amount = amount;
		}

		public double getAmount()
		{
			return _amount;
		}

		public override string ToString()
		{
			return $"Transaction: {_tCode}\n" +
			       $"Date: {_date}\n" +
			       $"Amount: {_amount}";
		}
	}
}