using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DB RID: 219
	[ExclusiveTo(typeof(CanvasPrintTaskOptionsChangedEventArgs))]
	[Guid(4179659194U, 27801, 19628, 178, 138, 181, 220, 236, 122, 49, 13)]
	[Version(167772160U)]
	internal interface ICanvasPrintTaskOptionsChangedEventArgs
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000731 RID: 1841
		uint CurrentPreviewPageNumber { get; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000733 RID: 1843
		// (set) Token: 0x06000732 RID: 1842
		uint NewPreviewPageNumber
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000734 RID: 1844
		CanvasPrintDeferral GetDeferral();

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000735 RID: 1845
		PrintTaskOptions PrintTaskOptions { get; }
	}
}
