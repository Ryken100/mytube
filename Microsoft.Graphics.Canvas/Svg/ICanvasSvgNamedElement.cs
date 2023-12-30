using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000B9 RID: 185
	[ExclusiveTo(typeof(CanvasSvgNamedElement))]
	[Guid(3635923860U, 33127, 18781, 156, 113, 94, 151, 229, 208, 141, 43)]
	[Version(167772160U)]
	internal interface ICanvasSvgNamedElement : ICanvasSvgElement, IClosable
	{
		// Token: 0x0600056A RID: 1386
		void AppendChild([In] ICanvasSvgElement child);

		// Token: 0x0600056B RID: 1387
		CanvasSvgNamedElement CreateAndAppendNamedChildElement([In] string childName);

		// Token: 0x0600056C RID: 1388
		CanvasSvgTextElement CreateAndAppendTextChildElement([In] string textContent);

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600056D RID: 1389
		ICanvasSvgElement FirstChild { get; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600056E RID: 1390
		ICanvasSvgElement LastChild { get; }

		// Token: 0x0600056F RID: 1391
		ICanvasSvgElement GetPreviousSibling([In] ICanvasSvgElement child);

		// Token: 0x06000570 RID: 1392
		ICanvasSvgElement GetNextSibling([In] ICanvasSvgElement child);

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000571 RID: 1393
		string[] SpecifiedAttributes { get; }

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000572 RID: 1394
		string Tag { get; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000573 RID: 1395
		bool HasChildren { get; }

		// Token: 0x06000574 RID: 1396
		void InsertChildBefore([In] ICanvasSvgElement child, [In] ICanvasSvgElement referenceChild);

		// Token: 0x06000575 RID: 1397
		[Overload("IsAttributeSpecified")]
		bool IsAttributeSpecified([In] string attributeName);

		// Token: 0x06000576 RID: 1398
		[DefaultOverload]
		[Overload("IsAttributeSpecifiedWithInherhited")]
		bool IsAttributeSpecified([In] string attributeName, [In] bool inherited);

		// Token: 0x06000577 RID: 1399
		void RemoveAttribute([In] string attributeName);

		// Token: 0x06000578 RID: 1400
		void RemoveChild([In] ICanvasSvgElement child);

		// Token: 0x06000579 RID: 1401
		void ReplaceChild([In] ICanvasSvgElement newChild, [In] ICanvasSvgElement oldChild);

		// Token: 0x0600057A RID: 1402
		void SetStringAttribute([In] string attributeName, [In] string attributeValue);

		// Token: 0x0600057B RID: 1403
		string GetStringAttribute([In] string attributeName);

		// Token: 0x0600057C RID: 1404
		void SetAttribute([In] string attributeName, [In] ICanvasSvgAttribute attributeValue);

		// Token: 0x0600057D RID: 1405
		ICanvasSvgAttribute GetAttribute([In] string attributeName);

		// Token: 0x0600057E RID: 1406
		void SetIdAttribute([In] string attributeName, [In] string attributeValue);

		// Token: 0x0600057F RID: 1407
		string GetIdAttribute([In] string attributeName);

		// Token: 0x06000580 RID: 1408
		void SetFloatAttribute([In] string attributeName, [In] float attributeValue);

		// Token: 0x06000581 RID: 1409
		float GetFloatAttribute([In] string attributeName);

		// Token: 0x06000582 RID: 1410
		void SetColorAttribute([In] string attributeName, [In] Color attributeValue);

		// Token: 0x06000583 RID: 1411
		Color GetColorAttribute([In] string attributeName);

		// Token: 0x06000584 RID: 1412
		void SetFilledRegionDeterminationAttribute([In] string attributeName, [In] CanvasFilledRegionDetermination attributeValue);

		// Token: 0x06000585 RID: 1413
		CanvasFilledRegionDetermination GetFilledRegionDeterminationAttribute([In] string attributeName);

		// Token: 0x06000586 RID: 1414
		void SetDisplayAttribute([In] string attributeName, [In] CanvasSvgDisplay attributeValue);

		// Token: 0x06000587 RID: 1415
		CanvasSvgDisplay GetDisplayAttribute([In] string attributeName);

		// Token: 0x06000588 RID: 1416
		void SetOverflowAttribute([In] string attributeName, [In] CanvasSvgOverflow attributeValue);

		// Token: 0x06000589 RID: 1417
		CanvasSvgOverflow GetOverflowAttribute([In] string attributeName);

		// Token: 0x0600058A RID: 1418
		void SetCapStyleAttribute([In] string attributeName, [In] CanvasCapStyle attributeValue);

		// Token: 0x0600058B RID: 1419
		CanvasCapStyle GetCapStyleAttribute([In] string attributeName);

		// Token: 0x0600058C RID: 1420
		void SetLineJoinAttribute([In] string attributeName, [In] CanvasLineJoin attributeValue);

		// Token: 0x0600058D RID: 1421
		CanvasLineJoin GetLineJoinAttribute([In] string attributeName);

		// Token: 0x0600058E RID: 1422
		void SetVisibilityAttribute([In] string attributeName, [In] CanvasSvgVisibility attributeValue);

		// Token: 0x0600058F RID: 1423
		CanvasSvgVisibility GetVisibilityAttribute([In] string attributeName);

		// Token: 0x06000590 RID: 1424
		void SetTransformAttribute([In] string attributeName, [In] Matrix3x2 attributeValue);

		// Token: 0x06000591 RID: 1425
		Matrix3x2 GetTransformAttribute([In] string attributeName);

		// Token: 0x06000592 RID: 1426
		void SetUnitsAttribute([In] string attributeName, [In] CanvasSvgUnits attributeValue);

		// Token: 0x06000593 RID: 1427
		CanvasSvgUnits GetUnitsAttribute([In] string attributeName);

		// Token: 0x06000594 RID: 1428
		void SetEdgeBehaviorAttribute([In] string attributeName, [In] CanvasEdgeBehavior attributeValue);

		// Token: 0x06000595 RID: 1429
		CanvasEdgeBehavior GetEdgeBehaviorAttribute([In] string attributeName);

		// Token: 0x06000596 RID: 1430
		void SetRectangleAttribute([In] string attributeName, [In] Rect attributeValue);

		// Token: 0x06000597 RID: 1431
		Rect GetRectangleAttribute([In] string attributeName);

		// Token: 0x06000598 RID: 1432
		void SetLengthAttribute([In] string attributeName, [In] float value, [In] CanvasSvgLengthUnits units);

		// Token: 0x06000599 RID: 1433
		float GetLengthAttribute([In] string attributeName, out CanvasSvgLengthUnits units);

		// Token: 0x0600059A RID: 1434
		void SetAspectRatioAttribute([In] string attributeName, [In] CanvasSvgAspectAlignment alignment, [In] CanvasSvgAspectScaling meetOrSlice);

		// Token: 0x0600059B RID: 1435
		CanvasSvgAspectAlignment GetAspectRatioAttribute([In] string attributeName, out CanvasSvgAspectScaling meetOrSlice);
	}
}
