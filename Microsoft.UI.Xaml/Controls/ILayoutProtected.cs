using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000C4 RID: 196
	[ExclusiveTo(typeof(Layout))]
	[Guid(3832542230U, 29726, 20854, 161, 212, 87, 24, 210, 52, 34, 67)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	internal interface ILayoutProtected
	{
		// Token: 0x06000294 RID: 660
		void InvalidateMeasure();

		// Token: 0x06000295 RID: 661
		void InvalidateArrange();
	}
}
