using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Flags]
	public enum CanvasSpriteFlip : uint
	{
		None = 0u,
		Horizontal = 1u,
		Vertical = 2u,
		Both = 3u
	}
}
