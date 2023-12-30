using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas
{
	// Token: 0x020000AD RID: 173
	[Version(167772160U)]
	[Static(typeof(ICanvasSpriteBatchStatics), 167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasSpriteBatch : ICanvasSpriteBatch, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, IClosable
	{
		// Token: 0x06000501 RID: 1281
		[Overload("DrawToRect")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect);

		// Token: 0x06000502 RID: 1282
		[DefaultOverload]
		[Overload("DrawAtOffset")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset);

		// Token: 0x06000503 RID: 1283
		[Overload("DrawWithTransform")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform);

		// Token: 0x06000504 RID: 1284
		[Overload("DrawToRectWithTint")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint);

		// Token: 0x06000505 RID: 1285
		[Overload("DrawAtOffsetWithTint")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint);

		// Token: 0x06000506 RID: 1286
		[Overload("DrawWithTransformAndTint")]
		[DefaultOverload]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint);

		// Token: 0x06000507 RID: 1287
		[Overload("DrawToRectWithTintAndFlip")]
		[DefaultOverload]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x06000508 RID: 1288
		[Overload("DrawWithTransformAndTintAndFlip")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x06000509 RID: 1289
		[Overload("DrawAtOffsetWithTintAndTransform")]
		public extern void Draw([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		// Token: 0x0600050A RID: 1290
		[Overload("DrawFromSpriteSheetToRect")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect);

		// Token: 0x0600050B RID: 1291
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetAtOffset")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect);

		// Token: 0x0600050C RID: 1292
		[Overload("DrawFromSpriteSheetWithTransform")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect);

		// Token: 0x0600050D RID: 1293
		[Overload("DrawFromSpriteSheetToRectWithTint")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x0600050E RID: 1294
		[Overload("DrawFromSpriteSheetAtOffsetWithTint")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x0600050F RID: 1295
		[Overload("DrawFromSpriteSheetWithTransformAndTint")]
		[DefaultOverload]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint);

		// Token: 0x06000510 RID: 1296
		[DefaultOverload]
		[Overload("DrawFromSpriteSheetToRectWithTintAndFlip")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Rect destRect, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x06000511 RID: 1297
		[Overload("DrawFromSpriteSheetWithTransformAndTintAndFlip")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Matrix3x2 transform, [In] Rect sourceRect, [In] Vector4 tint, [In] CanvasSpriteFlip flip);

		// Token: 0x06000512 RID: 1298
		[Overload("DrawFromSpriteSheetAtOffsetWithTintAndTransform")]
		public extern void DrawFromSpriteSheet([In] CanvasBitmap bitmap, [In] Vector2 offset, [In] Rect sourceRect, [In] Vector4 tint, [In] Vector2 origin, [In] float rotation, [In] Vector2 scale, [In] CanvasSpriteFlip flip);

		// Token: 0x06000513 RID: 1299
		public extern void Close();

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000514 RID: 1300
		public extern float Dpi { get; }

		// Token: 0x06000515 RID: 1301
		public extern float ConvertPixelsToDips([In] int pixels);

		// Token: 0x06000516 RID: 1302
		public extern int ConvertDipsToPixels([In] float dips, [In] CanvasDpiRounding dpiRounding);

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000517 RID: 1303
		public extern CanvasDevice Device { get; }

		// Token: 0x06000518 RID: 1304
		public static extern bool IsSupported([In] CanvasDevice device);
	}
}
