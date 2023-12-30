using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasPrintTaskOptionsChangedEventArgs : ICanvasPrintTaskOptionsChangedEventArgs
	{
		public extern uint NewPreviewPageNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern uint CurrentPreviewPageNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern PrintTaskOptions PrintTaskOptions
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasPrintDeferral GetDeferral();
	}
}
