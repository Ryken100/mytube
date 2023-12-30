using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C2 RID: 194
	[Guid(4255583812U, 25894, 21813, 190, 43, 236, 39, 67, 103, 10, 226)]
	[WebHostHidden]
	[ExclusiveTo(typeof(LayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ILayoutContextOverrides
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000292 RID: 658
		// (set) Token: 0x06000293 RID: 659
		object LayoutStateCore
		{
			get; [param: In]
			set;
		}
	}
}
