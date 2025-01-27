namespace PipelineRunner
{
    public class Config
    {
        public required string WatchDirectory { get; set; }
        public required string FileSearchPattern { get; set; }
        public required string CommandsFile { get; set; }
        public int CycleTimeSeconds { get; set; }
        public string LogDirectory { get; set; } = "/logs";
        public string? UseLineFilterPrefix { get; set; }
        public int ProcessTimeoutSeconds { get; set; }
        public string? MinimumLogLevel { get; set; }
        public bool ContinueOnError { get; set; } = false;
    }
}
