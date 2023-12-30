using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000162 RID: 354
	[ExclusiveTo(typeof(PremultiplyEffect))]
	[Guid(3533348126U, 48471, 24382, 154, 224, 0, 156, 106, 197, 176, 109)]
	[Version(167772160U)]
	internal interface IPremultiplyEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000E28 RID: 3624
		// (set) Token: 0x06000E29 RID: 3625
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
