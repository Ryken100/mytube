using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000168 RID: 360
	[Guid(1965207184U, 48834, 20780, 188, 192, 77, 106, 151, 227, 237, 52)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(ScaleEffect))]
	internal interface IScaleEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000E66 RID: 3686
		// (set) Token: 0x06000E67 RID: 3687
		Vector2 Scale
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000E68 RID: 3688
		// (set) Token: 0x06000E69 RID: 3689
		Vector2 CenterPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000E6A RID: 3690
		// (set) Token: 0x06000E6B RID: 3691
		CanvasImageInterpolation InterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000E6C RID: 3692
		// (set) Token: 0x06000E6D RID: 3693
		EffectBorderMode BorderMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000E6E RID: 3694
		// (set) Token: 0x06000E6F RID: 3695
		float Sharpness
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000E70 RID: 3696
		// (set) Token: 0x06000E71 RID: 3697
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
