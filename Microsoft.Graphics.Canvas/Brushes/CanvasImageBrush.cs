using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000036 RID: 54
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	[Activatable(typeof(ICanvasImageBrushFactory), 167772160U)]
	public sealed class CanvasImageBrush : ICanvasImageBrush, ICanvasBrush, IClosable
	{
		// Token: 0x0600005D RID: 93
		public extern CanvasImageBrush([In] ICanvasResourceCreator resourceCreator);

		// Token: 0x0600005E RID: 94
		public extern CanvasImageBrush([In] ICanvasResourceCreator resourceCreator, [In] ICanvasImage image);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005F RID: 95
		// (set) Token: 0x06000060 RID: 96
		public extern ICanvasImage Image
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000061 RID: 97
		// (set) Token: 0x06000062 RID: 98
		public extern CanvasEdgeBehavior ExtendX
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000063 RID: 99
		// (set) Token: 0x06000064 RID: 100
		public extern CanvasEdgeBehavior ExtendY
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000065 RID: 101
		// (set) Token: 0x06000066 RID: 102
		public extern IReference<Rect> SourceRectangle
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000067 RID: 103
		// (set) Token: 0x06000068 RID: 104
		public extern CanvasImageInterpolation Interpolation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000069 RID: 105
		// (set) Token: 0x0600006A RID: 106
		public extern float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600006B RID: 107
		// (set) Token: 0x0600006C RID: 108
		public extern Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006D RID: 109
		public extern CanvasDevice Device { get; }

		// Token: 0x0600006E RID: 110
		public extern void Close();
	}
}
