using System.Text.Json.Serialization;

namespace AwsZoneFileTransformation.Models
{
    public class ResourceRecordSet
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("TTL")]
        public long Ttl { get; set; }

        [JsonPropertyName("ResourceRecords")]
        public List<ResourceRecord> ResourceRecords { get; set; } = new List<ResourceRecord>();
    }
}
