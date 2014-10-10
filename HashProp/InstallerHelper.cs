using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SetupHelper
{
    [RunInstaller(true)]
    public partial class InstallerHelper : System.Configuration.Install.Installer
    {
        public InstallerHelper()
        {
            InitializeComponent();
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            var thisFile = Uri.UnescapeDataString(new UriBuilder(GetType().Assembly.CodeBase).Path);
            var srm = Path.Combine(Path.GetDirectoryName(thisFile), "srm.exe");

            var startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = Path.GetDirectoryName(thisFile);
            startInfo.FileName = srm;
            startInfo.Arguments = "install \"" + thisFile + "\" -codebase";
            startInfo.Verb = "runas";
            var p = Process.Start(startInfo);
            p.WaitForExit();

            base.OnAfterInstall(savedState);
        }

        protected override void OnAfterUninstall(IDictionary savedState)
        {
            var thisFile = Uri.UnescapeDataString(new UriBuilder(GetType().Assembly.CodeBase).Path);
            var srm = Path.Combine(Path.GetDirectoryName(thisFile), "srm.exe");

            var startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = Path.GetDirectoryName(thisFile);
            startInfo.FileName = srm;
            startInfo.Arguments = "uninstall \"" + thisFile + "\"";
            startInfo.Verb = "runas";
            var p = Process.Start(startInfo);
            p.WaitForExit();

            base.OnAfterUninstall(savedState);
        }
    }
}
