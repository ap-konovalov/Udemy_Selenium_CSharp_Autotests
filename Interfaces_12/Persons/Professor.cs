namespace Interfaces_12
{
	public class Professor : Person, ITraveler
	{
		private string _employeeId;
		private string _subject;

		public Professor(string id, string lastName, string firstName, int age, string employeeId, string subject) 
			: base(id, lastName, firstName, age)
		{
			_employeeId = employeeId;
			_subject = subject;
		}


		public string GetDestination()
		{
			return "The Beach";
		}

		public string GetStartLocation()
		{
			return "Home";
		}

		public double DetermineMiles()
		{
			return 32.00;
		}
		
		public override string ToString()
		{
			return base.ToString() + 
			       $"Destination: {GetDestination()}\n" +
			       $"Start Location: {GetStartLocation()}\n" +
			       $"Miles: {DetermineMiles()}\n";
		}
	}
}