using System.Text.Json.Serialization;

namespace AwsZoneFileTransformation.Models
{
    public class ImportFileModel
    {
        [JsonPropertyName("Comment")]
        public string Comment { get; set; } = string.Empty;

        [JsonPropertyName("Changes")]
        public List<Change> Changes { get; set; } = new List<Change>();
    }
    public class Change
    {
        [JsonPropertyName("Action")]
        public string Action { get; set; } = string.Empty;

        [JsonPropertyName("ResourceRecordSet")]
        public ResourceRecordSet ResourceRecordSet { get; set; } = new ResourceRecordSet();
    }
    public class AliasTarget
    {
        [JsonPropertyName("HostedZoneId")]
        public string HostedZoneId { get; set; } = string.Empty;

        [JsonPropertyName("EvaluateTargetHealth")]
        public bool EvaluateTargetHealth { get; set; }

        [JsonPropertyName("DNSName")]
        public string DnsName { get; set; } = string.Empty;
    }
}
