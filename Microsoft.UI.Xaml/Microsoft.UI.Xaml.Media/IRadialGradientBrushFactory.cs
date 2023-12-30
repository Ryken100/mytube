using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(RadialGradientBrush))]
	[Windows.Foundation.Metadata.Guid(3641418350u, 40551, 21693, 162, 217, 97, 200, 249, 241, 212, 51)]
	internal interface IRadialGradientBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RadialGradientBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
