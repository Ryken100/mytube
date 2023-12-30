using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013C RID: 316
	[Guid(2524718511U, 10900, 24144, 169, 33, 88, 125, 143, 232, 17, 67)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(SymbolIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ISymbolIconSourceStatics
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600050D RID: 1293
		DependencyProperty SymbolProperty { get; }
	}
}
