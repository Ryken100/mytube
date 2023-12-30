using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000209 RID: 521
	[WebHostHidden]
	[Composable(typeof(ISymbolIconSourceFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[Static(typeof(ISymbolIconSourceStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class SymbolIconSource : IconSource, ISymbolIconSource
	{
		// Token: 0x06000AA6 RID: 2726
		public extern SymbolIconSource();

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000AA7 RID: 2727
		// (set) Token: 0x06000AA8 RID: 2728
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
		public extern Symbol Symbol
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Symbol::Emoji")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000AA9 RID: 2729
		public static extern DependencyProperty SymbolProperty { get; }
	}
}
