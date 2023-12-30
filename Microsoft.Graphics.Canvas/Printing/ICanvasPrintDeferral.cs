using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000DF RID: 223
	[ExclusiveTo(typeof(CanvasPrintDeferral))]
	[Guid(147495330U, 22529, 20132, 134, 135, 137, 108, 189, 166, 154, 71)]
	[Version(167772160U)]
	internal interface ICanvasPrintDeferral
	{
		// Token: 0x06000740 RID: 1856
		void Complete();
	}
}
