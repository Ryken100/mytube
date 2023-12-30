using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Text
{
	[ComImport]
	[Version(167772160u)]
	public struct CanvasScriptProperties
	{
		public string IsoScriptCode;

		public int IsoScriptNumber;

		public int ClusterLookahead;

		public string JustificationCharacter;

		public bool RestrictCaretToClusters;

		public bool UsesWordDividers;

		public bool IsDiscreteWriting;

		public bool IsBlockWriting;

		public bool IsDistributedWithinCluster;

		public bool IsConnectedWriting;

		public bool IsCursiveWriting;
	}
}
