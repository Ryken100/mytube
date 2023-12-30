using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F6 RID: 246
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ParallaxView))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[Guid(1641846589U, 50581, 21089, 169, 183, 53, 244, 16, 66, 235, 0)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IParallaxViewFactory
	{
		// Token: 0x060003C5 RID: 965
		ParallaxView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
