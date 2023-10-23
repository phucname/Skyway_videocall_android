using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']"
	[Register ("com/ntt/skyway/core/channel/Publication", "", "Com.Ntt.Skyway.Core.Channel.IPublicationInvoker")]
	public partial interface IPublication : IJavaObject, IJavaPeerable {
		global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec> CodecCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getCodecCapabilities' and count(parameter)=0]"
			[Register ("getCodecCapabilities", "()Ljava/util/List;", "GetGetCodecCapabilitiesHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;", "GetGetContentTypeHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> Encodings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getEncodings' and count(parameter)=0]"
			[Register ("getEncodings", "()Ljava/util/List;", "GetGetEncodingsHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.IPublication? Origin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getOrigin' and count(parameter)=0]"
			[Register ("getOrigin", "()Lcom/ntt/skyway/core/channel/Publication;", "GetGetOriginHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.Member.IMember Publisher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getPublisher' and count(parameter)=0]"
			[Register ("getPublisher", "()Lcom/ntt/skyway/core/channel/member/Member;", "GetGetPublisherHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Content.Stream? Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Lcom/ntt/skyway/core/content/Stream;", "GetGetStreamHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/Publication$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Channel.IPublication.State GetState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='getStats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStats", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;", "GetGetStats_Ljava_lang_String_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Content.WebRTCStats? GetStats (string remoteMemberId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='replaceStream' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.content.local.LocalStream']]"
		[Register ("replaceStream", "(Lcom/ntt/skyway/core/content/local/LocalStream;)V", "GetReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
		void ReplaceStream (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream stream);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Publication']/method[@name='updateEncodings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;']]"
		[Register ("updateEncodings", "(Ljava/util/List;)V", "GetUpdateEncodings_Ljava_util_List_Handler:Com.Ntt.Skyway.Core.Channel.IPublicationInvoker, skyway_core")]
		void UpdateEncodings (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> encodings);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$Options", DoNotGenerateAcw=true)]
		public sealed partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$Options", typeof (Options));

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

			internal Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/constructor[@name='Publication.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/constructor[@name='Publication.Options' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.ntt.skyway.core.content.Codec&gt;'] and parameter[3][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;'] and parameter[4][@type='java.lang.Boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)V", "")]
			public unsafe Options (string? metadata, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? codecCapabilities, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? encodings, global::Java.Lang.Boolean? isEnabled) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_codecCapabilities = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (codecCapabilities);
				IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_metadata);
					__args [1] = new JniArgumentValue (native_codecCapabilities);
					__args [2] = new JniArgumentValue (native_encodings);
					__args [3] = new JniArgumentValue ((isEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isEnabled).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_codecCapabilities);
					JNIEnv.DeleteLocalRef (native_encodings);
					global::System.GC.KeepAlive (codecCapabilities);
					global::System.GC.KeepAlive (encodings);
					global::System.GC.KeepAlive (isEnabled);
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? CodecCapabilities {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getCodecCapabilities' and count(parameter)=0]"
				[Register ("getCodecCapabilities", "()Ljava/util/List;", "")]
				get {
					const string __id = "getCodecCapabilities.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? Encodings {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getEncodings' and count(parameter)=0]"
				[Register ("getEncodings", "()Ljava/util/List;", "")]
				get {
					const string __id = "getEncodings.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string? Metadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='getMetadata' and count(parameter)=0]"
				[Register ("getMetadata", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getMetadata.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string? Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? Component2 ()
			{
				const string __id = "component2.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? Component3 ()
			{
				const string __id = "component3.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? Component4 ()
			{
				const string __id = "component4.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.ntt.skyway.core.content.Codec&gt;'] and parameter[3][@type='java.util.List&lt;com.ntt.skyway.core.content.Encoding&gt;'] and parameter[4][@type='java.lang.Boolean']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/channel/Publication$Options;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.Options Copy (string? metadata, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec>? codecCapabilities, global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding>? encodings, global::Java.Lang.Boolean? isEnabled)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/lang/Boolean;)Lcom/ntt/skyway/core/channel/Publication$Options;";
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_codecCapabilities = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (codecCapabilities);
				IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_metadata);
					__args [1] = new JniArgumentValue (native_codecCapabilities);
					__args [2] = new JniArgumentValue (native_encodings);
					__args [3] = new JniArgumentValue ((isEnabled == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isEnabled).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_codecCapabilities);
					JNIEnv.DeleteLocalRef (native_encodings);
					global::System.GC.KeepAlive (codecCapabilities);
					global::System.GC.KeepAlive (encodings);
					global::System.GC.KeepAlive (isEnabled);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.Options']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Ljava/lang/Boolean;", "")]
			public unsafe global::Java.Lang.Boolean? IsEnabled ()
			{
				const string __id = "isEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='CANCELED']"
			[Register ("CANCELED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Canceled {
				get {
					const string __id = "CANCELED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Disabled {
				get {
					const string __id = "DISABLED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IPublication.State? Enabled {
				get {
					const string __id = "ENABLED.Lcom/ntt/skyway/core/channel/Publication$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$State$Companion", typeof (Companion));

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

				internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication$State", typeof (State));

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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Publication$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Publication$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Publication.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/Publication$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/Publication$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.IPublication.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.IPublication.State));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Publication", DoNotGenerateAcw=true)]
	internal partial class IPublicationInvoker : global::Java.Lang.Object, IPublication {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Publication", typeof (IPublicationInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPublication? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublication> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.Publication'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChannel);
			return cb_getChannel;
		}

		static IntPtr n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Channel);
		}
#pragma warning restore 0169

		IntPtr id_getChannel;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetMethodID (class_ref, "getChannel", "()Lcom/ntt/skyway/core/channel/Channel;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getCodecCapabilities;
#pragma warning disable 0169
		static Delegate GetGetCodecCapabilitiesHandler ()
		{
			if (cb_getCodecCapabilities == null)
				cb_getCodecCapabilities = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodecCapabilities);
			return cb_getCodecCapabilities;
		}

		static IntPtr n_GetCodecCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.ToLocalJniHandle (__this.CodecCapabilities);
		}
#pragma warning restore 0169

		IntPtr id_getCodecCapabilities;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Codec> CodecCapabilities {
			get {
				if (id_getCodecCapabilities == IntPtr.Zero)
					id_getCodecCapabilities = JNIEnv.GetMethodID (class_ref, "getCodecCapabilities", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Codec>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodecCapabilities), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream.ContentType ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lcom/ntt/skyway/core/content/Stream$ContentType;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream.ContentType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getEncodings;
#pragma warning disable 0169
		static Delegate GetGetEncodingsHandler ()
		{
			if (cb_getEncodings == null)
				cb_getEncodings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEncodings);
			return cb_getEncodings;
		}

		static IntPtr n_GetEncodings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (__this.Encodings);
		}
#pragma warning restore 0169

		IntPtr id_getEncodings;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> Encodings {
			get {
				if (id_getEncodings == IntPtr.Zero)
					id_getEncodings = JNIEnv.GetMethodID (class_ref, "getEncodings", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodings), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public unsafe string Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getNativePointer;
#pragma warning disable 0169
		static Delegate GetGetNativePointerHandler ()
		{
			if (cb_getNativePointer == null)
				cb_getNativePointer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNativePointer);
			return cb_getNativePointer;
		}

		static long n_GetNativePointer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.NativePointer;
		}
#pragma warning restore 0169

		IntPtr id_getNativePointer;
		public unsafe long NativePointer {
			get {
				if (id_getNativePointer == IntPtr.Zero)
					id_getNativePointer = JNIEnv.GetMethodID (class_ref, "getNativePointer", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativePointer);
			}
		}

		static Delegate? cb_getOrigin;
#pragma warning disable 0169
		static Delegate GetGetOriginHandler ()
		{
			if (cb_getOrigin == null)
				cb_getOrigin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOrigin);
			return cb_getOrigin;
		}

		static IntPtr n_GetOrigin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Origin);
		}
#pragma warning restore 0169

		IntPtr id_getOrigin;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication? Origin {
			get {
				if (id_getOrigin == IntPtr.Zero)
					id_getOrigin = JNIEnv.GetMethodID (class_ref, "getOrigin", "()Lcom/ntt/skyway/core/channel/Publication;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrigin), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getPublisher;
#pragma warning disable 0169
		static Delegate GetGetPublisherHandler ()
		{
			if (cb_getPublisher == null)
				cb_getPublisher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublisher);
			return cb_getPublisher;
		}

		static IntPtr n_GetPublisher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Publisher);
		}
#pragma warning restore 0169

		IntPtr id_getPublisher;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember Publisher {
			get {
				if (id_getPublisher == IntPtr.Zero)
					id_getPublisher = JNIEnv.GetMethodID (class_ref, "getPublisher", "()Lcom/ntt/skyway/core/channel/member/Member;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublisher), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getStream;
#pragma warning disable 0169
		static Delegate GetGetStreamHandler ()
		{
			if (cb_getStream == null)
				cb_getStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStream);
			return cb_getStream;
		}

		static IntPtr n_GetStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		IntPtr id_getStream;
		public unsafe global::Com.Ntt.Skyway.Core.Content.Stream? Stream {
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Lcom/ntt/skyway/core/content/Stream;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Stream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getSubscriptions;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionsHandler ()
		{
			if (cb_getSubscriptions == null)
				cb_getSubscriptions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubscriptions);
			return cb_getSubscriptions;
		}

		static IntPtr n_GetSubscriptions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriptions;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			get {
				if (id_getSubscriptions == IntPtr.Zero)
					id_getSubscriptions = JNIEnv.GetMethodID (class_ref, "getSubscriptions", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptions), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IPublication.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/Publication$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_getStats_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStats_Ljava_lang_String_Handler ()
		{
			if (cb_getStats_Ljava_lang_String_ == null)
				cb_getStats_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStats_Ljava_lang_String_);
			return cb_getStats_Ljava_lang_String_;
		}

		static IntPtr n_GetStats_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteMemberId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var remoteMemberId = JNIEnv.GetString (native_remoteMemberId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStats (remoteMemberId!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStats_Ljava_lang_String_;
		public unsafe global::Com.Ntt.Skyway.Core.Content.WebRTCStats? GetStats (string remoteMemberId)
		{
			if (id_getStats_Ljava_lang_String_ == IntPtr.Zero)
				id_getStats_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStats", "(Ljava/lang/String;)Lcom/ntt/skyway/core/content/WebRTCStats;");
			IntPtr native_remoteMemberId = JNIEnv.NewString ((string?)remoteMemberId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_remoteMemberId);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.WebRTCStats> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStats_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_remoteMemberId);
			return __ret;
		}

		static Delegate? cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
#pragma warning disable 0169
		static Delegate GetReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_Handler ()
		{
			if (cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ == null)
				cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_);
			return cb_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
		}

		static void n_ReplaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var stream = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Content.Local.LocalStream> (native_stream, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceStream (stream!);
		}
#pragma warning restore 0169

		IntPtr id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_;
		public unsafe void ReplaceStream (global::Com.Ntt.Skyway.Core.Content.Local.LocalStream stream)
		{
			if (id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ == IntPtr.Zero)
				id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_ = JNIEnv.GetMethodID (class_ref, "replaceStream", "(Lcom/ntt/skyway/core/content/local/LocalStream;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceStream_Lcom_ntt_skyway_core_content_local_LocalStream_, __args);
		}

		static Delegate? cb_updateEncodings_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetUpdateEncodings_Ljava_util_List_Handler ()
		{
			if (cb_updateEncodings_Ljava_util_List_ == null)
				cb_updateEncodings_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateEncodings_Ljava_util_List_);
			return cb_updateEncodings_Ljava_util_List_;
		}

		static void n_UpdateEncodings_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodings)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IPublication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.FromJniHandle (native_encodings, JniHandleOwnership.DoNotTransfer);
			__this.UpdateEncodings (encodings!);
		}
#pragma warning restore 0169

		IntPtr id_updateEncodings_Ljava_util_List_;
		public unsafe void UpdateEncodings (global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Content.Encoding> encodings)
		{
			if (id_updateEncodings_Ljava_util_List_ == IntPtr.Zero)
				id_updateEncodings_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "updateEncodings", "(Ljava/util/List;)V");
			IntPtr native_encodings = global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Content.Encoding>.ToLocalJniHandle (encodings);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_encodings);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateEncodings_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_encodings);
		}

	}
}
