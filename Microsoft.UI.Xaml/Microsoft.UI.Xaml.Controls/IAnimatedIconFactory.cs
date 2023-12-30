using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(AnimatedIcon))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(861331665u, 55343, 24513, 129, 101, 155, 157, 27, 157, 149, 20)]
	internal interface IAnimatedIconFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		AnimatedIcon CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
