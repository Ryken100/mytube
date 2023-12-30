using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000138 RID: 312
	[ExclusiveTo(typeof(SwipeItems))]
	[Guid(2589818231U, 14781, 23425, 171, 78, 244, 74, 202, 110, 222, 63)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeItemsFactory
	{
		// Token: 0x06000508 RID: 1288
		SwipeItems CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
