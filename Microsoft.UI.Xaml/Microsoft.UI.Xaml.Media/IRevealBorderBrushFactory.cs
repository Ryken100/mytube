using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(RevealBorderBrush))]
	[Windows.Foundation.Metadata.Guid(3329736130u, 61509, 21292, 187, 19, 60, 238, 225, 145, 67, 178)]
	[WebHostHidden]
	internal interface IRevealBorderBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RevealBorderBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
