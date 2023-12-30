using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001BB RID: 443
	[MarshalingBehavior(2)]
	[Static(typeof(IComboBoxHelperStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Threading(3)]
	[WebHostHidden]
	public sealed class ComboBoxHelper : IComboBoxHelper
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060008DE RID: 2270
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		public static extern DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		// Token: 0x060008DF RID: 2271
		public static extern void SetKeepInteriorCornersSquare([In] ComboBox comboBox, [In] bool value);

		// Token: 0x060008E0 RID: 2272
		public static extern bool GetKeepInteriorCornersSquare([In] ComboBox comboBox);
	}
}
