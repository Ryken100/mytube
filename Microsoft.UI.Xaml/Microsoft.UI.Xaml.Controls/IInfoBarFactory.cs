using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1617005152u, 39911, 24053, 190, 13, 147, 61, 52, 221, 180, 76)]
	[WebHostHidden]
	[ExclusiveTo(typeof(InfoBar))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IInfoBarFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		InfoBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
