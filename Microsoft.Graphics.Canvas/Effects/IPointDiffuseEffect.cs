using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200015C RID: 348
	[ExclusiveTo(typeof(PointDiffuseEffect))]
	[Guid(1825442284U, 63559, 22113, 175, 75, 83, 29, 211, 221, 125, 110)]
	[Version(167772160U)]
	internal interface IPointDiffuseEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000DAA RID: 3498
		// (set) Token: 0x06000DAB RID: 3499
		Vector3 LightPosition
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000DAC RID: 3500
		// (set) Token: 0x06000DAD RID: 3501
		float DiffuseAmount
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000DAE RID: 3502
		// (set) Token: 0x06000DAF RID: 3503
		float HeightMapScale
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000DB0 RID: 3504
		// (set) Token: 0x06000DB1 RID: 3505
		Color LightColor
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000DB2 RID: 3506
		// (set) Token: 0x06000DB3 RID: 3507
		Vector2 HeightMapKernelSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000DB4 RID: 3508
		// (set) Token: 0x06000DB5 RID: 3509
		CanvasImageInterpolation HeightMapInterpolationMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000DB6 RID: 3510
		// (set) Token: 0x06000DB7 RID: 3511
		Vector4 LightColorHdr
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000DB8 RID: 3512
		// (set) Token: 0x06000DB9 RID: 3513
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
