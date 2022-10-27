using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using MvcApiCall.Models;

namespace BasketballStars.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllPlayers()
    {
      RestClient playerClient = new RestClient("http://localhost:5004/api");
      playerClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
          EnvironmentVariables.ApiKey, "Bearer"
      );
      RestRequest playerRequest = new RestRequest($"players", Method.GET);
      var playerResponse = await playerClient.ExecuteTaskAsync(playerRequest);
      return playerResponse.Content;
    }

    public static async Task<string> GetAllPositions()
    {
      RestClient positionClient = new RestClient("http://localhost:5004/api");
      positionClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
          EnvironmentVariables.ApiKey, "Bearer"
      );
      RestRequest positionRequest = new RestRequest($"positions", Method.GET);
      var positionResponse = await positionClient.ExecuteTaskAsync(positionRequest);
      return positionResponse.Content;
    }

    public static async Task<string> GetPlayer(int id)
    {
      RestClient playerClient = new RestClient("http://localhost:5004/api");
      playerClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
          EnvironmentVariables.ApiKey, "Bearer"
      );
      RestRequest playerRequest = new RestRequest($"players/{id}", Method.GET);
      var playerResponse = await playerClient.ExecuteTaskAsync(playerRequest);
      return playerResponse.Content;
    }

    public static async Task<string> GetPosition(int id)
    {
      RestClient positionClient = new RestClient("http://localhost:5004/api");
      positionClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(
          EnvironmentVariables.ApiKey, "Bearer"
      );
      RestRequest positionRequest = new RestRequest($"positions/{id}", Method.GET);
      var positionResponse = await positionClient.ExecuteTaskAsync(positionRequest);
      return positionResponse.Content;
    }
  }
}