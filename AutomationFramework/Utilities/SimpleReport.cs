using System;
using System.IO;

namespace SwagLabsAutomation.Utilities
{
    public static class SimpleReport
    {
        private static string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "TestReport.html");

        public static void Log(string testName, string status)
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Reports"));

            string color = status == "PASS" ? "green" : "red";
            string htmlLine = $"<tr><td>{testName}</td><td style='color:{color}'>{status}</td><td>{DateTime.Now}</td></tr>";

            if (!File.Exists(reportPath))
            {
                File.WriteAllText(reportPath, "<html><head><title>Test Report</title></head><body><h2>Automation Report</h2><table border='1'><tr><th>Test Name</th><th>Status</th><th>Execution Time</th></tr>");
            }

            File.AppendAllText(reportPath, htmlLine);
        }

        public static void FinalizeReport()
        {
            if (File.Exists(reportPath))
            {
                File.AppendAllText(reportPath, "</table></body></html>");
            }
        }
    }
}
