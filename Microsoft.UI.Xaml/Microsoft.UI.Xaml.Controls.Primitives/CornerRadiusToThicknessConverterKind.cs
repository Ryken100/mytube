using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public enum CornerRadiusToThicknessConverterKind
	{
		FilterTopAndBottomFromLeft,
		FilterTopAndBottomFromRight,
		FilterLeftAndRightFromTop,
		FilterLeftAndRightFromBottom,
		FilterTopFromTopLeft,
		FilterTopFromTopRight,
		FilterRightFromTopRight,
		FilterRightFromBottomRight,
		FilterBottomFromBottomRight,
		FilterBottomFromBottomLeft,
		FilterLeftFromBottomLeft,
		FilterLeftFromTopLeft
	}
}
