using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckofCardsAPI_Lab.Models
{
    public class CardDAL
    {
        public void GetShuffle()
        {
            string url = $"https://deckofcardsapi.com/api/deck/0rfo1nerk97c/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }


        public CardModel GetData()
        {
            string url = $"https://deckofcardsapi.com/api/deck/0rfo1nerk97c/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            CardModel result = JsonConvert.DeserializeObject<CardModel>(JSON);

            return result;
        }

    }
}
