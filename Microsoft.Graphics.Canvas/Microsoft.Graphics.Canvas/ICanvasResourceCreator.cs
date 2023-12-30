using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2406320808u, 18735, 19398, 179, 208, 231, 245, 234, 232, 75, 17)]
	[Version(167772160u)]
	public interface ICanvasResourceCreator
	{
		CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
