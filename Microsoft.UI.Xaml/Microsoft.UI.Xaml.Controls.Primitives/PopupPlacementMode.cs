using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public enum PopupPlacementMode
	{
		Auto,
		Top,
		Bottom,
		Left,
		Right,
		TopEdgeAlignedLeft,
		TopEdgeAlignedRight,
		BottomEdgeAlignedLeft,
		BottomEdgeAlignedRight,
		LeftEdgeAlignedTop,
		LeftEdgeAlignedBottom,
		RightEdgeAlignedTop,
		RightEdgeAlignedBottom
	}
}
