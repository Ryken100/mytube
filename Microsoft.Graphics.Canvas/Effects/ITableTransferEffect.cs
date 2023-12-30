using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000176 RID: 374
	[Guid(3205194678U, 65143, 20888, 162, 161, 63, 184, 12, 38, 139, 143)]
	[ExclusiveTo(typeof(TableTransferEffect))]
	[Version(167772160U)]
	internal interface ITableTransferEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000F78 RID: 3960
		// (set) Token: 0x06000F79 RID: 3961
		float[] RedTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000F7A RID: 3962
		// (set) Token: 0x06000F7B RID: 3963
		bool RedDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000F7C RID: 3964
		// (set) Token: 0x06000F7D RID: 3965
		float[] GreenTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000F7E RID: 3966
		// (set) Token: 0x06000F7F RID: 3967
		bool GreenDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000F80 RID: 3968
		// (set) Token: 0x06000F81 RID: 3969
		float[] BlueTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000F82 RID: 3970
		// (set) Token: 0x06000F83 RID: 3971
		bool BlueDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000F84 RID: 3972
		// (set) Token: 0x06000F85 RID: 3973
		float[] AlphaTable
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F86 RID: 3974
		// (set) Token: 0x06000F87 RID: 3975
		bool AlphaDisable
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000F88 RID: 3976
		// (set) Token: 0x06000F89 RID: 3977
		bool ClampOutput
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000F8A RID: 3978
		// (set) Token: 0x06000F8B RID: 3979
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
