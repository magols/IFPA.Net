using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Player
{
	public class RankHistory
	{
		[JsonProperty("rank_date")]
		public string RankDate { get; set; }

		[JsonProperty("rank_position")]
		public string RankPosition { get; set; }

		[JsonProperty("wppr_points")]
		public string WpprPoints { get; set; }
	}

	public class RatingHistory
	{
		[JsonProperty("rating_date")]
		public string RatingDate { get; set; }

		[JsonProperty("rating")]
		public string Rating { get; set; }
	}

	public class PlayerHistoryResponse
	{
		[JsonProperty("player")]
		public PlayerDetails Player { get; set; }

		[JsonProperty("rank_history")]
		public IList<RankHistory> RankHistory { get; set; }

		[JsonProperty("rating_history")]
		public IList<RatingHistory> RatingHistory { get; set; }

		public class PlayerDetails
		{
			[JsonProperty("player_id")]
			public string PlayerId { get; set; }

			[JsonProperty("first_name")]
			public string FirstName { get; set; }

			[JsonProperty("last_name")]
			public string LastName { get; set; }
		}
	}
}