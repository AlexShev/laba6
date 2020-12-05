using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace laba6
{
	internal class GeneratorUserInfoClient : IDisposable
	{
		private readonly HttpClient _httpClient;

		public GeneratorUserInfoClient()
		{
			_httpClient = new HttpClient();
		}

		public void Dispose()
		{
			_httpClient.Dispose();
		}

		private static string GeneratePhoneNumber()
		{
			return $"+7({RandomNumberString(3)})-{RandomNumberString(3)}-{RandomNumberString(2)}-{RandomNumberString(2)}";
		}

		private static string RandomNumberString(byte size)
		{
			var result = string.Empty;

			var rand = new Random();

			for (byte i = 0; i < size; i++)
			{
				result += rand.Next(0, 9);
			}

			return result;
		}

		public Client GenerateСlient(string city = null)
		{
			var responseMessage = _httpClient.GetAsync("https://randomuser.me/api/?inc=gender,name,location,login,dob,nat=gb&noinfo").Result;

			var contentString = responseMessage.Content.ReadAsStringAsync().Result;

			// я так и не понял почему я не могу обойтись без листа
			var a = JsonSerializer.Deserialize<Root>(contentString).results.First();

			var result = new string[7];

			result[0] = a.login.username;

			result[1] = a.login.password;

			result[2] = a.name.last + ' ' + a.name.first;

			result[3] = a.gender;

			result[4] = a.dob.date.ToShortDateString();

			// не смог использовать ??  кишки тонки
			result[5] = (city == null) ? a.location.city : StandartView.ConverteToStandartString(city);

			result[6] = GeneratePhoneNumber();

			return new Client(result[0], result[1], result[2], result[3], result[4], result[5], result[6], true);
		}
	}
}
