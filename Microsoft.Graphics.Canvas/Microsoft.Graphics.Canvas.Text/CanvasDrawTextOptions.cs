using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Flags]
	[Version(167772160u)]
	public enum CanvasDrawTextOptions : uint
	{
		Default = 0u,
		NoPixelSnap = 1u,
		Clip = 2u,
		EnableColorFont = 4u
	}
}
