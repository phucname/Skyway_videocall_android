using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/PublicationImpl", DoNotGenerateAcw=true)]
	public sealed partial class PublicationImpl : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Channel.IPublication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/PublicationImpl", typeof (PublicationImpl));

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

		internal PublicationImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "")]
			get {
				const string __id = "getChannel.()Lcom/ntt/skyway/core/channel/Channel;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec> CodecCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getCodecCapabilities' and count(parameter)=0]"
			[Register ("getCodecCapabilities", "()Ljava/util/List;", "")]
			get {
				const string __id = "getCodecCapabilities.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "")]
			get {
				const string __id = "getContentType.()Lcom/ntt/skyway/core/content/Stream$ContentType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> Encodings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getEncodings' and count(parameter)=0]"
			[Register ("getEncodings", "()Ljava/util/List;", "")]
			get {
				const string __id = "getEncodings.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMetadata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "")]
			get {
				const string __id = "getNativePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication? Origin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getOrigin' and count(parameter)=0]"
			[Register ("getOrigin", "()Lcom/ntt/skyway/core/channel/Publication;", "")]
			get {
				const string __id = "getOrigin.()Lcom/ntt/skyway/core/channel/Publication;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember Publisher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getPublisher' and count(parameter)=0]"
			[Register ("getPublisher", "()Lcom/ntt/skyway/core/channel/member/Member;", "")]
			get {
				const string __id = "getPublisher.()Lcom/ntt/skyway/core/channel/member/Member;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/Publication$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/Publication$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Content.Local.LocalStream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/local/LocalStream;", "")]
			get {
				const string __id = "getStream.()Lcom/ntt/skyway/core/content/local/LocalStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='getStats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStats", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;", "")]
		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? GetStats (string remoteMemberId)
		{
			const string __id = "getStats.(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;";
			IntPtr native_remoteMemberId = JNIEnv.NewString ((string?)remoteMemberId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_remoteMemberId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_remoteMemberId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='replaceStream' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream']]"
		[Register ("replaceStream", "(Lcom/ntt/skyway/core/content/local/LocalStream;)V", "")]
		public unsafe void ReplaceStream (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream stream)
		{
			const string __id = "replaceStream.(Lcom/ntt/skyway/core/content/local/LocalStream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='PublicationImpl']/method[@name='updateEncodings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;']]"
		[Register ("updateEncodings", "(Ljava/util/List;)V", "")]
		public unsafe void UpdateEncodings (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> encodings)
		{
			const string __id = "updateEncodings.(Ljava/util/List;)V";
			IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encodings);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_encodings);
				global::System.GC.KeepAlive (encodings);
			}
		}

	}
}
