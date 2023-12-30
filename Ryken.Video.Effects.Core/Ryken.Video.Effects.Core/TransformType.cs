using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Flags]
	[Version(16777216u)]
	public enum TransformType : uint
	{
		None = 0u,
		ScaleWidthToTarget = 1u,
		ScaleHeightToTarget = 2u,
		ScaleWidthHeightToTarget = 3u
	}
}
