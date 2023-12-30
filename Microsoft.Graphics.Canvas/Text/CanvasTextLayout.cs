using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas.Brushes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI;
using Windows.UI.Text;

namespace Microsoft.Graphics.Canvas.Text
{
	// Token: 0x0200006E RID: 110
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Static(typeof(ICanvasTextLayoutStatics), 167772160U)]
	[Activatable(typeof(ICanvasTextLayoutFactory), 167772160U)]
	public sealed class CanvasTextLayout : ICanvasTextLayout, IClosable
	{
		// Token: 0x0600035E RID: 862
		public extern CanvasTextLayout([In] ICanvasResourceCreator resourceCreator, [In] string textString, [In] CanvasTextFormat textFormat, [In] float requestedWidth, [In] float requestedHeight);

		// Token: 0x0600035F RID: 863
		public extern int[] GetFormatChangeIndices();

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000360 RID: 864
		// (set) Token: 0x06000361 RID: 865
		public extern CanvasTextDirection Direction
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000362 RID: 866
		public extern string DefaultFontFamily { get; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000363 RID: 867
		public extern float DefaultFontSize { get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000364 RID: 868
		public extern FontStretch DefaultFontStretch { get; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000365 RID: 869
		public extern FontStyle DefaultFontStyle { get; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000366 RID: 870
		public extern FontWeight DefaultFontWeight { get; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000367 RID: 871
		// (set) Token: 0x06000368 RID: 872
		public extern float IncrementalTabStop
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000369 RID: 873
		// (set) Token: 0x0600036A RID: 874
		public extern float LineSpacing
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600036B RID: 875
		// (set) Token: 0x0600036C RID: 876
		public extern float LineSpacingBaseline
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600036D RID: 877
		public extern string DefaultLocaleName { get; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600036E RID: 878
		// (set) Token: 0x0600036F RID: 879
		public extern CanvasVerticalAlignment VerticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000370 RID: 880
		// (set) Token: 0x06000371 RID: 881
		public extern CanvasHorizontalAlignment HorizontalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000372 RID: 882
		// (set) Token: 0x06000373 RID: 883
		public extern CanvasTextTrimmingGranularity TrimmingGranularity
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000374 RID: 884
		// (set) Token: 0x06000375 RID: 885
		public extern string TrimmingDelimiter
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000376 RID: 886
		// (set) Token: 0x06000377 RID: 887
		public extern int TrimmingDelimiterCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000378 RID: 888
		// (set) Token: 0x06000379 RID: 889
		public extern CanvasWordWrapping WordWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600037A RID: 890
		// (set) Token: 0x0600037B RID: 891
		public extern CanvasDrawTextOptions Options
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600037C RID: 892
		// (set) Token: 0x0600037D RID: 893
		public extern CanvasLineSpacingMode LineSpacingMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600037E RID: 894
		// (set) Token: 0x0600037F RID: 895
		public extern CanvasTrimmingSign TrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000380 RID: 896
		// (set) Token: 0x06000381 RID: 897
		public extern ICanvasTextInlineObject CustomTrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000382 RID: 898
		// (set) Token: 0x06000383 RID: 899
		public extern Size RequestedSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000384 RID: 900
		public extern float GetMinimumLineLength();

		// Token: 0x06000385 RID: 901
		public extern ICanvasBrush GetBrush([In] int characterIndex);

		// Token: 0x06000386 RID: 902
		public extern object GetCustomBrush([In] int characterIndex);

		// Token: 0x06000387 RID: 903
		public extern string GetFontFamily([In] int characterIndex);

		// Token: 0x06000388 RID: 904
		public extern float GetFontSize([In] int characterIndex);

		// Token: 0x06000389 RID: 905
		public extern FontStretch GetFontStretch([In] int characterIndex);

		// Token: 0x0600038A RID: 906
		public extern FontStyle GetFontStyle([In] int characterIndex);

		// Token: 0x0600038B RID: 907
		public extern FontWeight GetFontWeight([In] int characterIndex);

		// Token: 0x0600038C RID: 908
		public extern string GetLocaleName([In] int characterIndex);

		// Token: 0x0600038D RID: 909
		public extern bool GetStrikethrough([In] int characterIndex);

		// Token: 0x0600038E RID: 910
		public extern bool GetUnderline([In] int characterIndex);

		// Token: 0x0600038F RID: 911
		public extern ICanvasTextInlineObject GetInlineObject([In] int characterIndex);

		// Token: 0x06000390 RID: 912
		public extern void SetColor([In] int characterIndex, [In] int characterCount, [In] Color color);

		// Token: 0x06000391 RID: 913
		public extern void SetBrush([In] int characterIndex, [In] int characterCount, [In] ICanvasBrush brush);

		// Token: 0x06000392 RID: 914
		public extern void SetCustomBrush([In] int characterIndex, [In] int characterCount, [In] object brush);

		// Token: 0x06000393 RID: 915
		public extern void SetFontFamily([In] int characterIndex, [In] int characterCount, [In] string fontFamily);

		// Token: 0x06000394 RID: 916
		public extern void SetFontSize([In] int characterIndex, [In] int characterCount, [In] float fontSize);

		// Token: 0x06000395 RID: 917
		public extern void SetFontStretch([In] int characterIndex, [In] int characterCount, [In] FontStretch fontStretch);

		// Token: 0x06000396 RID: 918
		public extern void SetFontStyle([In] int characterIndex, [In] int characterCount, [In] FontStyle fontStyle);

		// Token: 0x06000397 RID: 919
		public extern void SetFontWeight([In] int characterIndex, [In] int characterCount, [In] FontWeight fontWeight);

		// Token: 0x06000398 RID: 920
		public extern void SetLocaleName([In] int characterIndex, [In] int characterCount, [In] string name);

		// Token: 0x06000399 RID: 921
		public extern void SetStrikethrough([In] int characterIndex, [In] int characterCount, [In] bool hasStrikethrough);

		// Token: 0x0600039A RID: 922
		public extern void SetUnderline([In] int characterIndex, [In] int characterCount, [In] bool hasUnderline);

		// Token: 0x0600039B RID: 923
		public extern void SetInlineObject([In] int characterIndex, [In] int characterCount, [In] ICanvasTextInlineObject inlineObject);

		// Token: 0x0600039C RID: 924
		[Overload("DrawToTextRenderer")]
		public extern void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] Vector2 position);

		// Token: 0x0600039D RID: 925
		[Overload("DrawToTextRendererWithCoords")]
		public extern void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] float x, [In] float y);

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600039E RID: 926
		public extern CanvasLineMetrics[] LineMetrics { get; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600039F RID: 927
		public extern CanvasClusterMetrics[] ClusterMetrics { get; }

		// Token: 0x060003A0 RID: 928
		public extern void SetTypography([In] int characterIndex, [In] int characterCount, [In] CanvasTypography typography);

		// Token: 0x060003A1 RID: 929
		public extern CanvasTypography GetTypography([In] int characterIndex);

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060003A2 RID: 930
		public extern Rect LayoutBounds { get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060003A3 RID: 931
		public extern Rect LayoutBoundsIncludingTrailingWhitespace { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060003A4 RID: 932
		public extern int LineCount { get; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060003A5 RID: 933
		public extern int MaximumBidiReorderingDepth { get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060003A6 RID: 934
		public extern Rect DrawBounds { get; }

		// Token: 0x060003A7 RID: 935
		[Overload("HitTest")]
		public extern bool HitTest([In] Vector2 point);

		// Token: 0x060003A8 RID: 936
		[Overload("HitTestWithCoords")]
		[DefaultOverload]
		public extern bool HitTest([In] float x, [In] float y);

		// Token: 0x060003A9 RID: 937
		[Overload("HitTestWithDescription")]
		public extern bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x060003AA RID: 938
		[Overload("HitTestWithDescriptionAndCoords")]
		public extern bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x060003AB RID: 939
		[DefaultOverload]
		[Overload("HitTestWithDescriptionAndTrailingSide")]
		public extern bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		// Token: 0x060003AC RID: 940
		[Overload("HitTestWithDescriptionAndCoordsAndTrailingSide")]
		public extern bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		// Token: 0x060003AD RID: 941
		[Overload("GetCaretPosition")]
		public extern Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter);

		// Token: 0x060003AE RID: 942
		[Overload("GetCaretPositionWithDescription")]
		[DefaultOverload]
		public extern Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x060003AF RID: 943
		[Overload("GetCharacterRegions")]
		[DefaultOverload]
		public extern CanvasTextLayoutRegion[] GetCharacterRegions([In] int characterIndex, [In] int characterCount);

		// Token: 0x060003B0 RID: 944
		public extern bool GetPairKerning([In] int characterIndex);

		// Token: 0x060003B1 RID: 945
		public extern void SetPairKerning([In] int characterIndex, [In] int characterCount, [In] bool hasPairKerning);

		// Token: 0x060003B2 RID: 946
		public extern float GetLeadingCharacterSpacing([In] int characterIndex);

		// Token: 0x060003B3 RID: 947
		public extern float GetTrailingCharacterSpacing([In] int characterIndex);

		// Token: 0x060003B4 RID: 948
		public extern float GetMinimumCharacterAdvance([In] int characterIndex);

		// Token: 0x060003B5 RID: 949
		public extern void SetCharacterSpacing([In] int characterIndex, [In] int characterCount, [In] float leadingSpacing, [In] float trailingSpacing, [In] float minimumAdvance);

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060003B6 RID: 950
		// (set) Token: 0x060003B7 RID: 951
		public extern CanvasVerticalGlyphOrientation VerticalGlyphOrientation
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060003B8 RID: 952
		// (set) Token: 0x060003B9 RID: 953
		public extern CanvasOpticalAlignment OpticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060003BA RID: 954
		// (set) Token: 0x060003BB RID: 955
		public extern bool LastLineWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060003BC RID: 956
		public extern CanvasDevice Device { get; }

		// Token: 0x060003BD RID: 957
		public extern void Close();

		// Token: 0x060003BE RID: 958
		public static extern Matrix3x2 GetGlyphOrientationTransform([In] CanvasGlyphOrientation glyphOrientation, [In] bool isSideways, [In] Vector2 position);
	}
}
