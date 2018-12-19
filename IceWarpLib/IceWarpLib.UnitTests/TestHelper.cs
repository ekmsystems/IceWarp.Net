using System.IO;
using System.Reflection;

namespace IceWarpLib.UnitTests {
	public static class TestHelper {
		public static string GetTestsPath() {
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:", string.Empty).TrimStart('\\');
		}
	}
}
