using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F3 RID: 243
	[Activatable(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(167772160U)]
	public sealed class CanvasSwapChainPanel : SwapChainPanel, ICanvasSwapChainPanel
	{
		// Token: 0x060007CC RID: 1996
		public extern CanvasSwapChainPanel();

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060007CE RID: 1998
		// (set) Token: 0x060007CD RID: 1997
		public extern CanvasSwapChain SwapChain
		{
			get; [param: In]
			set;
		}

		// Token: 0x060007CF RID: 1999
		public extern void RemoveFromVisualTree();
	}
}
