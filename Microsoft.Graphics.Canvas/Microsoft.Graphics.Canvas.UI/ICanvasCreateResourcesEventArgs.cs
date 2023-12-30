using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	[ComImport]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3989119240u, 63162, 18953, 159, 163, 16, 201, 122, 36, 228, 154)]
	[ExclusiveTo(typeof(CanvasCreateResourcesEventArgs))]
	internal interface ICanvasCreateResourcesEventArgs
	{
		CanvasCreateResourcesReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void TrackAsyncAction([In] IAsyncAction action);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncAction GetTrackedAction();
	}
}
