using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(CornerRadiusToThicknessConverter))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3600373321u, 35538, 23608, 188, 69, 184, 239, 134, byte.MaxValue, 95, 105)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ICornerRadiusToThicknessConverterStatics
	{
		DependencyProperty ConversionKindProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty MultiplierProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
