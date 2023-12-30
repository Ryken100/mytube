using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.UI.Xaml
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3688680342u, 5246, 19074, 175, 58, 201, 28, 120, 0, 218, 167)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasSwapChainPanel))]
	internal interface ICanvasSwapChainPanel
	{
		CanvasSwapChain SwapChain
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveFromVisualTree();
	}
}
