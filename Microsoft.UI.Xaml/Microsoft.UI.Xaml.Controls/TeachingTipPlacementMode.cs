using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	public enum TeachingTipPlacementMode
	{
		Auto,
		Top,
		Bottom,
		Left,
		Right,
		TopRight,
		TopLeft,
		BottomRight,
		BottomLeft,
		LeftTop,
		LeftBottom,
		RightTop,
		RightBottom,
		Center
	}
}
