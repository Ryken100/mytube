using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasAnalyzedScript
	{
		public int ScriptIdentifier;

		public CanvasScriptShape Shape;
	}
}
