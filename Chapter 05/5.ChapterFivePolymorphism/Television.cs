using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _5.ChapterFivePolymorphism
{
    public class Television: Product
    {
        public override void ApplyDiscount()
        {
            if(this.Price > 250)
            {
                using(HttpClient httpClient = new HttpClient())
                {
                    var discountRequest = Task.Run(async () => await httpClient.GetAsync("api/product/discount/television"));

                    this.Price = this.Price * (Convert.ToDecimal(discountRequest.Result.Content.ReadAsStringAsync().Result));
                }
            }
        }
    }
}
