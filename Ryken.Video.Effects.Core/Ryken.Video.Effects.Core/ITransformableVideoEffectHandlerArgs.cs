using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(271808751u, 57099, 20790, 76, 31, 17, 170, 28, 213, 90, 81)]
	[Version(16777216u)]
	public interface ITransformableVideoEffectHandlerArgs
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetTransform([In] Matrix3x2 transform, [In] Vector2 outputSize);
	}
}
