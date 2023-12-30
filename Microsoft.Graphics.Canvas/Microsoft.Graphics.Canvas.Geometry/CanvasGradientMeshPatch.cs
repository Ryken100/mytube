using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Geometry
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasGradientMeshPatch
	{
		public Vector2 Point00;

		public Vector2 Point01;

		public Vector2 Point02;

		public Vector2 Point03;

		public Vector2 Point10;

		public Vector2 Point11;

		public Vector2 Point12;

		public Vector2 Point13;

		public Vector2 Point20;

		public Vector2 Point21;

		public Vector2 Point22;

		public Vector2 Point23;

		public Vector2 Point30;

		public Vector2 Point31;

		public Vector2 Point32;

		public Vector2 Point33;

		public Vector4 Color00;

		public Vector4 Color03;

		public Vector4 Color30;

		public Vector4 Color33;

		public CanvasGradientMeshPatchEdge Edge00To03;

		public CanvasGradientMeshPatchEdge Edge03To33;

		public CanvasGradientMeshPatchEdge Edge33To30;

		public CanvasGradientMeshPatchEdge Edge30To00;
	}
}
