using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasketballStars.Models
{
  public class Position
  {
    public int PositionId { get; set; }
    public string PositionName { get; set; }

    public static List<Position> GetPositions()
    {
      var apiCallTask = ApiHelper.GetAllPositions();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Position> positionList = JsonConvert.DeserializeObject<List<Position>>(jsonResponse.ToString());

      return positionList;
    }

    public static Position GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetPosition(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Position position = JsonConvert.DeserializeObject<Position>(jsonResponse.ToString());

      return position;
    }
  }
}