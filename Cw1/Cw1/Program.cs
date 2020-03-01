using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
   public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient(); // var zeby dwa razy nie pisac nazwy typu
            HttpResponseMessage result = await client.GetAsync("https://www.pjwstk.edu.pl");

            if (result.IsSuccessStatusCode) {
                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                MatchCollection matches = regex.Matches(html);
                foreach (var m in matches) {
                    Console.WriteLine(m.ToString());
                }
            }

            
            Console.WriteLine("Koniec!");
        }
    }
}
