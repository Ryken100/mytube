using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(533732186u, 29099, 23866, 147, 231, 20, 27, 253, 110, 223, 106)]
	[ExclusiveTo(typeof(AutoSuggestBoxHelper))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IAutoSuggestBoxHelperStatics
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox);
	}
}
