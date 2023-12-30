using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000037 RID: 55
	[ExclusiveTo(typeof(CanvasImageBrush))]
	[Guid(1512162535U, 54352, 18754, 139, 189, 240, 23, 9, 122, 183, 99)]
	[Version(167772160U)]
	internal interface ICanvasImageBrush : ICanvasBrush, IClosable
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006F RID: 111
		// (set) Token: 0x06000070 RID: 112
		ICanvasImage Image
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x06000072 RID: 114
		CanvasEdgeBehavior ExtendX
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115
		// (set) Token: 0x06000074 RID: 116
		CanvasEdgeBehavior ExtendY
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000075 RID: 117
		// (set) Token: 0x06000076 RID: 118
		IReference<Rect> SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119
		// (set) Token: 0x06000078 RID: 120
		CanvasImageInterpolation Interpolation
		{
			get; [param: In]
			set;
		}
	}
}
