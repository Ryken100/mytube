using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000134 RID: 308
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(SwipeItem))]
	[Guid(18158561U, 6876, 23145, 167, 79, 98, 63, 204, 24, 165, 28)]
	internal interface ISwipeItemFactory
	{
		// Token: 0x060004FD RID: 1277
		SwipeItem CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
