using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User photo object
  /// </summary>
  [DataContract]
  public class UserPhoto {
    /// <summary>
    /// Photo in byte array
    /// </summary>
    /// <value>Photo in byte array</value>
    [DataMember(Name="photo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photo")]
    public byte[] Photo { get; set; }

    /// <summary>
    /// Mime type of user photo. Eg .bmp, .jpg etc
    /// </summary>
    /// <value>Mime type of user photo. Eg .bmp, .jpg etc</value>
    [DataMember(Name="photoMimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photoMimeType")]
    public string PhotoMimeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserPhoto {\n");
      sb.Append("  Photo: ").Append(Photo).Append("\n");
      sb.Append("  PhotoMimeType: ").Append(PhotoMimeType).Append("\n");
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
