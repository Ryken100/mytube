using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000FC RID: 252
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(PersonPicture))]
	[Guid(2126543180U, 62156, 21122, 168, 157, 205, 59, 183, 101, 183, 26)]
	internal interface IPersonPictureFactory
	{
		// Token: 0x060003ED RID: 1005
		PersonPicture CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
