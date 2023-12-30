using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	// Token: 0x020001CF RID: 463
	[ExclusiveTo(typeof(ComboBoxHelper))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1505028909U, 48505, 22962, 179, 67, 250, 114, 199, 71, 215, 42)]
	internal interface IComboBoxHelperStatics
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600093E RID: 2366
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			get;
		}

		// Token: 0x0600093F RID: 2367
		void SetKeepInteriorCornersSquare([In] ComboBox comboBox, [In] bool value);

		// Token: 0x06000940 RID: 2368
		bool GetKeepInteriorCornersSquare([In] ComboBox comboBox);
	}
}
