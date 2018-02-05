using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.PlayerVsPlayer
{
	public class Pvp
	{
		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("event_date")]
		public string EventDate { get; set; }

		[JsonProperty("tournament_country_code")]
		public string TournamentCountryCode { get; set; }

		[JsonProperty("p1_finish_position")]
		public string P1FinishPosition { get; set; }

		[JsonProperty("p2_finish_position")]
		public string P2FinishPosition { get; set; }
	}

	public class PlayerVsPlayerResponse
	{
		[JsonProperty("p1_player_id")]
		public int P1PlayerId { get; set; }

		[JsonProperty("p2_player_id")]
		public int P2PlayerId { get; set; }

		[JsonProperty("p1_first_name")]
		public string P1FirstName { get; set; }

		[JsonProperty("p1_last_name")]
		public string P1LastName { get; set; }

		[JsonProperty("p2_first_name")]
		public string P2FirstName { get; set; }

		[JsonProperty("p2_last_name")]
		public string P2LastName { get; set; }

		[JsonProperty("p1_country_code")]
		public string P1CountryCode { get; set; }

		[JsonProperty("p2_country_code")]
		public string P2CountryCode { get; set; }

		[JsonProperty("p1_excluded")]
		public string P1Excluded { get; set; }

		[JsonProperty("p2_excluded")]
		public string P2Excluded { get; set; }

		[JsonProperty("pvp")]
		public IList<Pvp> Pvp { get; set; }
	}
}