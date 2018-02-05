using System.Collections.Generic;

using Newtonsoft.Json;

namespace IFPA.Net.Model.Calendar
{
	public class CalendarActive
	{
		[JsonProperty("calendar_id")]
		public string CalendarId { get; set; }

		[JsonProperty("tournament_id")]
		public string TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("average_players")]
		public string AveragePlayers { get; set; }

		[JsonProperty("average_points")]
		public string AveragePoints { get; set; }

		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }
	}

	public class AvailableMonth
	{
		[JsonProperty("date_month")]
		public string DateMonth { get; set; }
	}

	public class AvailableCountry
	{
		[JsonProperty("country_name")]
		public string CountryName { get; set; }
	}

	public class CalendarActiveResponse
	{
		[JsonProperty("calendar")]
		public IList<CalendarActive> Active { get; set; }

		[JsonProperty("total_entries")]
		public int TotalEntries { get; set; }

		[JsonProperty("available_months")]
		public IList<AvailableMonth> AvailableMonths { get; set; }

		[JsonProperty("available_countries")]
		public IList<AvailableCountry> AvailableCountries { get; set; }
	}
}