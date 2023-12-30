using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasComposite
	{
		SourceOver,
		DestinationOver,
		SourceIn,
		DestinationIn,
		SourceOut,
		DestinationOut,
		SourceAtop,
		DestinationAtop,
		Xor,
		Add,
		Copy,
		BoundedCopy,
		MaskInvert
	}
}
