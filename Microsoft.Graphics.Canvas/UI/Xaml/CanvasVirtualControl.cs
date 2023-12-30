using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000FA RID: 250
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	public sealed class CanvasVirtualControl : UserControl, ICanvasVirtualControl, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x06000816 RID: 2070
		public extern CanvasVirtualControl();

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000817 RID: 2071
		// (remove) Token: 0x06000818 RID: 2072
		public extern event TypedEventHandler<CanvasVirtualControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000819 RID: 2073
		public extern bool ReadyToDraw { get; }

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600081A RID: 2074
		// (remove) Token: 0x0600081B RID: 2075
		public extern event TypedEventHandler<CanvasVirtualControl, CanvasRegionsInvalidatedEventArgs> RegionsInvalidated;

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600081D RID: 2077
		// (set) Token: 0x0600081C RID: 2076
		public extern Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600081E RID: 2078
		public extern CanvasDrawingSession CreateDrawingSession([In] Rect updateRectangle);

		// Token: 0x0600081F RID: 2079
		public extern void SuspendDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x06000820 RID: 2080
		public extern void ResumeDrawingSession([In] CanvasDrawingSession drawingSession);

		// Token: 0x06000821 RID: 2081
		[Overload("Invalidate")]
		public extern void Invalidate();

		// Token: 0x06000822 RID: 2082
		[Overload("InvalidateRegion")]
		public extern void Invalidate([In] Rect region);

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000823 RID: 2083
		public extern Size Size { get; }

		// Token: 0x06000824 RID: 2084
		public extern void RemoveFromVisualTree();

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000825 RID: 2085
		// (set) Token: 0x06000826 RID: 2086
		public extern bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000827 RID: 2087
		// (set) Token: 0x06000828 RID: 2088
		public extern bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000829 RID: 2089
		// (set) Token: 0x0600082A RID: 2090
		public extern CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600082B RID: 2091
		// (set) Token: 0x0600082C RID: 2092
		public extern float DpiScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600082D RID: 2093
		public extern float Dpi { get; }

		// Token: 0x0600082E RID: 2094
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x0600082F RID: 2095
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000830 RID: 2096
		public extern CanvasDevice Device { get; }
	}
}
