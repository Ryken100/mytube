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
	// Token: 0x0200006C RID: 108
	[Version(167772160U)]
	[ExclusiveTo(typeof(CanvasTextLayout))]
	[Guid(3135651412U, 18606, 17478, 162, 199, 182, 239, 147, 128, 108, 32)]
	internal interface ICanvasTextLayout : IClosable
	{
		// Token: 0x060002FF RID: 767
		int[] GetFormatChangeIndices();

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		CanvasTextDirection Direction
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000302 RID: 770
		string DefaultFontFamily { get; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000303 RID: 771
		float DefaultFontSize { get; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000304 RID: 772
		FontStretch DefaultFontStretch { get; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000305 RID: 773
		FontStyle DefaultFontStyle { get; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000306 RID: 774
		FontWeight DefaultFontWeight { get; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000307 RID: 775
		// (set) Token: 0x06000308 RID: 776
		float IncrementalTabStop
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000309 RID: 777
		// (set) Token: 0x0600030A RID: 778
		float LineSpacing
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600030B RID: 779
		// (set) Token: 0x0600030C RID: 780
		float LineSpacingBaseline
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600030D RID: 781
		string DefaultLocaleName { get; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600030E RID: 782
		// (set) Token: 0x0600030F RID: 783
		CanvasVerticalAlignment VerticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000310 RID: 784
		// (set) Token: 0x06000311 RID: 785
		CanvasHorizontalAlignment HorizontalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000312 RID: 786
		// (set) Token: 0x06000313 RID: 787
		CanvasTextTrimmingGranularity TrimmingGranularity
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000314 RID: 788
		// (set) Token: 0x06000315 RID: 789
		string TrimmingDelimiter
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000316 RID: 790
		// (set) Token: 0x06000317 RID: 791
		int TrimmingDelimiterCount
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000318 RID: 792
		// (set) Token: 0x06000319 RID: 793
		CanvasWordWrapping WordWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600031A RID: 794
		// (set) Token: 0x0600031B RID: 795
		CanvasDrawTextOptions Options
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600031C RID: 796
		// (set) Token: 0x0600031D RID: 797
		CanvasLineSpacingMode LineSpacingMode
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600031E RID: 798
		// (set) Token: 0x0600031F RID: 799
		CanvasTrimmingSign TrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000320 RID: 800
		// (set) Token: 0x06000321 RID: 801
		ICanvasTextInlineObject CustomTrimmingSign
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000322 RID: 802
		// (set) Token: 0x06000323 RID: 803
		Size RequestedSize
		{
			get; [param: In]
			set;
		}

		// Token: 0x06000324 RID: 804
		float GetMinimumLineLength();

		// Token: 0x06000325 RID: 805
		ICanvasBrush GetBrush([In] int characterIndex);

		// Token: 0x06000326 RID: 806
		object GetCustomBrush([In] int characterIndex);

		// Token: 0x06000327 RID: 807
		string GetFontFamily([In] int characterIndex);

		// Token: 0x06000328 RID: 808
		float GetFontSize([In] int characterIndex);

		// Token: 0x06000329 RID: 809
		FontStretch GetFontStretch([In] int characterIndex);

		// Token: 0x0600032A RID: 810
		FontStyle GetFontStyle([In] int characterIndex);

		// Token: 0x0600032B RID: 811
		FontWeight GetFontWeight([In] int characterIndex);

		// Token: 0x0600032C RID: 812
		string GetLocaleName([In] int characterIndex);

		// Token: 0x0600032D RID: 813
		bool GetStrikethrough([In] int characterIndex);

		// Token: 0x0600032E RID: 814
		bool GetUnderline([In] int characterIndex);

		// Token: 0x0600032F RID: 815
		ICanvasTextInlineObject GetInlineObject([In] int characterIndex);

		// Token: 0x06000330 RID: 816
		void SetColor([In] int characterIndex, [In] int characterCount, [In] Color color);

		// Token: 0x06000331 RID: 817
		void SetBrush([In] int characterIndex, [In] int characterCount, [In] ICanvasBrush brush);

		// Token: 0x06000332 RID: 818
		void SetCustomBrush([In] int characterIndex, [In] int characterCount, [In] object brush);

		// Token: 0x06000333 RID: 819
		void SetFontFamily([In] int characterIndex, [In] int characterCount, [In] string fontFamily);

		// Token: 0x06000334 RID: 820
		void SetFontSize([In] int characterIndex, [In] int characterCount, [In] float fontSize);

		// Token: 0x06000335 RID: 821
		void SetFontStretch([In] int characterIndex, [In] int characterCount, [In] FontStretch fontStretch);

		// Token: 0x06000336 RID: 822
		void SetFontStyle([In] int characterIndex, [In] int characterCount, [In] FontStyle fontStyle);

		// Token: 0x06000337 RID: 823
		void SetFontWeight([In] int characterIndex, [In] int characterCount, [In] FontWeight fontWeight);

		// Token: 0x06000338 RID: 824
		void SetLocaleName([In] int characterIndex, [In] int characterCount, [In] string name);

		// Token: 0x06000339 RID: 825
		void SetStrikethrough([In] int characterIndex, [In] int characterCount, [In] bool hasStrikethrough);

		// Token: 0x0600033A RID: 826
		void SetUnderline([In] int characterIndex, [In] int characterCount, [In] bool hasUnderline);

		// Token: 0x0600033B RID: 827
		void SetInlineObject([In] int characterIndex, [In] int characterCount, [In] ICanvasTextInlineObject inlineObject);

		// Token: 0x0600033C RID: 828
		[Overload("DrawToTextRenderer")]
		void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] Vector2 position);

		// Token: 0x0600033D RID: 829
		[Overload("DrawToTextRendererWithCoords")]
		void DrawToTextRenderer([In] ICanvasTextRenderer textRenderer, [In] float x, [In] float y);

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600033E RID: 830
		CanvasLineMetrics[] LineMetrics { get; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600033F RID: 831
		CanvasClusterMetrics[] ClusterMetrics { get; }

		// Token: 0x06000340 RID: 832
		void SetTypography([In] int characterIndex, [In] int characterCount, [In] CanvasTypography typography);

		// Token: 0x06000341 RID: 833
		CanvasTypography GetTypography([In] int characterIndex);

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000342 RID: 834
		Rect LayoutBounds { get; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000343 RID: 835
		Rect LayoutBoundsIncludingTrailingWhitespace { get; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000344 RID: 836
		int LineCount { get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000345 RID: 837
		int MaximumBidiReorderingDepth { get; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000346 RID: 838
		Rect DrawBounds { get; }

		// Token: 0x06000347 RID: 839
		[Overload("HitTest")]
		bool HitTest([In] Vector2 point);

		// Token: 0x06000348 RID: 840
		[DefaultOverload]
		[Overload("HitTestWithCoords")]
		bool HitTest([In] float x, [In] float y);

		// Token: 0x06000349 RID: 841
		[Overload("HitTestWithDescription")]
		bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x0600034A RID: 842
		[Overload("HitTestWithDescriptionAndCoords")]
		bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x0600034B RID: 843
		[Overload("HitTestWithDescriptionAndTrailingSide")]
		[DefaultOverload]
		bool HitTest([In] Vector2 point, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		// Token: 0x0600034C RID: 844
		[Overload("HitTestWithDescriptionAndCoordsAndTrailingSide")]
		bool HitTest([In] float x, [In] float y, out CanvasTextLayoutRegion textLayoutRegion, out bool trailingSideOfCharacter);

		// Token: 0x0600034D RID: 845
		[Overload("GetCaretPosition")]
		Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter);

		// Token: 0x0600034E RID: 846
		[DefaultOverload]
		[Overload("GetCaretPositionWithDescription")]
		Vector2 GetCaretPosition([In] int characterIndex, [In] bool trailingSideOfCharacter, out CanvasTextLayoutRegion textLayoutRegion);

		// Token: 0x0600034F RID: 847
		[Overload("GetCharacterRegions")]
		[DefaultOverload]
		CanvasTextLayoutRegion[] GetCharacterRegions([In] int characterIndex, [In] int characterCount);

		// Token: 0x06000350 RID: 848
		bool GetPairKerning([In] int characterIndex);

		// Token: 0x06000351 RID: 849
		void SetPairKerning([In] int characterIndex, [In] int characterCount, [In] bool hasPairKerning);

		// Token: 0x06000352 RID: 850
		float GetLeadingCharacterSpacing([In] int characterIndex);

		// Token: 0x06000353 RID: 851
		float GetTrailingCharacterSpacing([In] int characterIndex);

		// Token: 0x06000354 RID: 852
		float GetMinimumCharacterAdvance([In] int characterIndex);

		// Token: 0x06000355 RID: 853
		void SetCharacterSpacing([In] int characterIndex, [In] int characterCount, [In] float leadingSpacing, [In] float trailingSpacing, [In] float minimumAdvance);

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000356 RID: 854
		// (set) Token: 0x06000357 RID: 855
		CanvasVerticalGlyphOrientation VerticalGlyphOrientation
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000358 RID: 856
		// (set) Token: 0x06000359 RID: 857
		CanvasOpticalAlignment OpticalAlignment
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600035A RID: 858
		// (set) Token: 0x0600035B RID: 859
		bool LastLineWrapping
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600035C RID: 860
		CanvasDevice Device { get; }
	}
}
