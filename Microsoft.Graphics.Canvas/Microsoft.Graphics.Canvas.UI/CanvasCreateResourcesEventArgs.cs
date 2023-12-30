using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	[ComImport]
	[Activatable(typeof(ICanvasCreateResourcesEventArgsFactory), 167772160u)]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasCreateResourcesEventArgs : ICanvasCreateResourcesEventArgs
	{
		public extern CanvasCreateResourcesReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void TrackAsyncAction([In] IAsyncAction action);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IAsyncAction GetTrackedAction();
	}
}
