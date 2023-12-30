using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2866573277u, 60160, 24152, 185, 93, 18, 15, 137, 29, 115, 63)]
	[ExclusiveTo(typeof(ItemsSourceView))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IItemsSourceViewFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ItemsSourceView CreateInstance([In] object source, [In] object baseInterface, out object innerInterface);
	}
}
