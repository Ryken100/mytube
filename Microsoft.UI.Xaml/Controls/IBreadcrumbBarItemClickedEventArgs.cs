using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008A RID: 138
	[WebHostHidden]
	[Guid(485401859U, 13918, 22541, 188, 212, 233, 173, 2, 72, 246, 181)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(BreadcrumbBarItemClickedEventArgs))]
	internal interface IBreadcrumbBarItemClickedEventArgs
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000191 RID: 401
		int Index { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000192 RID: 402
		object Item { get; }
	}
}
