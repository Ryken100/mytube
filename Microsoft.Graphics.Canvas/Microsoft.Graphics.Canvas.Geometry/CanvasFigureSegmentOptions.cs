using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Version(167772160u)]
	[Flags]
	public enum CanvasFigureSegmentOptions : uint
	{
		None = 0u,
		ForceUnstroked = 1u,
		ForceRoundLineJoin = 2u
	}
}
