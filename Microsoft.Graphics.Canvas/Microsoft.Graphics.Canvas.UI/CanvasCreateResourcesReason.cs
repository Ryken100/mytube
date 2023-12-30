using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasCreateResourcesReason
	{
		FirstTime,
		NewDevice,
		DpiChanged
	}
}
