using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Media
{
	[ComImport]
	[Composable(typeof(IRevealBorderBrushFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	public class RevealBorderBrush : RevealBrush, IRevealBorderBrush
	{
	}
}
