using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001D9 RID: 473
	[ExclusiveTo(typeof(InfoBarPanel))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(13740229U, 63025, 22090, 142, 156, 124, 92, 202, 210, 56, 222)]
	[WebHostHidden]
	internal interface IInfoBarPanelFactory
	{
		// Token: 0x0600096A RID: 2410
		InfoBarPanel CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
