using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000076 RID: 118
	[ExclusiveTo(typeof(AnimatedIcon))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(861331665U, 55343, 24513, 129, 101, 155, 157, 27, 157, 149, 20)]
	internal interface IAnimatedIconFactory
	{
		// Token: 0x0600014B RID: 331
		AnimatedIcon CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
