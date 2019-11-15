using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputData;
using System.Globalization;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FireBaseHandler
{
    public class FireBaseHandlerClass
    {
        //firebase configuration
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RgLzCC45ZVJdqYiHzMpA0KgoH0lD6IhewG7MN2fk",
            BasePath = "https://checkvocabulary-8c1cf.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);

        public FireBaseHandlerClass()
        {
        }

        public void setFireBaseInitialStatus(InputData.InputData input)
        {
            //try to get elements allready uploaded
            FirebaseResponse getResponse = client.Get("WordPairs/");
            string fireBaseFolderBody = getResponse.Body;

            //comment this after the datas are uploaded
            foreach (var wordPair in input.WordPairs)
            {
                if (!(fireBaseFolderBody.Contains(wordPair.EnglishWord + " - " + wordPair.HungarianWord)))
                {
                    SetResponse fireBaseResponse = client.Set("WordPairs/" + wordPair.EnglishWord + " - " + wordPair.HungarianWord, wordPair);

                    WordPair result = fireBaseResponse.ResultAs<WordPair>();
                    System.IO.File.WriteAllText("C:\\Users\\lorand.csoka\\Desktop\\get.txt", "WordPairs/" + result.EnglishWord + result.HungarianWord + result.CheckDate);
                }
            }
        }

        public async void updateFireBaseElement(InputData.InputData input, string englishKey)
        {
            WordPair updatedWordPair = input.WordPairs.Single(p => p.EnglishWord == englishKey);
            updatedWordPair.CheckDate = DateTime.ParseExact(DateTime.Now.AddHours(2).ToString("yy/MM/dd HH:mm:ss"), "yy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            FirebaseResponse response = await client.UpdateTaskAsync("WordPairs/" + updatedWordPair.EnglishWord + " - " + updatedWordPair.HungarianWord, updatedWordPair);
        }
    }
}
