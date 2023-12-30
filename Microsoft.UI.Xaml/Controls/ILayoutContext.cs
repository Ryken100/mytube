using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C0 RID: 192
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3025808981U, 11980, 21602, 187, 38, 212, 124, 69, 91, 180, 142)]
	[ExclusiveTo(typeof(LayoutContext))]
	[WebHostHidden]
	internal interface ILayoutContext
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000290 RID: 656
		// (set) Token: 0x06000291 RID: 657
		object LayoutState
		{
			get; [param: In]
			set;
		}
	}
}
