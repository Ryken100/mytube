using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F8 RID: 248
	[ExclusiveTo(typeof(CanvasRegionsInvalidatedEventArgs))]
	[Guid(975282692U, 62767, 20090, 155, 63, 148, 102, 152, 25, 217, 129)]
	[Version(167772160U)]
	internal interface ICanvasRegionsInvalidatedEventArgs
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060007FE RID: 2046
		Rect[] InvalidatedRegions { get; }

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060007FF RID: 2047
		Rect VisibleRegion { get; }
	}
}
