using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000131 RID: 305
	[WebHostHidden]
	[ExclusiveTo(typeof(SwipeControl))]
	[Guid(1855067124U, 12481, 22218, 153, 5, 70, 170, 26, 131, 223, 193)]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeControlFactory
	{
		// Token: 0x060004E8 RID: 1256
		SwipeControl CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
