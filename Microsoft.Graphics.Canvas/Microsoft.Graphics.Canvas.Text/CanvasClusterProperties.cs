using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	[Flags]
	public enum CanvasClusterProperties : uint
	{
		None = 0u,
		CanWrapLineAfter = 1u,
		Whitespace = 2u,
		Newline = 4u,
		SoftHyphen = 8u,
		RightToLeft = 0x10u
	}
}
