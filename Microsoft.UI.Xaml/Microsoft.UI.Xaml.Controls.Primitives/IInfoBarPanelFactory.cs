using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ExclusiveTo(typeof(InfoBarPanel))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(13740229u, 63025, 22090, 142, 156, 124, 92, 202, 210, 56, 222)]
	[WebHostHidden]
	internal interface IInfoBarPanelFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		InfoBarPanel CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
