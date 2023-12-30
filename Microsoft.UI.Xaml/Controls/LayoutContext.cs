using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000191 RID: 401
	[MarshalingBehavior(2)]
	[WebHostHidden]
	[Threading(3)]
	[Composable(typeof(ILayoutContextFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class LayoutContext : DependencyObject, ILayoutContext, ILayoutContextOverrides
	{
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000720 RID: 1824
		// (set) Token: 0x06000721 RID: 1825
		public extern object LayoutState
		{
			get; [param: In]
			set;
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000722 RID: 1826
		// (set) Token: 0x06000723 RID: 1827
		protected virtual extern object LayoutStateCore
		{
			get; [param: In]
			set;
		}
	}
}
