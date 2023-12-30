using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasBufferPrecision
	{
		Precision8UIntNormalized,
		Precision8UIntNormalizedSrgb,
		Precision16UIntNormalized,
		Precision16Float,
		Precision32Float
	}
}
