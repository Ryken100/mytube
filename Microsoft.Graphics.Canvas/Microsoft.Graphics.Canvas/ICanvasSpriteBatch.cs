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
	[Windows.Foundation.Metadata.Guid(2691030244u, 42994, 19956, 132, 5, 234, 158, 58, 33, 91, 248)]
	[ExclusiveTo(typeof(CanvasSpriteBatch))]
	internal interface ICanvasSpriteBatch : IDisposable, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRect")]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawAtOffset")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransform")]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRectWithTint")]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawAtOffsetWithTint")]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransformAndTint")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawToRectWithTintAndFlip")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawWithTransformAndTintAndFlip")]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawAtOffsetWithTintAndTransform")]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetToRect")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetAtOffset")]
		[DefaultOverload]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetWithTransform")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetToRectWithTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetAtOffsetWithTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetWithTransformAndTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetToRectWithTintAndFlip")]
		[DefaultOverload]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetWithTransformAndTintAndFlip")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("DrawFromSpriteSheetAtOffsetWithTintAndTransform")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);
	}
}
