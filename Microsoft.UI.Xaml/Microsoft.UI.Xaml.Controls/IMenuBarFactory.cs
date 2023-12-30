using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1990887257u, 1262, 23116, 185, 140, 208, 55, 66, 212, 124, 219)]
	[WebHostHidden]
	[ExclusiveTo(typeof(MenuBar))]
	internal interface IMenuBarFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		MenuBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
