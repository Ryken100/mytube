using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Brushes
{
	// Token: 0x0200003B RID: 59
	[Version(167772160U)]
	[Static(typeof(ICanvasLinearGradientBrushStatics), 167772160U)]
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Activatable(typeof(ICanvasLinearGradientBrushFactory), 167772160U)]
	public sealed class CanvasLinearGradientBrush : ICanvasLinearGradientBrush, ICanvasBrush, IClosable
	{
		// Token: 0x0600007D RID: 125
		public extern CanvasLinearGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] Color startColor, [In] Color endColor);

		// Token: 0x0600007E RID: 126
		public extern CanvasLinearGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops);

		// Token: 0x0600007F RID: 127
		public extern CanvasLinearGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x06000080 RID: 128
		public extern CanvasLinearGradientBrush([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStop[] gradientStops, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000081 RID: 129
		// (set) Token: 0x06000082 RID: 130
		public extern Vector2 StartPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000083 RID: 131
		// (set) Token: 0x06000084 RID: 132
		public extern Vector2 EndPoint
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000085 RID: 133
		public extern CanvasGradientStop[] Stops { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000086 RID: 134
		public extern CanvasGradientStopHdr[] StopsHdr { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000087 RID: 135
		public extern CanvasEdgeBehavior EdgeBehavior { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000088 RID: 136
		public extern CanvasColorSpace PreInterpolationSpace { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000089 RID: 137
		public extern CanvasColorSpace PostInterpolationSpace { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008A RID: 138
		public extern CanvasBufferPrecision BufferPrecision { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008B RID: 139
		public extern CanvasAlphaMode AlphaMode { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008C RID: 140
		// (set) Token: 0x0600008D RID: 141
		public extern float Opacity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008E RID: 142
		// (set) Token: 0x0600008F RID: 143
		public extern Matrix3x2 Transform
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000090 RID: 144
		public extern CanvasDevice Device { get; }

		// Token: 0x06000091 RID: 145
		public extern void Close();

		// Token: 0x06000092 RID: 146
		[Overload("CreateHdrSimple")]
		public static extern CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] Vector4 startColorHdr, [In] Vector4 endColorHdr);

		// Token: 0x06000093 RID: 147
		[Overload("CreateHdrWithStops")]
		public static extern CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr);

		// Token: 0x06000094 RID: 148
		[Overload("CreateHdrWithEdgeBehaviorAndAlphaMode")]
		public static extern CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode);

		// Token: 0x06000095 RID: 149
		[Overload("CreateHdrWithEdgeBehaviorAndInterpolationOptions")]
		public static extern CanvasLinearGradientBrush CreateHdr([In] ICanvasResourceCreator resourceCreator, [In] CanvasGradientStopHdr[] gradientStopsHdr, [In] CanvasEdgeBehavior edgeBehavior, [In] CanvasAlphaMode alphaMode, [In] CanvasColorSpace preInterpolationSpace, [In] CanvasColorSpace postInterpolationSpace, [In] CanvasBufferPrecision bufferPrecision);

		// Token: 0x06000096 RID: 150
		public static extern CanvasLinearGradientBrush CreateRainbow([In] ICanvasResourceCreator resourceCreator, [In] float eldritchness);
	}
}
