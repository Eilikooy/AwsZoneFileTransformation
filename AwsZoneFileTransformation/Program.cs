using AwsZoneFileTransformation.Models;
using CommandLine;
using System.Text.Json;

namespace AwsZoneFileTransformation 
{
    public class Program
    {
        private static CliOptions cliOptions = new CliOptions();
        public async static Task Main(string[] args)
        {
            Parser.Default.ParseArguments<CliOptions>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);

            var importFileModel = new ImportFileModel();
            var change = new List<Change>();

            try
            {
                importFileModel.Comment = cliOptions.Comment;
                var items = JsonSerializer.Deserialize<ExportFileModel>(await File.ReadAllTextAsync(cliOptions.InputFile));
                foreach (var item in items?.ResourceRecordSets)
                {
                    if (cliOptions.IgnoreNsAndSoa)
                    {
                        switch (item.Type)
                        {
                            case "NS":
                                break;
                            case "SOA":
                                break;
                            default:
                                change.Add(new Change { Action = cliOptions.Action, ResourceRecordSet = item });
                                break;
                        }
                    }
                    else
                    {
                        change.Add(new Change { Action = cliOptions.Action, ResourceRecordSet = item });
                    }
                }
                importFileModel.Changes.AddRange(change);
                await File.WriteAllTextAsync(cliOptions.OutputFile, JsonSerializer.Serialize(importFileModel, new JsonSerializerOptions { WriteIndented = true }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void RunOptions(CliOptions opts)
        {
            cliOptions = opts;
        }
        static void HandleParseError(IEnumerable<Error> errs)
        {
            //handle errors
        }
    }
}