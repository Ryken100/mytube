using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Flags]
	public enum CanvasSpriteOptions : uint
	{
		None = 0u,
		ClampToSourceRect = 1u
	}
}
