using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasLock))]
	[Windows.Foundation.Metadata.Guid(2047771800u, 64425, 20400, 170, 140, 106, 72, 181, 238, 62, 79)]
	[Version(167772160u)]
	internal interface ICanvasLock
	{
	}
}
