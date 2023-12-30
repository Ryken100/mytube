using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200013A RID: 314
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[WebHostHidden]
	[Guid(528521428U, 62442, 21344, 176, 170, 128, 101, 187, 114, 38, 174)]
	[ExclusiveTo(typeof(SymbolIconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface ISymbolIconSource
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600050A RID: 1290
		// (set) Token: 0x0600050B RID: 1291
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		Symbol Symbol
		{
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[param: In]
			set;
		}
	}
}
