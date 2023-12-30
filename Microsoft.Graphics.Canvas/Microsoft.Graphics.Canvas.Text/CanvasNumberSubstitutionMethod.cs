using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasNumberSubstitutionMethod
	{
		FromCulture,
		Contextual,
		Disabled,
		National,
		Traditional
	}
}