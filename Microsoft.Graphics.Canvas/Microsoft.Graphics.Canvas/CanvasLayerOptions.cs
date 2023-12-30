using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Flags]
	public enum CanvasLayerOptions : uint
	{
		None = 0u,
		InitializeFromBackground = 1u,
		IgnoreAlpha = 2u
	}
}
