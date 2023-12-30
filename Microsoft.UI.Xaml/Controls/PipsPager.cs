using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001B3 RID: 435
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Static(typeof(IPipsPagerStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(IPipsPagerFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	public class PipsPager : Control, IPipsPager
	{
		// Token: 0x06000889 RID: 2185
		public extern PipsPager();

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600088A RID: 2186
		// (set) Token: 0x0600088B RID: 2187
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		public extern int NumberOfPages
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600088C RID: 2188
		// (set) Token: 0x0600088D RID: 2189
		[MUXPropertyDefaultValue(value = "0")]
		[MUXPropertyDefaultValue(value = "0")]
		public extern int SelectedPageIndex
		{
			[MUXPropertyDefaultValue(value = "0")]
			get;
			[MUXPropertyDefaultValue(value = "0")]
			[param: In]
			set;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600088E RID: 2190
		// (set) Token: 0x0600088F RID: 2191
		[MUXPropertyDefaultValue(value = "5")]
		[MUXPropertyDefaultValue(value = "5")]
		public extern int MaxVisiblePips
		{
			[MUXPropertyDefaultValue(value = "5")]
			get;
			[MUXPropertyDefaultValue(value = "5")]
			[param: In]
			set;
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000890 RID: 2192
		// (set) Token: 0x06000891 RID: 2193
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		public extern Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			[param: In]
			set;
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000892 RID: 2194
		// (set) Token: 0x06000893 RID: 2195
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		public extern PipsPagerButtonVisibility PreviousButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			[param: In]
			set;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000894 RID: 2196
		// (set) Token: 0x06000895 RID: 2197
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
		public extern PipsPagerButtonVisibility NextButtonVisibility
		{
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::PipsPagerButtonVisibility::Collapsed")]
			[param: In]
			set;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000896 RID: 2198
		// (set) Token: 0x06000897 RID: 2199
		public extern Style PreviousButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000898 RID: 2200
		// (set) Token: 0x06000899 RID: 2201
		public extern Style NextButtonStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600089A RID: 2202
		// (set) Token: 0x0600089B RID: 2203
		public extern Style SelectedPipStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600089C RID: 2204
		// (set) Token: 0x0600089D RID: 2205
		public extern Style NormalPipStyle
		{
			get; [param: In]
			set;
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x0600089E RID: 2206
		// (remove) Token: 0x0600089F RID: 2207
		public extern event TypedEventHandler<PipsPager, PipsPagerSelectedIndexChangedEventArgs> SelectedIndexChanged;

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060008A0 RID: 2208
		[MUXPropertyNeedsDependencyPropertyField]
		public extern PipsPagerTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060008A1 RID: 2209
		public static extern DependencyProperty NumberOfPagesProperty { get; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060008A2 RID: 2210
		public static extern DependencyProperty SelectedPageIndexProperty { get; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060008A3 RID: 2211
		public static extern DependencyProperty MaxVisiblePipsProperty { get; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060008A4 RID: 2212
		public static extern DependencyProperty OrientationProperty { get; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060008A5 RID: 2213
		public static extern DependencyProperty PreviousButtonVisibilityProperty { get; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060008A6 RID: 2214
		public static extern DependencyProperty NextButtonVisibilityProperty { get; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060008A7 RID: 2215
		public static extern DependencyProperty PreviousButtonStyleProperty { get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060008A8 RID: 2216
		public static extern DependencyProperty NextButtonStyleProperty { get; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060008A9 RID: 2217
		public static extern DependencyProperty SelectedPipStyleProperty { get; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060008AA RID: 2218
		public static extern DependencyProperty NormalPipStyleProperty { get; }
	}
}
