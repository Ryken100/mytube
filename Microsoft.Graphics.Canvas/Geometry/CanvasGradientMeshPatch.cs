using System;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Microsoft.Graphics.Canvas.Geometry
{
	// Token: 0x02000077 RID: 119
	[Version(167772160U)]
	public struct CanvasGradientMeshPatch
	{
		// Token: 0x0400015F RID: 351
		public Vector2 Point00;

		// Token: 0x04000160 RID: 352
		public Vector2 Point01;

		// Token: 0x04000161 RID: 353
		public Vector2 Point02;

		// Token: 0x04000162 RID: 354
		public Vector2 Point03;

		// Token: 0x04000163 RID: 355
		public Vector2 Point10;

		// Token: 0x04000164 RID: 356
		public Vector2 Point11;

		// Token: 0x04000165 RID: 357
		public Vector2 Point12;

		// Token: 0x04000166 RID: 358
		public Vector2 Point13;

		// Token: 0x04000167 RID: 359
		public Vector2 Point20;

		// Token: 0x04000168 RID: 360
		public Vector2 Point21;

		// Token: 0x04000169 RID: 361
		public Vector2 Point22;

		// Token: 0x0400016A RID: 362
		public Vector2 Point23;

		// Token: 0x0400016B RID: 363
		public Vector2 Point30;

		// Token: 0x0400016C RID: 364
		public Vector2 Point31;

		// Token: 0x0400016D RID: 365
		public Vector2 Point32;

		// Token: 0x0400016E RID: 366
		public Vector2 Point33;

		// Token: 0x0400016F RID: 367
		public Vector4 Color00;

		// Token: 0x04000170 RID: 368
		public Vector4 Color03;

		// Token: 0x04000171 RID: 369
		public Vector4 Color30;

		// Token: 0x04000172 RID: 370
		public Vector4 Color33;

		// Token: 0x04000173 RID: 371
		public CanvasGradientMeshPatchEdge Edge00To03;

		// Token: 0x04000174 RID: 372
		public CanvasGradientMeshPatchEdge Edge03To33;

		// Token: 0x04000175 RID: 373
		public CanvasGradientMeshPatchEdge Edge33To30;

		// Token: 0x04000176 RID: 374
		public CanvasGradientMeshPatchEdge Edge30To00;
	}
}
