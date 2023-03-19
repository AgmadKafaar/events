using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Events.ApiClient.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AttendeeDto {
    /// <summary>
    /// Gets or Sets AttendeeType
    /// </summary>
    [DataMember(Name="attendeeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attendeeType")]
    public AttendeeTypeDto AttendeeType { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="emailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsAttending
    /// </summary>
    [DataMember(Name="isAttending", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAttending")]
    public bool? IsAttending { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AttendeeDto {\n");
      sb.Append("  AttendeeType: ").Append(AttendeeType).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsAttending: ").Append(IsAttending).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
