using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSpriteBatch))]
	[Windows.Foundation.Metadata.Guid(2233381005u, 40193, 19287, 158, 148, 36, 17, 49, 81, 183, 75)]
	internal interface ICanvasSpriteBatchStatics
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsSupported([In] CanvasDevice device);
	}
}
