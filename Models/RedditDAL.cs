using RestSharp;
using System.Net;
using System.Text.Json.Serialization;

namespace PoorReddit.Models
{
    public class RedditDAL
    {
        public AwwAPI GetPosts()
        {
            RestClient client = new RestClient($"https://reddit.com/r/awww/.json");
            RestRequest request = new RestRequest();
            var response = client.GetAsync<AwwAPI>(request);
            AwwAPI gp = response.Result;
            return gp;
        }
    }
}
