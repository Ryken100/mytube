using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[Version(167772160u)]
	public struct ColorManagementSimpleProfile
	{
		public Vector2 RedPrimary;

		public Vector2 GreenPrimary;

		public Vector2 BluePrimary;

		public Vector2 WhitePointXZ;

		public ColorManagementGamma Gamma;
	}
}
