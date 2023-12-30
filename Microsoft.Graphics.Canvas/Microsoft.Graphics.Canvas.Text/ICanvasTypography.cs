using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(4049322770u, 17535, 17645, 139, 236, 126, 64, 244, 164, 223, 200)]
	[Version(167772160u)]
	[ExclusiveTo(typeof(CanvasTypography))]
	internal interface ICanvasTypography : IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddFeature")]
		void AddFeature([In] CanvasTypographyFeature feature);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddFeatureWithNameAndParameter")]
		void AddFeature([In] CanvasTypographyFeatureName name, [In] uint parameter);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasTypographyFeature[] GetFeatures();
	}
}
