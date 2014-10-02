using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
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
            RegistrationServices regsrv = new RegistrationServices();
            regsrv.RegisterAssembly(GetType().Assembly, AssemblyRegistrationFlags.SetCodeBase);
            base.OnAfterInstall(savedState);
        }

        protected override void OnAfterUninstall(IDictionary savedState)
        {
            RegistrationServices regsrv = new RegistrationServices();
            regsrv.UnregisterAssembly(GetType().Assembly);
            base.OnAfterUninstall(savedState);
        }
    }
}
