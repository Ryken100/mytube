using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1863990994u, 63845, 21598, 189, 68, 68, 29, 177, 121, 79, 95)]
	[WebHostHidden]
	[ExclusiveTo(typeof(CornerRadiusFilterConverter))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ICornerRadiusFilterConverter
	{
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
		CornerRadiusFilterKind Filter
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::CornerRadiusFilterKind::None")]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "1.0")]
		[MUXPropertyDefaultValue(value = "1.0")]
		double Scale
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1.0")]
			[param: In]
			set;
		}
	}
}
