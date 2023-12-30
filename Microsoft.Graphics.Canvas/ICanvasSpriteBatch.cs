using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000AC RID: 172
	[Version(167772160U)]
	[Guid(2691030244U, 42994, 19956, 132, 5, 234, 158, 58, 33, 91, 248)]
	[ExclusiveTo(typeof(CanvasSpriteBatch))]
	internal interface ICanvasSpriteBatch : IClosable, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator
	{
		// Token: 0x060004EF RID: 1263
		[Overload("DrawToRect")]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect);

		// Token: 0x060004F0 RID: 1264
		[Overload("DrawAtOffset")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset);

		// Token: 0x060004F1 RID: 1265
		[Overload("DrawWithTransform")]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform);

		// Token: 0x060004F2 RID: 1266
		[Overload("DrawToRectWithTint")]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint);

		// Token: 0x060004F3 RID: 1267
		[Overload("DrawAtOffsetWithTint")]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint);

		// Token: 0x060004F4 RID: 1268
		[Overload("DrawWithTransformAndTint")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint);

		// Token: 0x060004F5 RID: 1269
		[Overload("DrawToRectWithTintAndFlip")]
		[DefaultOverload]
		void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x060004F6 RID: 1270
		[Overload("DrawWithTransformAndTintAndFlip")]
		void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x060004F7 RID: 1271
		[Overload("DrawAtOffsetWithTintAndTransform")]
		void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		// Token: 0x060004F8 RID: 1272
		[Overload("DrawFromSpriteSheetToRect")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect);

		// Token: 0x060004F9 RID: 1273
		[Overload("DrawFromSpriteSheetAtOffset")]
		[DefaultOverload]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect);

		// Token: 0x060004FA RID: 1274
		[Overload("DrawFromSpriteSheetWithTransform")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect);

		// Token: 0x060004FB RID: 1275
		[Overload("DrawFromSpriteSheetToRectWithTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x060004FC RID: 1276
		[Overload("DrawFromSpriteSheetAtOffsetWithTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x060004FD RID: 1277
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetWithTransformAndTint")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x060004FE RID: 1278
		[Overload("DrawFromSpriteSheetToRectWithTintAndFlip")]
		[DefaultOverload]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x060004FF RID: 1279
		[Overload("DrawFromSpriteSheetWithTransformAndTintAndFlip")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x06000500 RID: 1280
		[Overload("DrawFromSpriteSheetAtOffsetWithTintAndTransform")]
		void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);
	}
}
