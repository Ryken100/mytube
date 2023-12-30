using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(IComboBoxHelperStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	public sealed class ComboBoxHelper : IComboBoxHelper
	{
		[MUXPropertyDefaultValue(value = "false")]
		[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
		public static extern DependencyProperty KeepInteriorCornersSquareProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnKeepInteriorCornersSquarePropertyChanged")]
			[MUXPropertyDefaultValue(value = "false")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetKeepInteriorCornersSquare([In] ComboBox comboBox, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool GetKeepInteriorCornersSquare([In] ComboBox comboBox);
	}
}
