using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000002 RID: 2
	[Guid(271808751U, 57099, 20790, 76, 31, 17, 170, 28, 213, 90, 81)]
	[Version(16777216U)]
	public interface ITransformableVideoEffectHandlerArgs
	{
		// Token: 0x06000001 RID: 1
		void SetTransform([In] Matrix3x2 transform, [In] Vector2 outputSize);
	}
}
