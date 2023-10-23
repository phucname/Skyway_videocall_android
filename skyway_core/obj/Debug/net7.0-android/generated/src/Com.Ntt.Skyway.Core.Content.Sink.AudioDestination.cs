using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Content.Sink {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='AudioDestination']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/content/sink/AudioDestination", DoNotGenerateAcw=true)]
	public sealed partial class AudioDestination : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='AudioDestination']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Ntt.Skyway.Core.Content.Sink.AudioDestination Instance {
			get {
				const string __id = "INSTANCE.Lcom/ntt/skyway/core/content/sink/AudioDestination;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Sink.AudioDestination> (__v.Handle, JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/content/sink/AudioDestination", typeof (AudioDestination));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal AudioDestination (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Media.AudioTrack? AudioTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='AudioDestination']/method[@name='getAudioTrack' and count(parameter)=0]"
			[Register ("getAudioTrack", "()Landroid/media/AudioTrack;", "")]
			get {
				const string __id = "getAudioTrack.()Landroid/media/AudioTrack;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.AudioTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.content.sink']/class[@name='AudioDestination']/method[@name='changeTrack' and count(parameter)=1 and parameter[1][@type='android.media.AudioTrack']]"
		[Register ("changeTrack", "(Landroid/media/AudioTrack;)V", "")]
		public static unsafe void ChangeTrack (global::Android.Media.AudioTrack audioTrack)
		{
			const string __id = "changeTrack.(Landroid/media/AudioTrack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((audioTrack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioTrack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (audioTrack);
			}
		}

	}
}
