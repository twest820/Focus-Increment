using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FocusIncrement.Test
{
    [TestClass]
    [DeploymentItem(TestConstant.HeliconProjectB)]
    [DeploymentItem(TestConstant.HeliconProjectC)]
    public class Helicon
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ConvertHelicon()
        {
            string deploymentDirectory = this.TestContext.DeploymentDirectory;
            this.EnsureMockOutput(deploymentDirectory, "P1070726B.hproj");
            this.EnsureMockOutput(deploymentDirectory, "P1070726C.hproj");

            ConvertHelicon convertHelicon = new ConvertHelicon()
            {
                StackDirectory = deploymentDirectory
            };
            List<object> _ = convertHelicon.Invoke<object>().ToList();
        }

        private void EnsureMockOutput(string workingDirectory, string projectFileName)
        {
            string filesPath = Path.Combine(workingDirectory, Path.GetFileNameWithoutExtension(projectFileName) + "_files");
            if (Directory.Exists(filesPath) == false)
            {
                Directory.CreateDirectory(filesPath);
            }
            string mockOutputPath = Path.Combine(filesPath, "result.tiff");
            if (File.Exists(mockOutputPath) == false)
            {
                using FileStream _ = File.Create(mockOutputPath);
            }
        }
    }
}
