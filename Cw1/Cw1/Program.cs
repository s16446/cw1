using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cw1
{
   public class Program
    {
        public static async Task void Main(string[] args)
        {
            var client = new HttpClient(); // var zeby dwa razy nie pisac nazwy typu
            HttpResponseMessage result = await client.GetAsync("https://www.pjwstk.edu.pl");

            if (result.IsSuccessStatusCode) {

                string html = await result.Content.ReadAsStringAsync();
            }
            Console.WriteLine("Koniec!");
        }
    }
}
