using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasActiveLayer))]
	[Windows.Foundation.Metadata.Guid(1240267864u, 24092, 20195, 128, 136, 84, 47, 148, 233, 60, 96)]
	internal interface ICanvasActiveLayer : IDisposable
	{
	}
}
