using System;
using System.Collections.Generic;
using System.Text;

namespace ETJump.LogParser
{
    public enum LogEntryType
    {
        ChatMessage,
        TeamChatMessage,
        FireTeamChatMessage
    }

    public class LogEntry
    {
        public LogEntryType Type { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
    }
}
