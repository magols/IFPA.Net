using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Calendar
{
	public class Calendar
	{
		[JsonProperty("calendar_id")]
		public string CalendarId { get; set; }

		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("address1")]
		public string Address1 { get; set; }

		[JsonProperty("address2")]
		public string Address2 { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("zipcode")]
		public object Zipcode { get; set; }

		[JsonProperty("country_name")]
		public object CountryName { get; set; }

		[JsonProperty("website")]
		public string Website { get; set; }

		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("director_name")]
		public string DirectorName { get; set; }

		[JsonProperty("latitude")]
		public string Latitude { get; set; }

		[JsonProperty("longitude")]
		public string Longitude { get; set; }

		[JsonProperty("details")]
		public string Details { get; set; }

		[JsonProperty("private_flag")]
		public string PrivateFlag { get; set; }
	}

	public class CalendarResponse
	{
		[JsonProperty("calendar")]
		public IList<Calendar> Calendar { get; set; }
	}
}