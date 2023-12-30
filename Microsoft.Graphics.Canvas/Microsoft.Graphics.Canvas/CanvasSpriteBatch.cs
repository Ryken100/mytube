using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	[Static(typeof(ICanvasSpriteBatchStatics), 167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	public sealed class CanvasSpriteBatch : ICanvasSpriteBatch, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IDisposable
	{
		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern float Dpi
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRect")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawAtOffset")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransform")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRectWithTint")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawAtOffsetWithTint")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransformAndTint")]
		[DefaultOverload]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRectWithTintAndFlip")]
		[DefaultOverload]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransformAndTintAndFlip")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawAtOffsetWithTintAndTransform")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetToRect")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetAtOffset")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetWithTransform")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetToRectWithTint")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetAtOffsetWithTint")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetWithTransformAndTint")]
		[DefaultOverload]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetToRectWithTintAndFlip")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetWithTransformAndTintAndFlip")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetAtOffsetWithTintAndTransform")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float ConvertPixelsToDips([In] int pixels);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool IsSupported([In] CanvasDevice device);
	}
}
