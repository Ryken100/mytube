using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(ComboBoxHelper))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1505028909u, 48505, 22962, 179, 67, 250, 114, 199, 71, 215, 42)]
	internal interface IComboBoxHelperStatics
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetKeepInteriorCornersSquare([In] ComboBox comboBox, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetKeepInteriorCornersSquare([In] ComboBox comboBox);
	}
}
