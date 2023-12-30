using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000B7 RID: 183
	[Threading(3)]
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	public sealed class CanvasSvgNamedElement : ICanvasSvgNamedElement, IClosable, ICanvasSvgElement
	{
		// Token: 0x06000531 RID: 1329
		public extern void AppendChild([In] ICanvasSvgElement child);

		// Token: 0x06000532 RID: 1330
		public extern CanvasSvgNamedElement CreateAndAppendNamedChildElement([In] string childName);

		// Token: 0x06000533 RID: 1331
		public extern CanvasSvgTextElement CreateAndAppendTextChildElement([In] string textContent);

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000534 RID: 1332
		public extern ICanvasSvgElement FirstChild { get; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000535 RID: 1333
		public extern ICanvasSvgElement LastChild { get; }

		// Token: 0x06000536 RID: 1334
		public extern ICanvasSvgElement GetPreviousSibling([In] ICanvasSvgElement child);

		// Token: 0x06000537 RID: 1335
		public extern ICanvasSvgElement GetNextSibling([In] ICanvasSvgElement child);

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000538 RID: 1336
		public extern string[] SpecifiedAttributes { get; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000539 RID: 1337
		public extern string Tag { get; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600053A RID: 1338
		public extern bool HasChildren { get; }

		// Token: 0x0600053B RID: 1339
		public extern void InsertChildBefore([In] ICanvasSvgElement child, [In] ICanvasSvgElement referenceChild);

		// Token: 0x0600053C RID: 1340
		[Overload("IsAttributeSpecified")]
		public extern bool IsAttributeSpecified([In] string attributeName);

		// Token: 0x0600053D RID: 1341
		[DefaultOverload]
		[Overload("IsAttributeSpecifiedWithInherhited")]
		public extern bool IsAttributeSpecified([In] string attributeName, [In] bool inherited);

		// Token: 0x0600053E RID: 1342
		public extern void RemoveAttribute([In] string attributeName);

		// Token: 0x0600053F RID: 1343
		public extern void RemoveChild([In] ICanvasSvgElement child);

		// Token: 0x06000540 RID: 1344
		public extern void ReplaceChild([In] ICanvasSvgElement newChild, [In] ICanvasSvgElement oldChild);

		// Token: 0x06000541 RID: 1345
		public extern void SetStringAttribute([In] string attributeName, [In] string attributeValue);

		// Token: 0x06000542 RID: 1346
		public extern string GetStringAttribute([In] string attributeName);

		// Token: 0x06000543 RID: 1347
		public extern void SetAttribute([In] string attributeName, [In] ICanvasSvgAttribute attributeValue);

		// Token: 0x06000544 RID: 1348
		public extern ICanvasSvgAttribute GetAttribute([In] string attributeName);

		// Token: 0x06000545 RID: 1349
		public extern void SetIdAttribute([In] string attributeName, [In] string attributeValue);

		// Token: 0x06000546 RID: 1350
		public extern string GetIdAttribute([In] string attributeName);

		// Token: 0x06000547 RID: 1351
		public extern void SetFloatAttribute([In] string attributeName, [In] float attributeValue);

		// Token: 0x06000548 RID: 1352
		public extern float GetFloatAttribute([In] string attributeName);

		// Token: 0x06000549 RID: 1353
		public extern void SetColorAttribute([In] string attributeName, [In] Color attributeValue);

		// Token: 0x0600054A RID: 1354
		public extern Color GetColorAttribute([In] string attributeName);

		// Token: 0x0600054B RID: 1355
		public extern void SetFilledRegionDeterminationAttribute([In] string attributeName, [In] CanvasFilledRegionDetermination attributeValue);

		// Token: 0x0600054C RID: 1356
		public extern CanvasFilledRegionDetermination GetFilledRegionDeterminationAttribute([In] string attributeName);

		// Token: 0x0600054D RID: 1357
		public extern void SetDisplayAttribute([In] string attributeName, [In] CanvasSvgDisplay attributeValue);

		// Token: 0x0600054E RID: 1358
		public extern CanvasSvgDisplay GetDisplayAttribute([In] string attributeName);

		// Token: 0x0600054F RID: 1359
		public extern void SetOverflowAttribute([In] string attributeName, [In] CanvasSvgOverflow attributeValue);

		// Token: 0x06000550 RID: 1360
		public extern CanvasSvgOverflow GetOverflowAttribute([In] string attributeName);

		// Token: 0x06000551 RID: 1361
		public extern void SetCapStyleAttribute([In] string attributeName, [In] CanvasCapStyle attributeValue);

		// Token: 0x06000552 RID: 1362
		public extern CanvasCapStyle GetCapStyleAttribute([In] string attributeName);

		// Token: 0x06000553 RID: 1363
		public extern void SetLineJoinAttribute([In] string attributeName, [In] CanvasLineJoin attributeValue);

		// Token: 0x06000554 RID: 1364
		public extern CanvasLineJoin GetLineJoinAttribute([In] string attributeName);

		// Token: 0x06000555 RID: 1365
		public extern void SetVisibilityAttribute([In] string attributeName, [In] CanvasSvgVisibility attributeValue);

		// Token: 0x06000556 RID: 1366
		public extern CanvasSvgVisibility GetVisibilityAttribute([In] string attributeName);

		// Token: 0x06000557 RID: 1367
		public extern void SetTransformAttribute([In] string attributeName, [In] Matrix3x2 attributeValue);

		// Token: 0x06000558 RID: 1368
		public extern Matrix3x2 GetTransformAttribute([In] string attributeName);

		// Token: 0x06000559 RID: 1369
		public extern void SetUnitsAttribute([In] string attributeName, [In] CanvasSvgUnits attributeValue);

		// Token: 0x0600055A RID: 1370
		public extern CanvasSvgUnits GetUnitsAttribute([In] string attributeName);

		// Token: 0x0600055B RID: 1371
		public extern void SetEdgeBehaviorAttribute([In] string attributeName, [In] CanvasEdgeBehavior attributeValue);

		// Token: 0x0600055C RID: 1372
		public extern CanvasEdgeBehavior GetEdgeBehaviorAttribute([In] string attributeName);

		// Token: 0x0600055D RID: 1373
		public extern void SetRectangleAttribute([In] string attributeName, [In] Rect attributeValue);

		// Token: 0x0600055E RID: 1374
		public extern Rect GetRectangleAttribute([In] string attributeName);

		// Token: 0x0600055F RID: 1375
		public extern void SetLengthAttribute([In] string attributeName, [In] float value, [In] CanvasSvgLengthUnits units);

		// Token: 0x06000560 RID: 1376
		public extern float GetLengthAttribute([In] string attributeName, out CanvasSvgLengthUnits units);

		// Token: 0x06000561 RID: 1377
		public extern void SetAspectRatioAttribute([In] string attributeName, [In] CanvasSvgAspectAlignment alignment, [In] CanvasSvgAspectScaling meetOrSlice);

		// Token: 0x06000562 RID: 1378
		public extern CanvasSvgAspectAlignment GetAspectRatioAttribute([In] string attributeName, out CanvasSvgAspectScaling meetOrSlice);

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000563 RID: 1379
		public extern CanvasSvgDocument ContainingDocument { get; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000564 RID: 1380
		public extern CanvasSvgNamedElement Parent { get; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000565 RID: 1381
		public extern CanvasDevice Device { get; }

		// Token: 0x06000566 RID: 1382
		public extern void Close();
	}
}
