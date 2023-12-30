using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000176 RID: 374
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(228513800U, 62457, 20532, 150, 39, 21, 43, 145, 233, 27, 75)]
	[ExclusiveTo(typeof(UniformGridLayout))]
	[WebHostHidden]
	internal interface IUniformGridLayoutFactory
	{
		// Token: 0x0600067D RID: 1661
		UniformGridLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
