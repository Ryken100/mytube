using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000D7 RID: 215
	[ExclusiveTo(typeof(CanvasPrintDocument))]
	[Version(167772160U)]
	[Guid(177851886U, 48913, 18896, 170, 52, 59, 165, 195, 44, 81, 165)]
	internal interface ICanvasPrintDocument : IClosable, ICanvasResourceCreator, IPrintDocumentSource
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600071A RID: 1818
		// (remove) Token: 0x0600071B RID: 1819
		event TypedEventHandler<CanvasPrintDocument, CanvasPrintTaskOptionsChangedEventArgs> PrintTaskOptionsChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600071C RID: 1820
		// (remove) Token: 0x0600071D RID: 1821
		event TypedEventHandler<CanvasPrintDocument, CanvasPreviewEventArgs> Preview;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600071E RID: 1822
		// (remove) Token: 0x0600071F RID: 1823
		event TypedEventHandler<CanvasPrintDocument, CanvasPrintEventArgs> Print;

		// Token: 0x06000720 RID: 1824
		void InvalidatePreview();

		// Token: 0x06000721 RID: 1825
		void SetPageCount([In] uint count);

		// Token: 0x06000722 RID: 1826
		void SetIntermediatePageCount([In] uint count);
	}
}
