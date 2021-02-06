using System;
using System.IO;
using WSP.Abstractions;

namespace Implementations
{
    public class ResultSaver: IResultSaver<string>
    {
        public void SaveResult(string result)
        {
            var parentDir = Directory.GetParent(Directory.GetCurrentDirectory());
            parentDir = Directory.GetParent(parentDir.ToString());
            parentDir = Directory.GetParent(parentDir.ToString());
            var targetDir = $"{parentDir}/data";
            var targetFile = $"{targetDir}/file";
            File.WriteAllText(targetFile, result);
        }
    }
}
