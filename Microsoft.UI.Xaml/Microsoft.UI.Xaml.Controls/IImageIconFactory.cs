using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ImageIcon))]
	[Windows.Foundation.Metadata.Guid(593363577u, 42960, 24538, 163, 8, 155, 124, 185, 196, 201, 18)]
	[WebHostHidden]
	internal interface IImageIconFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ImageIcon CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
