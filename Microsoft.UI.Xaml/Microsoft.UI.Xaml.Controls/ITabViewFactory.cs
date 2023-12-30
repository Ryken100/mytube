using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(TabView))]
	[Windows.Foundation.Metadata.Guid(3890755205u, 61151, 20742, 148, 41, 136, 68, 53, 171, 22, 107)]
	[WebHostHidden]
	internal interface ITabViewFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TabView CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
