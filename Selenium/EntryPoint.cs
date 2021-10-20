using NUnit.Framework;
using Selenium.SpecialElements;
using System.Threading;

namespace Selenium
{
    public class EntryPoint
    {
        private static void Main()
        {
            var javaScriptExecutor = new JavaScriptExecutor();
            javaScriptExecutor.Run();

        }
    }
}
