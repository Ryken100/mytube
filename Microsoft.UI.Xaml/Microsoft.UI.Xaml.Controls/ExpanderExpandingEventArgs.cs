using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class ExpanderExpandingEventArgs : IExpanderExpandingEventArgs
	{
	}
}
