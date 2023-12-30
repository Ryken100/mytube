using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Activatable(167772160u)]
	public sealed class CanvasTypography : ICanvasTypography, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddFeature")]
		public extern void AddFeature([In] CanvasTypographyFeature feature);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddFeatureWithNameAndParameter")]
		public extern void AddFeature([In] CanvasTypographyFeatureName name, [In] uint parameter);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasTypographyFeature[] GetFeatures();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
