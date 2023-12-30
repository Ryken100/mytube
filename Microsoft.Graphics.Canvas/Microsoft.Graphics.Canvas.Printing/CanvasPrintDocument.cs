using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[Activatable(167772160u)]
	[Activatable(typeof(ICanvasPrintDocumentFactory), 167772160u)]
	[Version(167772160u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasPrintDocument : ICanvasPrintDocument, IPrintDocumentSource, ICanvasResourceCreator, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[method: In]
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPreviewEventArgs> Preview;

		[method: In]
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPrintEventArgs> Print;

		[method: In]
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPrintTaskOptionsChangedEventArgs> PrintTaskOptionsChanged;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void InvalidatePreview();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetPageCount([In] uint count);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetIntermediatePageCount([In] uint count);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
