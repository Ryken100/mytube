using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public enum CornerRadiusFilterKind
	{
		None,
		Top,
		Right,
		Bottom,
		Left,
		TopLeftValue,
		BottomRightValue
	}
}
