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
	[Threading(ThreadingModel.Both)]
	[Version(167772160u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class CanvasSvgNamedElement : ICanvasSvgNamedElement, IDisposable, ICanvasSvgElement
	{
		public extern CanvasSvgDocument ContainingDocument
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasDevice Device
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern CanvasSvgNamedElement Parent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern ICanvasSvgElement FirstChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern bool HasChildren
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern ICanvasSvgElement LastChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern string[] SpecifiedAttributes
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern string Tag
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void AppendChild([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgNamedElement CreateAndAppendNamedChildElement([In] string childName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgTextElement CreateAndAppendTextChildElement([In] string textContent);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasSvgElement GetPreviousSibling([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasSvgElement GetNextSibling([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void InsertChildBefore([In] ICanvasSvgElement child, [In] ICanvasSvgElement referenceChild);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("IsAttributeSpecified")]
		public extern bool IsAttributeSpecified([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("IsAttributeSpecifiedWithInherhited")]
		public extern bool IsAttributeSpecified([In] string attributeName, [In] bool inherited);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RemoveAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RemoveChild([In] ICanvasSvgElement child);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void ReplaceChild([In] ICanvasSvgElement newChild, [In] ICanvasSvgElement oldChild);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetStringAttribute([In] string attributeName, [In] string attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern string GetStringAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetAttribute([In] string attributeName, [In] ICanvasSvgAttribute attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern ICanvasSvgAttribute GetAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetIdAttribute([In] string attributeName, [In] string attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern string GetIdAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFloatAttribute([In] string attributeName, [In] float attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetFloatAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetColorAttribute([In] string attributeName, [In] Color attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Color GetColorAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetFilledRegionDeterminationAttribute([In] string attributeName, [In] CanvasFilledRegionDetermination attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasFilledRegionDetermination GetFilledRegionDeterminationAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetDisplayAttribute([In] string attributeName, [In] CanvasSvgDisplay attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgDisplay GetDisplayAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetOverflowAttribute([In] string attributeName, [In] CanvasSvgOverflow attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgOverflow GetOverflowAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetCapStyleAttribute([In] string attributeName, [In] CanvasCapStyle attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasCapStyle GetCapStyleAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetLineJoinAttribute([In] string attributeName, [In] CanvasLineJoin attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasLineJoin GetLineJoinAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetVisibilityAttribute([In] string attributeName, [In] CanvasSvgVisibility attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgVisibility GetVisibilityAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetTransformAttribute([In] string attributeName, [In] Matrix3x2 attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Matrix3x2 GetTransformAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetUnitsAttribute([In] string attributeName, [In] CanvasSvgUnits attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgUnits GetUnitsAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetEdgeBehaviorAttribute([In] string attributeName, [In] CanvasEdgeBehavior attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasEdgeBehavior GetEdgeBehaviorAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetRectangleAttribute([In] string attributeName, [In] Rect attributeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Rect GetRectangleAttribute([In] string attributeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetLengthAttribute([In] string attributeName, [In] float value, [In] CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern float GetLengthAttribute([In] string attributeName, out CanvasSvgLengthUnits units);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void SetAspectRatioAttribute([In] string attributeName, [In] CanvasSvgAspectAlignment alignment, [In] CanvasSvgAspectScaling meetOrSlice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern CanvasSvgAspectAlignment GetAspectRatioAttribute([In] string attributeName, out CanvasSvgAspectScaling meetOrSlice);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void Dispose();
	}
}
