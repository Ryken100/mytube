using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	public enum RefreshVisualizerOrientation
	{
		Auto,
		Normal,
		Rotate90DegreesCounterclockwise,
		Rotate270DegreesCounterclockwise
	}
}
