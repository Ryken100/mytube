using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A3 RID: 163
	[Guid(3904641478U, 39524, 23636, 147, 56, 225, 142, 7, 104, 117, 191)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(IconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IIconSourceFactory
	{
	}
}
