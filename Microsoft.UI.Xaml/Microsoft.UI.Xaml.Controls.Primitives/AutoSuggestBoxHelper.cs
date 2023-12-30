using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[Static(typeof(IAutoSuggestBoxHelperStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	public sealed class AutoSuggestBoxHelper : IAutoSuggestBoxHelper
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		[MUXPropertyDefaultValue(value = "false")]
		public static extern DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "false")]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool GetKeepInteriorCornersSquare([In] AutoSuggestBox autoSuggestBox);
	}
}
