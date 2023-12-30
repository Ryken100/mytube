using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	[ComImport]
	[ExclusiveTo(typeof(CrossFadeEffect))]
	[Windows.Foundation.Metadata.Guid(2746643248u, 25220, 24310, 153, 232, 180, 176, 93, 43, 139, 252)]
	[Version(167772160u)]
	internal interface ICrossFadeEffectStatics
	{
		bool IsSupported
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
