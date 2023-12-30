using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003F RID: 63
	[Version(167772160U)]
	[Static(typeof(ICanvasRadialGradientBrushStatics), 167772160U)]
	[Activatable(typeof(ICanvasRadialGradientBrushFactory), 167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	public sealed class CanvasRadialGradientBrush : ICanvasRadialGradientBrush, ICanvasBrush, IClosable
	{
		// Token: 0x060000AB RID: 171
		public extern CanvasRadialGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		// Token: 0x060000AC RID: 172
		public extern CanvasRadialGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		// Token: 0x060000AD RID: 173
		public extern CanvasRadialGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060000AE RID: 174
		public extern CanvasRadialGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000AF RID: 175
		// (set) Token: 0x060000B0 RID: 176
		public extern Vector2 Center
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B1 RID: 177
		// (set) Token: 0x060000B2 RID: 178
		public extern Vector2 OriginOffset
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B3 RID: 179
		// (set) Token: 0x060000B4 RID: 180
		public extern float RadiusX
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B5 RID: 181
		// (set) Token: 0x060000B6 RID: 182
		public extern float RadiusY
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B7 RID: 183
		public extern CanvasGradientStop[] Stops { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B8 RID: 184
		public extern CanvasGradientStopHdr[] StopsHdr { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B9 RID: 185
		public extern CanvasEdgeBehavior EdgeBehavior { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BA RID: 186
		public extern CanvasColorSpace PreInterpolationSpace { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BB RID: 187
		public extern CanvasColorSpace PostInterpolationSpace { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BC RID: 188
		public extern CanvasBufferPrecision BufferPrecision { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BD RID: 189
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000BE RID: 190
		// (set) Token: 0x060000BF RID: 191
		public extern float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C0 RID: 192
		// (set) Token: 0x060000C1 RID: 193
		public extern Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C2 RID: 194
		public extern CanvasDevice Device { get; }

		// Token: 0x060000C3 RID: 195
		public extern void Close();

		// Token: 0x060000C4 RID: 196
		[Overload("CreateHdrSimple")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		// Token: 0x060000C5 RID: 197
		[Overload("CreateHdrWithStops")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops);

		// Token: 0x060000C6 RID: 198
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x060000C7 RID: 199
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		public static extern CanvasRadialGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x060000C8 RID: 200
		public static extern CanvasRadialGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
