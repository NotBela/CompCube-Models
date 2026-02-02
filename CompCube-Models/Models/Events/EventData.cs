using Newtonsoft.Json;

namespace CompCube_Models.Models.Events;

[method: Newtonsoft.Json.JsonConstructor]
public class EventData(string eventName, string displayName, string description, string eventOwner, ulong eventOwnerId, bool availableToJoin)
{
    [JsonProperty(PropertyName = "eventName")]
    public string EventName => eventName;
    
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName => displayName;
    
    [JsonProperty(PropertyName = "description")]
    public string Description => description;
    
    [JsonProperty(PropertyName = "eventOwner")]
    public string EventOwner { get; set; } = eventOwner;
    
    [JsonProperty(PropertyName = "eventOwnerId")]
    public ulong EventOwnerId { get; set; } = eventOwnerId;
    
    [JsonProperty(PropertyName = "availableToJoin")]
    public bool AvailableToJoin { get; set; } = availableToJoin;
}