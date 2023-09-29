using System.Text.Json.Serialization;


namespace AwsZoneFileTransformation.Models
{
    public class ExportFileModel
    {
        [JsonPropertyName("ResourceRecordSets")]
        public List<ResourceRecordSet> ResourceRecordSets { get; set; } = new List<ResourceRecordSet>();
    }
    public class ResourceRecord
    {
        [JsonPropertyName("Value")]
        public string Value { get; set; } = string.Empty;
    }
}
