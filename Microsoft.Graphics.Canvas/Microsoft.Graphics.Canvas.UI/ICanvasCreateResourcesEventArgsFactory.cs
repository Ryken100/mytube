using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasCreateResourcesEventArgs))]
	[Windows.Foundation.Metadata.Guid(975292262u, 1921, 17289, 187, 195, 134, 177, 245, 2, 42, 241)]
	[Version(167772160u)]
	internal interface ICanvasCreateResourcesEventArgsFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasCreateResourcesEventArgs Create([In] CanvasCreateResourcesReason createResourcesReason);
	}
}
