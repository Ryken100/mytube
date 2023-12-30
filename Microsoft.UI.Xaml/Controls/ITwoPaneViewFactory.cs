using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000173 RID: 371
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(253423821U, 62428, 21238, 182, 50, 57, 103, 66, 83, 50, 49)]
	[ExclusiveTo(typeof(TwoPaneView))]
	internal interface ITwoPaneViewFactory
	{
		// Token: 0x06000662 RID: 1634
		TwoPaneView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
