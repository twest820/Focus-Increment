using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FocusIncrement.Test
{
    [TestClass]
    [DeploymentItem(TestConstant.ZereneProject)]
    public class Zerene
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void GetAlignment()
        {
            GetAlignment getAlignment = new GetAlignment()
            {
                Project = Path.Combine(this.TestContext.DeploymentDirectory, TestConstant.ZereneProject)
            };
            List<object> _ = getAlignment.Invoke<object>().ToList();
        }
    }
}
