using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	// Token: 0x020000F2 RID: 242
	[Guid(3688680342U, 5246, 19074, 175, 58, 201, 28, 120, 0, 218, 167)]
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasSwapChainPanel))]
	internal interface ICanvasSwapChainPanel
	{
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060007CA RID: 1994
		// (set) Token: 0x060007C9 RID: 1993
		CanvasSwapChain SwapChain
		{
			get; [param: In]
			set;
		}

		// Token: 0x060007CB RID: 1995
		void RemoveFromVisualTree();
	}
}
