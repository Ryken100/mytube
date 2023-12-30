using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x02000034 RID: 52
	[ExclusiveTo(typeof(CanvasSolidColorBrush))]
	[Version(167772160U)]
	[Guid(2344816519U, 47829, 18545, 136, 184, 159, 227, 198, 61, 32, 74)]
	internal interface ICanvasSolidColorBrush : ICanvasBrush, IClosable
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000057 RID: 87
		// (set) Token: 0x06000058 RID: 88
		Color Color
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000059 RID: 89
		// (set) Token: 0x0600005A RID: 90
		Vector4 ColorHdr
		{
			get; [param: In]
			set;
		}
	}
}
