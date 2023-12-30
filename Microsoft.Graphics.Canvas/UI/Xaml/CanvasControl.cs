using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F1 RID: 241
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Activatable(167772160U)]
	[Threading(3)]
	public sealed class CanvasControl : UserControl, ICanvasControl, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060007B2 RID: 1970
		public extern CanvasControl();

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060007B3 RID: 1971
		// (remove) Token: 0x060007B4 RID: 1972
		public extern event TypedEventHandler<CanvasControl, CanvasCreateResourcesEventArgs> CreateResources;

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060007B5 RID: 1973
		public extern bool ReadyToDraw { get; }

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060007B6 RID: 1974
		// (remove) Token: 0x060007B7 RID: 1975
		public extern event TypedEventHandler<CanvasControl, CanvasDrawEventArgs> Draw;

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060007B9 RID: 1977
		// (set) Token: 0x060007B8 RID: 1976
		public extern Color ClearColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x060007BA RID: 1978
		public extern void Invalidate();

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060007BB RID: 1979
		public extern Size Size { get; }

		// Token: 0x060007BC RID: 1980
		public extern void RemoveFromVisualTree();

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060007BD RID: 1981
		// (set) Token: 0x060007BE RID: 1982
		public extern bool UseSharedDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060007BF RID: 1983
		// (set) Token: 0x060007C0 RID: 1984
		public extern bool ForceSoftwareRenderer
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060007C1 RID: 1985
		// (set) Token: 0x060007C2 RID: 1986
		public extern CanvasDevice CustomDevice
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060007C3 RID: 1987
		// (set) Token: 0x060007C4 RID: 1988
		public extern float DpiScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060007C5 RID: 1989
		public extern float Dpi { get; }

		// Token: 0x060007C6 RID: 1990
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x060007C7 RID: 1991
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060007C8 RID: 1992
		public extern CanvasDevice Device { get; }
	}
}
