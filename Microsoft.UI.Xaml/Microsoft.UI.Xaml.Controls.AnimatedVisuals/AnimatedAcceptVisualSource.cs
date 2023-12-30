using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls.AnimatedVisuals
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	public sealed class AnimatedAcceptVisualSource : IAnimatedVisualSource, IAnimatedVisualSource2
	{
		public extern IReadOnlyDictionary<string, double> Markers
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetColorProperty([In] string propertyName, [In] Color value);
	}
}