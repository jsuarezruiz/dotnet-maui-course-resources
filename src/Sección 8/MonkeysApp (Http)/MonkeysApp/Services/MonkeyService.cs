using MonkeysApp.Models;
using System.Net.Http.Json;

namespace MonkeysApp.Services
{
    public class MonkeyService
    {
        HttpClient _httpClient;

        public MonkeyService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Monkey>> GetMonkeys()
        {
            List<Monkey> monkeys = new List<Monkey>();

            var response = await _httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
           
            if (response.IsSuccessStatusCode)
            {
                monkeys = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            return monkeys;
        }
    }
}