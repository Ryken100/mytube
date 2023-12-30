using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000178 RID: 376
	[ExclusiveTo(typeof(TableTransfer3DEffect))]
	[Version(167772160U)]
	[Guid(4010395360U, 37943, 21495, 183, 180, 181, 60, 121, 160, 188, 55)]
	internal interface ITableTransfer3DEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000FAE RID: 4014
		// (set) Token: 0x06000FAF RID: 4015
		EffectTransferTable3D Table
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000FB0 RID: 4016
		// (set) Token: 0x06000FB1 RID: 4017
		CanvasAlphaMode AlphaMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000FB2 RID: 4018
		// (set) Token: 0x06000FB3 RID: 4019
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
