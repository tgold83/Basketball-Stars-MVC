using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasketballStars.Models
{
  public class Player
  {
    public int PlayerId { get; set; }
    public string[] PositionName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Team { get; set; }

    public static List<Player> GetPlayers()
    {
      var apiCallTask = ApiHelper.GetAllPlayers();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Player> playerList = JsonConvert.DeserializeObject<List<Player>>(jsonResponse.ToString());

      return playerList;
    }

    public static Player GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetPlayer(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Player player = JsonConvert.DeserializeObject<Player>(jsonResponse.ToString());

      return player;
    }
  }
}