using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000D6 RID: 214
	[Activatable(167772160U)]
	[Activatable(typeof(ICanvasPrintDocumentFactory), 167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasPrintDocument : ICanvasPrintDocument, IPrintDocumentSource, ICanvasResourceCreator, IClosable
	{
		// Token: 0x0600070D RID: 1805
		public extern CanvasPrintDocument([In] CanvasDevice device);

		// Token: 0x0600070E RID: 1806
		public extern CanvasPrintDocument();

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600070F RID: 1807
		// (remove) Token: 0x06000710 RID: 1808
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPrintTaskOptionsChangedEventArgs> PrintTaskOptionsChanged;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000711 RID: 1809
		// (remove) Token: 0x06000712 RID: 1810
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPreviewEventArgs> Preview;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000713 RID: 1811
		// (remove) Token: 0x06000714 RID: 1812
		public extern event TypedEventHandler<CanvasPrintDocument, CanvasPrintEventArgs> Print;

		// Token: 0x06000715 RID: 1813
		public extern void InvalidatePreview();

		// Token: 0x06000716 RID: 1814
		public extern void SetPageCount([In] uint count);

		// Token: 0x06000717 RID: 1815
		public extern void SetIntermediatePageCount([In] uint count);

		// Token: 0x06000718 RID: 1816
		public extern void Close();

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000719 RID: 1817
		public extern CanvasDevice Device { get; }
	}
}
