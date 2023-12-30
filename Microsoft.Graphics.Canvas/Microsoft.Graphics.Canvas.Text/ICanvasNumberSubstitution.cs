using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasNumberSubstitution))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(3357173677u, 1593, 20367, 135, 139, 217, 55, 248, 161, 66, 147)]
	internal interface ICanvasNumberSubstitution : IDisposable
	{
	}
}
