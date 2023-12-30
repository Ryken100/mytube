using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasFontProperty
	{
		public CanvasFontPropertyIdentifier Identifier;

		public string Value;

		public string Locale;
	}
}
