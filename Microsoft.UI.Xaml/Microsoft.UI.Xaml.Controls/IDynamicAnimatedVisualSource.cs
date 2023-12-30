using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(2868962767u, 7142, 21916, 173, 91, 2, 83, 187, 23, 192, 247)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public interface IDynamicAnimatedVisualSource : IAnimatedVisualSource
	{
		event TypedEventHandler<IDynamicAnimatedVisualSource, object> AnimatedVisualInvalidated;
	}
}
