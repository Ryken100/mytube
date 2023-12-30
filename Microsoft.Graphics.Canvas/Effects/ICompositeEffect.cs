using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000124 RID: 292
	[Version(167772160U)]
	[ExclusiveTo(typeof(CompositeEffect))]
	[Guid(4169174088U, 52679, 23988, 128, 124, 185, 52, 79, 247, 25, 132)]
	internal interface ICompositeEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000A24 RID: 2596
		// (set) Token: 0x06000A25 RID: 2597
		CanvasComposite Mode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A26 RID: 2598
		IVector<IGraphicsEffectSource> Sources { get; }
	}
}
