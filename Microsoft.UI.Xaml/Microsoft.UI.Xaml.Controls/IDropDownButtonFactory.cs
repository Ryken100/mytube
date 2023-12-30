using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(DropDownButton))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(2096357691u, 26253, 22503, 181, 214, 245, 202, 61, 188, 128, 189)]
	internal interface IDropDownButtonFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		DropDownButton CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
