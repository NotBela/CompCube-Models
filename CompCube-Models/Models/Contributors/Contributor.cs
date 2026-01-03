using Newtonsoft.Json;

namespace CompCube_Server.Models.CompCube_Models.Models.Contributors;

public class Contributor(string name, string role, string profilePictureLink)
{
    [JsonProperty("name")]
    public string Name => name;
    
    [JsonProperty("role")]
    public string Role => role;
    
    [JsonProperty("pfpLink")]
    public string ProfilePictureLink => profilePictureLink;
}