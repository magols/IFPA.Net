using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Player
{
	public class Pvp
	{
		[JsonProperty("player_id")]
		public string PlayerId { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("win_count")]
		public string WinCount { get; set; }

		[JsonProperty("loss_count")]
		public string LossCount { get; set; }

		[JsonProperty("tie_count")]
		public string TieCount { get; set; }
	}

	public class PlayerPvpResponse
	{
		[JsonProperty("player_id")]
		public int PlayerId { get; set; }

		[JsonProperty("total_competitors")]
		public int TotalCompetitors { get; set; }

		[JsonProperty("pvp")]
		public IList<Pvp> Pvp { get; set; }
	}
}