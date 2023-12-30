using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Flags]
	[Version(167772160u)]
	public enum CanvasFontSimulations : uint
	{
		None = 0u,
		Bold = 1u,
		Oblique = 2u
	}
}
