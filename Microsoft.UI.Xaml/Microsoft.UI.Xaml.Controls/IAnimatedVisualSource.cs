using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1471113486u, 45873, 21602, 140, 198, 197, 41, 165, 218, 65, 35)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public interface IAnimatedVisualSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);
	}
}
