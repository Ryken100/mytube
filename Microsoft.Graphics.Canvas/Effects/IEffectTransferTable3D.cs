using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000109 RID: 265
	[ExclusiveTo(typeof(EffectTransferTable3D))]
	[Version(167772160U)]
	[Guid(2062576518U, 11333, 18888, 143, 68, 225, 90, 109, 79, 164, 78)]
	internal interface IEffectTransferTable3D : IClosable
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008ED RID: 2285
		CanvasDevice Device { get; }
	}
}
