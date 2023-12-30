using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000032 RID: 50
	[Version(167772160U)]
	[Activatable(typeof(ICanvasSolidColorBrushFactory), 167772160U)]
	[MarshalingBehavior(2)]
	[Static(typeof(ICanvasSolidColorBrushStatics), 167772160U)]
	[Threading(3)]
	public sealed class CanvasSolidColorBrush : ICanvasSolidColorBrush, ICanvasBrush, IClosable
	{
		// Token: 0x0600004A RID: 74
		public extern CanvasSolidColorBrush([In] ICanvasResourceCreator resourceCreator, [In] Color color);

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004B RID: 75
		// (set) Token: 0x0600004C RID: 76
		public extern Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004D RID: 77
		// (set) Token: 0x0600004E RID: 78
		public extern Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004F RID: 79
		// (set) Token: 0x06000050 RID: 80
		public extern float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000051 RID: 81
		// (set) Token: 0x06000052 RID: 82
		public extern Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000053 RID: 83
		public extern CanvasDevice Device { get; }

		// Token: 0x06000054 RID: 84
		public extern void Close();

		// Token: 0x06000055 RID: 85
		public static extern CanvasSolidColorBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 colorHdr);
	}
}
