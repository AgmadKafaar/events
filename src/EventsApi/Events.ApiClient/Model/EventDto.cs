using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Events.ApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EventDto {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DoctorAttendeeId
    /// </summary>
    [DataMember(Name="doctorAttendeeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "doctorAttendeeId")]
    public int? DoctorAttendeeId { get; set; }

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
    /// Gets or Sets PatientAttendeeId
    /// </summary>
    [DataMember(Name="patientAttendeeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patientAttendeeId")]
    public int? PatientAttendeeId { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventDto {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DoctorAttendeeId: ").Append(DoctorAttendeeId).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PatientAttendeeId: ").Append(PatientAttendeeId).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
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
