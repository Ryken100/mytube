using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001B7 RID: 439
	[Static(typeof(IAutoSuggestBoxHelperStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	public sealed class AutoSuggestBoxHelper : IAutoSuggestBoxHelper
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060008AC RID: 2220
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		public static extern DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			get;
		}

		// Token: 0x060008AD RID: 2221
		public static extern void SetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox, [In] bool value);

		// Token: 0x060008AE RID: 2222
		public static extern bool GetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox);
	}
}
