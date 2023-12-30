using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001B1 RID: 433
	[Threading(3)]
	[Static(typeof(IPersonPictureStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Composable(typeof(IPersonPictureFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class PersonPicture : Control, IPersonPicture
	{
		// Token: 0x06000867 RID: 2151
		public extern PersonPicture();

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000868 RID: 2152
		// (set) Token: 0x06000869 RID: 2153
		public extern int BadgeNumber
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600086A RID: 2154
		// (set) Token: 0x0600086B RID: 2155
		public extern string BadgeGlyph
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600086C RID: 2156
		// (set) Token: 0x0600086D RID: 2157
		public extern ImageSource BadgeImageSource
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600086E RID: 2158
		// (set) Token: 0x0600086F RID: 2159
		public extern string BadgeText
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000870 RID: 2160
		// (set) Token: 0x06000871 RID: 2161
		public extern bool IsGroup
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000872 RID: 2162
		// (set) Token: 0x06000873 RID: 2163
		public extern Contact Contact
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000874 RID: 2164
		// (set) Token: 0x06000875 RID: 2165
		public extern string DisplayName
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000876 RID: 2166
		// (set) Token: 0x06000877 RID: 2167
		public extern string Initials
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000879 RID: 2169
		public extern bool PreferSmallImage
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600087A RID: 2170
		// (set) Token: 0x0600087B RID: 2171
		public extern ImageSource ProfilePicture
		{
			get; [param: In]
			set;
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600087C RID: 2172
		[MUXPropertyNeedsDependencyPropertyField]
		public extern PersonPictureTemplateSettings TemplateSettings
		{
			[MUXPropertyNeedsDependencyPropertyField]
			get;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600087D RID: 2173
		public static extern DependencyProperty BadgeNumberProperty { get; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600087E RID: 2174
		public static extern DependencyProperty BadgeGlyphProperty { get; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600087F RID: 2175
		public static extern DependencyProperty BadgeImageSourceProperty { get; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000880 RID: 2176
		public static extern DependencyProperty BadgeTextProperty { get; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000881 RID: 2177
		public static extern DependencyProperty IsGroupProperty { get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000882 RID: 2178
		public static extern DependencyProperty ContactProperty { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000883 RID: 2179
		public static extern DependencyProperty DisplayNameProperty { get; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000884 RID: 2180
		public static extern DependencyProperty InitialsProperty { get; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000885 RID: 2181
		public static extern DependencyProperty PreferSmallImageProperty { get; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000886 RID: 2182
		public static extern DependencyProperty ProfilePictureProperty { get; }
	}
}
