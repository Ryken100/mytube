using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasTriangleVertices
	{
		public Vector2 Vertex1;

		public Vector2 Vertex2;

		public Vector2 Vertex3;
	}
}
