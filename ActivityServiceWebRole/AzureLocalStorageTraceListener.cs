using System;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace ActivityServiceWebRole
{
    public class AzureLocalStorageTraceListener : XmlWriterTraceListener
    {
        public AzureLocalStorageTraceListener()
            : base(Path.Combine(AzureLocalStorageTraceListener.GetLogDirectory().Path, "ActivityServiceWebRole.svclog"))
        {
        }

        public static DirectoryConfiguration GetLogDirectory()
        {
            DirectoryConfiguration directory = new DirectoryConfiguration();
            directory.Container = "wad-tracefiles";
            directory.DirectoryQuotaInMB = 10;
            if (RoleEnvironment.IsAvailable)
                directory.Path = RoleEnvironment.GetLocalResource("ActivityServiceWebRole.svclog").RootPath;
            else
                directory.Path = "c:\\";
            return directory;
        }
    }
}
