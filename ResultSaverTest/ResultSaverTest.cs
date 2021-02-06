using System;
using System.IO;
using Xunit;
using Implementations;

namespace ResultSaverTest
{
    public class ResultSaverTest
    {
        [Fact]
        public void TryToSave()
        {
            var saver = new ResultSaver();
            var result = "Result";
            saver.SaveResult(result);

            var parentDir = Directory.GetParent(Directory.GetCurrentDirectory());
            parentDir = Directory.GetParent(parentDir.ToString());
            parentDir = Directory.GetParent(parentDir.ToString());
            var targetDir = $"{parentDir}/data";
            var targetFile = $"{targetDir}/file";
            bool assert = File.Exists(targetFile);
            Assert.True(assert);
        }
    }
}
