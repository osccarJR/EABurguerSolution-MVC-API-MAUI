using Newtonsoft.Json;
using EABurguerMAUISlt.Models;

namespace EABurguerMAUISlt
{
    public partial class EAMainPage : ContentPage
    {
        public EAMainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7166/api/");
            var response = client.GetAsync("burguer").Result;
            if (response.IsSuccessStatusCode)
            {
                var burguers = response.Content.ReadAsStringAsync().Result;
                var burguersList = JsonConvert.DeserializeObject<List<EABurger>>(burguers);

                listView.ItemsSource = burguersList;
            }
        }
    }
}
