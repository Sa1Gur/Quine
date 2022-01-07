using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Quine.Test;

public class QuineTest
{
    [Fact]
    public async Task Test_Is_It_Quine()
    {
        var code = await File.ReadAllTextAsync("../../Quine/Program.cs");
        Process quineExe = new()
        {
            StartInfo = new ("Quine.exe")
            {
                RedirectStandardOutput = true
            }
        };
        quineExe.Start();
        var output = await quineExe.StandardOutput.ReadToEndAsync();
        Assert.Equal(code, output);
    }
}