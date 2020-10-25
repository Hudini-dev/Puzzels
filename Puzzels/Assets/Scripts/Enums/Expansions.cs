using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[JsonConverter(typeof(StringEnumConverter))]
public enum Expansions
{
    COTA = 0,
    AOA = 1,
    WC = 2,
    MM = 3
}