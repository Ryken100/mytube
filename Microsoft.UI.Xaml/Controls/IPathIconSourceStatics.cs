using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FA RID: 250
	[ExclusiveTo(typeof(PathIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(480365042U, 11923, 22647, 182, 64, 131, 97, 66, 194, 250, 192)]
	internal interface IPathIconSourceStatics
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060003D7 RID: 983
		DependencyProperty DataProperty { get; }
	}
}
