using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Drawing;
using static CryptoTracker.Tracker;

// It used to be CovidTracker using covid tw gov API, but I found out that the 
// object name is Chinese, which is kinda complicated for the school project, so I decided to switch
// to another project, but it's still based on the same logic.

namespace CryptoTracker
{
    public partial class Tracker : Form
    {

        // Variables.
        private string SelectedCrypto = null;

        // API String, idk how where to put variables so I decided to put it here.
        private string apiURL = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&ids={0}&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en";

        // Classes

        // Very cool Crypto class, every string variable inside are based on 
        // coingecko documentation. @source: https://www.coingecko.com/en/api/documentation.

        // get; set; means you can read / write the following value.
        // and we will be using get here, so we can loop through the value n more...

        public class Crypto
        {
            public string id { get; set; }
            public string symbol { get; set; }
            public string current_price { get; set; }
            public string total_volume { get; set; }
            public string market_cap { get; set; }
            public string circulating_supply { get; set; }
            public string max_supply { get; set; }
        }

        // Function to get every crypto ID.
        private async void GetComboBoxInfo()
        {

            // Getting new client.
            HttpClient client = new HttpClient();

            // We will be using async here to get the Promise result [fulfilled / rejected ]
            // in short, we use await to wait for the httprequest result.
            HttpResponseMessage responseBody = await client.GetAsync("https://api.coingecko.com/api/v3/coins/list?include_platform=true");


            // 200 i think?
            if (responseBody.IsSuccessStatusCode)
            {
                // awaitable so we have to add await
                string strResBody = await responseBody.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a list of Coin objects
                List<Crypto> coins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Crypto>>(strResBody);

                // Populate the ComboBox with cryptocurrency IDs
                foreach (Crypto coin in coins)
                {
                    cryptoComboBox.Items.Add(coin.id);
                }
            }
            else // Will happen as long as coingecko is dead OR TOO MANT REQUESTS.
            {
                MessageBox.Show("An error has occurred, Error Code: " + responseBody.StatusCode);
            }
        }

        public Tracker()
        {
            InitializeComponent();

            // We will put our comboBox listing function here.
            GetComboBoxInfo();

            // Example, not necessary but I'll add it to make it look better.
            DataGrid.Rows.Add(
            "範例貨幣",
            "sample",
            "69420",
            "100000",
            "6942042069",
            "19000000",
            "21000000"
            );
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Check if user has already selected an Crypto.
            if (cryptoComboBox.SelectedItem != null)
            {
                SelectedCrypto = cryptoComboBox.SelectedItem.ToString();
            }
            else // if user forgot to choose.
            {
                MessageBox.Show("請選擇幣種!");
                return;
            }


            // Getting new client.
            HttpClient client = new HttpClient();

            if (client == null)
            {
                MessageBox.Show("HttpClient Error!");
                return;
            }

            // Set the header to User-Agent bla bla blah
            // to pretend that we are a browser and requesting data from the site.
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

            // Pasted from my comboBox since they are the same thing.

            // We will use string.Format(stuff with {0}, text) to make a new URL.
            string newAPIURL = string.Format(apiURL, cryptoComboBox.SelectedItem.ToString());

            //MessageBox.Show(newAPIURL);

            // We will be using async here to get the Promise result [fulfilled / rejected ]
            // in short, we use await to wait for the httprequest result.
            HttpResponseMessage response = await client.GetAsync(newAPIURL);

            // 200 i think?
            if (response.IsSuccessStatusCode)
            {

                // awaitable so we have to add await
                string strResBody = await response.Content.ReadAsStringAsync();
                List<Crypto> coins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Crypto>>(strResBody);

                foreach (DataGridViewRow rows in DataGrid.Rows)
                {
                    if (rows.Cells["cryptoName"] != null &&
                        rows.Cells["cryptoName"].Value != null &&
                        rows.Cells["cryptoName"].Value.ToString() == cryptoComboBox.SelectedItem.ToString()
                        )
                    {
                        MessageBox.Show("您已經選過了!");
                        return;
                    }
                }

                foreach (Crypto coin in coins)
                {
                    DataGrid.Rows.Add(
                        coin.id,
                        coin.symbol,
                        coin.current_price,
                        coin.total_volume,
                        coin.market_cap,
                        coin.circulating_supply,
                        coin.max_supply
                        );
                }
            }
            else // Will happen as long as coingecko is dead OR TOO MANT REQUESTS.
            {
                if (response.StatusCode.ToString() == "TooManyRequests")
                {
                    MessageBox.Show("短時間內向API傳輸過多請求\n請稍後再試");
                    return;
                }
                else
                {
                    MessageBox.Show("An error has occurred, Error Code: " + response.StatusCode);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
