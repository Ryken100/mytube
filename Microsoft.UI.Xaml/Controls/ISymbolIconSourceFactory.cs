using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013B RID: 315
	[WebHostHidden]
	[Guid(2948552186U, 65401, 21802, 163, 161, 72, 226, 239, 23, 21, 42)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(SymbolIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISymbolIconSourceFactory
	{
		// Token: 0x0600050C RID: 1292
		SymbolIconSource CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
