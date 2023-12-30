using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x0200014E RID: 334
	[Version(167772160U)]
	[Guid(3568160252U, 3936, 21069, 147, 106, 127, 39, 54, 173, 51, 216)]
	[ExclusiveTo(typeof(InvertEffect))]
	internal interface IInvertEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IClosable
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000CF4 RID: 3316
		// (set) Token: 0x06000CF5 RID: 3317
		IGraphicsEffectSource Source
		{
			get; [param: In]
			set;
		}
	}
}
