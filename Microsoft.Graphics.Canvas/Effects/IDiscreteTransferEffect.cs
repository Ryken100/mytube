using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000131 RID: 305
	[Guid(2132759801U, 8629, 23441, 149, 6, 131, 44, 83, 111, 221, 250)]
	[ExclusiveTo(typeof(DiscreteTransferEffect))]
	[Version(167772160U)]
	internal interface IDiscreteTransferEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000AE8 RID: 2792
		// (set) Token: 0x06000AE9 RID: 2793
		float[] RedTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000AEA RID: 2794
		// (set) Token: 0x06000AEB RID: 2795
		bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000AEC RID: 2796
		// (set) Token: 0x06000AED RID: 2797
		float[] GreenTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000AEE RID: 2798
		// (set) Token: 0x06000AEF RID: 2799
		bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000AF0 RID: 2800
		// (set) Token: 0x06000AF1 RID: 2801
		float[] BlueTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000AF2 RID: 2802
		// (set) Token: 0x06000AF3 RID: 2803
		bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000AF4 RID: 2804
		// (set) Token: 0x06000AF5 RID: 2805
		float[] AlphaTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000AF6 RID: 2806
		// (set) Token: 0x06000AF7 RID: 2807
		bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000AF8 RID: 2808
		// (set) Token: 0x06000AF9 RID: 2809
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000AFA RID: 2810
		// (set) Token: 0x06000AFB RID: 2811
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
