using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200014D RID: 333
	[Guid(2750207101U, 10610, 23833, 166, 46, 221, 251, 197, 225, 173, 87)]
	[ExclusiveTo(typeof(TeachingTip))]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ITeachingTipFactory
	{
		// Token: 0x060005AF RID: 1455
		TeachingTip CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
