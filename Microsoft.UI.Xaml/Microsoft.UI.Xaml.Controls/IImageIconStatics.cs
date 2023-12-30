using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ImageIcon))]
	[Windows.Foundation.Metadata.Guid(175425134u, 61879, 21076, 145, 53, 38, 39, 238, 197, 21, 108)]
	[WebHostHidden]
	internal interface IImageIconStatics
	{
		DependencyProperty SourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
