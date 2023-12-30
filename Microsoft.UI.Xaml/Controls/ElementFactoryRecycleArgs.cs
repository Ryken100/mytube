using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200006D RID: 109
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class ElementFactoryRecycleArgs : IElementFactoryRecycleArgs
	{
		// Token: 0x06000113 RID: 275
		public extern ElementFactoryRecycleArgs();

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000114 RID: 276
		// (set) Token: 0x06000115 RID: 277
		public extern UIElement Element
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000116 RID: 278
		// (set) Token: 0x06000117 RID: 279
		public extern UIElement Parent
		{
			get; [param: In]
			set;
		}
	}
}
