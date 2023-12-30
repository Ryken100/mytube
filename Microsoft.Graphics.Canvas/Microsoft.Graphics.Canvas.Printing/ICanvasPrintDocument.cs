using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasPrintDocument))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(177851886u, 48913, 18896, 170, 52, 59, 165, 195, 44, 81, 165)]
	internal interface ICanvasPrintDocument : IDisposable, ICanvasResourceCreator, IPrintDocumentSource
	{
		event TypedEventHandler<CanvasPrintDocument, CanvasPrintTaskOptionsChangedEventArgs> PrintTaskOptionsChanged;

		event TypedEventHandler<CanvasPrintDocument, CanvasPreviewEventArgs> Preview;

		event TypedEventHandler<CanvasPrintDocument, CanvasPrintEventArgs> Print;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InvalidatePreview();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetPageCount([In] uint count);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetIntermediatePageCount([In] uint count);
	}
}
