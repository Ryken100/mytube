using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200010D RID: 269
	[Guid(3425767516U, 887, 22280, 132, 132, 26, 216, 238, 62, 85, 75)]
	[ExclusiveTo(typeof(AlphaMaskEffect))]
	[Version(167772160U)]
	internal interface IAlphaMaskEffectStatics
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060008F8 RID: 2296
		bool IsSupported { get; }
	}
}
