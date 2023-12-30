using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001C4 RID: 452
	[Guid(533732186U, 29099, 23866, 147, 231, 20, 27, 253, 110, 223, 106)]
	[ExclusiveTo(typeof(AutoSuggestBoxHelper))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAutoSuggestBoxHelperStatics
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600090C RID: 2316
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		// Token: 0x0600090D RID: 2317
		void SetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox, [In] bool value);

		// Token: 0x0600090E RID: 2318
		bool GetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox);
	}
}
