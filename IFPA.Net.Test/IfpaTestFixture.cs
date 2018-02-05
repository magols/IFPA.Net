using System;

namespace IFPA.Net.Test
{
	public class IfpaTestFixture : IDisposable
	{
		public int CalendarId = 22000;

		public Client client;

		public int PlayerId = 38178;

		public int TournamentId = 22000;

		public IfpaTestFixture()
		{
			client = new Client("[INSERT_API_KEY]");
		}

		public void Dispose()
		{
			client = null;
		}
	}
}