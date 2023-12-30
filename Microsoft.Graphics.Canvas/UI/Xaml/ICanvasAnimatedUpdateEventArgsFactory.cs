using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000E1 RID: 225
	[ExclusiveTo(typeof(CanvasAnimatedUpdateEventArgs))]
	[Guid(1987004519U, 45610, 17995, 137, 177, 13, 166, 171, 98, 190, 104)]
	[Version(167772160U)]
	internal interface ICanvasAnimatedUpdateEventArgsFactory
	{
		// Token: 0x06000741 RID: 1857
		CanvasAnimatedUpdateEventArgs Create([In] CanvasTimingInformation timingInformation);
	}
}
