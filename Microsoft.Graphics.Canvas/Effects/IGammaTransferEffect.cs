using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000142 RID: 322
	[Version(167772160U)]
	[ExclusiveTo(typeof(GammaTransferEffect))]
	[Guid(3025628011U, 27710, 21322, 133, 118, 212, 109, 244, 252, 233, 61)]
	internal interface IGammaTransferEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000C1C RID: 3100
		// (set) Token: 0x06000C1D RID: 3101
		float RedAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000C1E RID: 3102
		// (set) Token: 0x06000C1F RID: 3103
		float RedExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000C20 RID: 3104
		// (set) Token: 0x06000C21 RID: 3105
		float RedOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000C22 RID: 3106
		// (set) Token: 0x06000C23 RID: 3107
		bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000C24 RID: 3108
		// (set) Token: 0x06000C25 RID: 3109
		float GreenAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000C26 RID: 3110
		// (set) Token: 0x06000C27 RID: 3111
		float GreenExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000C28 RID: 3112
		// (set) Token: 0x06000C29 RID: 3113
		float GreenOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000C2A RID: 3114
		// (set) Token: 0x06000C2B RID: 3115
		bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000C2C RID: 3116
		// (set) Token: 0x06000C2D RID: 3117
		float BlueAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000C2E RID: 3118
		// (set) Token: 0x06000C2F RID: 3119
		float BlueExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000C30 RID: 3120
		// (set) Token: 0x06000C31 RID: 3121
		float BlueOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000C32 RID: 3122
		// (set) Token: 0x06000C33 RID: 3123
		bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000C34 RID: 3124
		// (set) Token: 0x06000C35 RID: 3125
		float AlphaAmplitude
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000C36 RID: 3126
		// (set) Token: 0x06000C37 RID: 3127
		float AlphaExponent
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000C38 RID: 3128
		// (set) Token: 0x06000C39 RID: 3129
		float AlphaOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000C3A RID: 3130
		// (set) Token: 0x06000C3B RID: 3131
		bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000C3C RID: 3132
		// (set) Token: 0x06000C3D RID: 3133
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000C3E RID: 3134
		// (set) Token: 0x06000C3F RID: 3135
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
