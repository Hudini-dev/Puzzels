using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
public enum Houses
{
    Brobnar = 0,
    Dis = 1, 
    Logos = 2,
    Mars = 3,
    Sanctum = 4,
    Saurian = 5,
    StarAlliance = 6,
    Shadow = 7,
    Untamed = 8
}
