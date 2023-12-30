using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Version(167772160u)]
	[Activatable(typeof(ICanvasNumberSubstitutionFactory), 167772160u)]
	public sealed class CanvasNumberSubstitution : ICanvasNumberSubstitution, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
