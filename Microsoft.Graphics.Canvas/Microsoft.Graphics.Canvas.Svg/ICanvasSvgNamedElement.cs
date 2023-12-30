using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Geometry;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.Graphics.Canvas.Svg
{
	[ComImport]
	[ExclusiveTo(typeof(CanvasSvgNamedElement))]
	[Windows.Foundation.Metadata.Guid(3635923860u, 33127, 18781, 156, 113, 94, 151, 229, 208, 141, 43)]
	[Version(167772160u)]
	internal interface ICanvasSvgNamedElement : ICanvasSvgElement, IDisposable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AppendChild([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgNamedElement CreateAndAppendNamedChildElement([In] string childName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgTextElement CreateAndAppendTextChildElement([In] string textContent);

		ICanvasSvgElement FirstChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		ICanvasSvgElement LastChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ICanvasSvgElement GetPreviousSibling([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ICanvasSvgElement GetNextSibling([In] ICanvasSvgElement child);

		string[] SpecifiedAttributes
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		string Tag
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool HasChildren
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertChildBefore([In] ICanvasSvgElement child, [In] ICanvasSvgElement referenceChild);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("IsAttributeSpecified")]
		bool IsAttributeSpecified([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("IsAttributeSpecifiedWithInherhited")]
		bool IsAttributeSpecified([In] string attributeName, [In] bool inherited);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveChild([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReplaceChild([In] ICanvasSvgElement newChild, [In] ICanvasSvgElement oldChild);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetStringAttribute([In] string attributeName, [In] string attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetStringAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAttribute([In] string attributeName, [In] ICanvasSvgAttribute attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ICanvasSvgAttribute GetAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetIdAttribute([In] string attributeName, [In] string attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetIdAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFloatAttribute([In] string attributeName, [In] float attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float GetFloatAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetColorAttribute([In] string attributeName, [In] Color attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Color GetColorAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFilledRegionDeterminationAttribute([In] string attributeName, [In] CanvasFilledRegionDetermination attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasFilledRegionDetermination GetFilledRegionDeterminationAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDisplayAttribute([In] string attributeName, [In] CanvasSvgDisplay attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgDisplay GetDisplayAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetOverflowAttribute([In] string attributeName, [In] CanvasSvgOverflow attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgOverflow GetOverflowAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCapStyleAttribute([In] string attributeName, [In] CanvasCapStyle attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasCapStyle GetCapStyleAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetLineJoinAttribute([In] string attributeName, [In] CanvasLineJoin attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasLineJoin GetLineJoinAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetVisibilityAttribute([In] string attributeName, [In] CanvasSvgVisibility attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgVisibility GetVisibilityAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetTransformAttribute([In] string attributeName, [In] Matrix3x2 attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Matrix3x2 GetTransformAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetUnitsAttribute([In] string attributeName, [In] CanvasSvgUnits attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgUnits GetUnitsAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetEdgeBehaviorAttribute([In] string attributeName, [In] CanvasEdgeBehavior attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasEdgeBehavior GetEdgeBehaviorAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetRectangleAttribute([In] string attributeName, [In] Rect attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Rect GetRectangleAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetLengthAttribute([In] string attributeName, [In] float value, [In] CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float GetLengthAttribute([In] string attributeName, out CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAspectRatioAttribute([In] string attributeName, [In] CanvasSvgAspectAlignment alignment, [In] CanvasSvgAspectScaling meetOrSlice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		CanvasSvgAspectAlignment GetAspectRatioAttribute([In] string attributeName, out CanvasSvgAspectScaling meetOrSlice);
	}
}
