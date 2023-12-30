using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200012D RID: 301
	[ExclusiveTo(typeof(CrossFadeEffect))]
	[Guid(2746643248U, 25220, 24310, 153, 232, 180, 176, 93, 43, 139, 252)]
	[Version(167772160U)]
	internal interface ICrossFadeEffectStatics
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000AB0 RID: 2736
		bool IsSupported { get; }
	}
}
