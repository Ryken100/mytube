using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A0 RID: 160
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[ExclusiveTo(typeof(FontIconSource))]
	[Guid(3141594862U, 25809, 20787, 177, 214, 174, 19, 194, 27, 102, 120)]
	internal interface IFontIconSourceFactory
	{
		// Token: 0x06000209 RID: 521
		FontIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
