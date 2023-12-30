using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[ExclusiveTo(typeof(RevealBackgroundBrush))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2121214730u, 59149, 21151, 128, 151, 67, 224, 35, 242, 148, 59)]
	internal interface IRevealBackgroundBrushFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RevealBackgroundBrush CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
