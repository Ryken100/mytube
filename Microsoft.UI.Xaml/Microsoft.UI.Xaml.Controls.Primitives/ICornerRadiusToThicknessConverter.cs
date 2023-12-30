using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CornerRadiusToThicknessConverter))]
	[Windows.Foundation.Metadata.Guid(3010111662u, 5742, 23717, 147, 210, 149, 233, 144, 124, 18, 34)]
	internal interface ICornerRadiusToThicknessConverter
	{
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
		CornerRadiusToThicknessConverterKind ConversionKind
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusToThicknessConverterKind::FilterLeftAndRightFromTop")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "1.0f")]
		[MUXPropertyDefaultValue(value = "1.0f")]
		double Multiplier
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0f")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0f")]
			[param: In]
			set;
		}
	}
}
