using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013E RID: 318
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(TabView))]
	[Guid(3890755205U, 61151, 20742, 148, 41, 136, 68, 53, 171, 22, 107)]
	[WebHostHidden]
	internal interface ITabViewFactory
	{
		// Token: 0x06000545 RID: 1349
		TabView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
