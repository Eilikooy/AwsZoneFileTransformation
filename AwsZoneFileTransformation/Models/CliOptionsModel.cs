using CommandLine;

namespace AwsZoneFileTransformation.Models
{
    internal class CliOptions
    {
        [Option('i', "inputFile", Required = true, HelpText = "Exported Zone file as input")]
        public string InputFile { get; set; } = string.Empty;

        [Option('o', "outputFile", Required = true, HelpText = "Transformed output file")]
        public string OutputFile { get; set; } = string.Empty;

        [Option('a', "action", Required = true, HelpText = "Possible options: CREATE, DELETE, UPSERT")]
        public string Action { get; set; } = string.Empty;

        [Option('c', "comment", Required = false, HelpText = "Comment")]
        public string Comment { get; set; } = string.Empty;

        [Option('n', "ignoreNsAndSoa", Required = false, Default = false, HelpText = "Ignore NS and SOA record")]
        public bool IgnoreNsAndSoa { get; set; }
    }
}