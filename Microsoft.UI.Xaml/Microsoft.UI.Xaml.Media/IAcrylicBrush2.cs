using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(603641200u, 17389, 23155, 157, 231, 163, 3, 85, 61, 84, 20)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(AcrylicBrush))]
	[WebHostHidden]
	internal interface IAcrylicBrush2
	{
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
		double? TintLuminosityOpacity
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyValidationCallback(value = "CoerceToZeroOneRange_Nullable")]
			[param: In]
			set;
		}
	}
}
