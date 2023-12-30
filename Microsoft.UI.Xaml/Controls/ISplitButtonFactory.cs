using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200012B RID: 299
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(SplitButton))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(122749074U, 9746, 21991, 152, 28, 165, 54, 221, 212, 87, 14)]
	internal interface ISplitButtonFactory
	{
		// Token: 0x060004D4 RID: 1236
		SplitButton CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
