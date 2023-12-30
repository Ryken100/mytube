using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public enum UniformGridLayoutItemsJustification
	{
		Start,
		Center,
		End,
		SpaceAround,
		SpaceBetween,
		SpaceEvenly
	}
}
