using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasNumberSubstitution))]
	[Version(167772160u)]
	[Windows.Foundation.Metadata.Guid(1956030498u, 51073, 20144, 170, 251, 192, 120, 231, 250, 142, 36)]
	internal interface ICanvasNumberSubstitutionFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasNumberSubstitution Create([In] CanvasNumberSubstitutionMethod method);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasNumberSubstitution CreateWithLocaleAndIgnoreOverrides([In] CanvasNumberSubstitutionMethod method, [In] string localeName, [In] bool ignoreEnvironmentOverrides);
	}
}
