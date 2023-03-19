using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Events.ApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ModelEvent {
    /// <summary>
    /// Gets or Sets Attendees
    /// </summary>
    [DataMember(Name="attendees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attendees")]
    public List<Attendee> Attendees { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="endTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets RowVersion
    /// </summary>
    [DataMember(Name="rowVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rowVersion")]
    public byte[] RowVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelEvent {\n");
      sb.Append("  Attendees: ").Append(Attendees).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  RowVersion: ").Append(RowVersion).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
