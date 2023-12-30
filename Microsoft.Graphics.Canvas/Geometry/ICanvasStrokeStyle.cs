using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x0200004F RID: 79
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasStrokeStyle))]
	[Guid(4248706258U, 24601, 16545, 179, 21, 38, 126, 239, 108, 42, 235)]
	internal interface ICanvasStrokeStyle : IClosable
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000232 RID: 562
		// (set) Token: 0x06000233 RID: 563
		CanvasCapStyle StartCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000234 RID: 564
		// (set) Token: 0x06000235 RID: 565
		CanvasCapStyle EndCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000236 RID: 566
		// (set) Token: 0x06000237 RID: 567
		CanvasCapStyle DashCap
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000238 RID: 568
		// (set) Token: 0x06000239 RID: 569
		CanvasLineJoin LineJoin
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600023A RID: 570
		// (set) Token: 0x0600023B RID: 571
		float MiterLimit
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600023C RID: 572
		// (set) Token: 0x0600023D RID: 573
		CanvasDashStyle DashStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600023E RID: 574
		// (set) Token: 0x0600023F RID: 575
		float DashOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000240 RID: 576
		// (set) Token: 0x06000241 RID: 577
		float[] CustomDashStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000242 RID: 578
		// (set) Token: 0x06000243 RID: 579
		CanvasStrokeTransformBehavior TransformBehavior
		{
			get; [param: In]
			set;
		}
	}
}
