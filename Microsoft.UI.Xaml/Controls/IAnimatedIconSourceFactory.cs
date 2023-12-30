using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000078 RID: 120
	[ExclusiveTo(typeof(AnimatedIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2928654302U, 32450, 23266, 180, 97, 190, 173, 87, 4, 32, 250)]
	internal interface IAnimatedIconSourceFactory
	{
		// Token: 0x06000152 RID: 338
		AnimatedIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
