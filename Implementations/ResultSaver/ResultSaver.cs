using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using WSP.Abstractions;

namespace Implementations
{
    public class ResultSaver: IResultSaver<string>
    {
        public void SaveResult(string result)
        {
            var dir = Directory.GetCurrentDirectory();
            var path = Directory.GetCurrentDirectory();
            var targetDir = $"{path}/data";
            var targetFile = $"{path}/data/file";
            File.WriteAllText(targetFile, "Data");
        }
    }
}
