using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(796633080u, 44991, 22435, 111, 66, 206, 189, 230, 252, 62, 66)]
	[Version(16777216u)]
	public interface IVideoEffectHandler
	{
		bool IsEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CreateResources();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DestroyResources();
	}
}
