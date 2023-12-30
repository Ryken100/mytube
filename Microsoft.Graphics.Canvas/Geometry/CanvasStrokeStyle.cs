using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000050 RID: 80
	[Activatable(167772160U)]
	[Version(167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasStrokeStyle : ICanvasStrokeStyle, IClosable
	{
		// Token: 0x06000244 RID: 580
		public extern CanvasStrokeStyle();

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000245 RID: 581
		// (set) Token: 0x06000246 RID: 582
		public extern CanvasCapStyle StartCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000247 RID: 583
		// (set) Token: 0x06000248 RID: 584
		public extern CanvasCapStyle EndCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000249 RID: 585
		// (set) Token: 0x0600024A RID: 586
		public extern CanvasCapStyle DashCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600024B RID: 587
		// (set) Token: 0x0600024C RID: 588
		public extern CanvasLineJoin LineJoin
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600024D RID: 589
		// (set) Token: 0x0600024E RID: 590
		public extern float MiterLimit
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600024F RID: 591
		// (set) Token: 0x06000250 RID: 592
		public extern CanvasDashStyle DashStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000251 RID: 593
		// (set) Token: 0x06000252 RID: 594
		public extern float DashOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000253 RID: 595
		// (set) Token: 0x06000254 RID: 596
		public extern float[] CustomDashStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000255 RID: 597
		// (set) Token: 0x06000256 RID: 598
		public extern CanvasStrokeTransformBehavior TransformBehavior
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000257 RID: 599
		public extern void Close();
	}
}
