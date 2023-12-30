using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000188 RID: 392
	[Guid(1930005428U, 56561, 21507, 175, 68, 51, 68, 210, 152, 45, 64)]
	[ExclusiveTo(typeof(UnPremultiplyEffect))]
	[Version(167772160U)]
	internal interface IUnPremultiplyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001082 RID: 4226
		// (set) Token: 0x06001083 RID: 4227
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
