using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Microsoft.Graphics.Canvas.Printing
{
	// Token: 0x020000D8 RID: 216
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasPrintTaskOptionsChangedEventArgs : ICanvasPrintTaskOptionsChangedEventArgs
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000723 RID: 1827
		public extern uint CurrentPreviewPageNumber { get; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000725 RID: 1829
		// (set) Token: 0x06000724 RID: 1828
		public extern uint NewPreviewPageNumber
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000726 RID: 1830
		public extern CanvasPrintDeferral GetDeferral();

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000727 RID: 1831
		public extern PrintTaskOptions PrintTaskOptions { get; }
	}
}
