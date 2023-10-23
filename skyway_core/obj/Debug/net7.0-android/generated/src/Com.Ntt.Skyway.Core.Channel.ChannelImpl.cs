using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/ChannelImpl", DoNotGenerateAcw=true)]
	public sealed partial class ChannelImpl : global::Java.Lang.Object, global::Com.Ntt.Skyway.Core.Channel.IChannel {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/ChannelImpl$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/ChannelImpl$Companion", typeof (Companion));

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/ChannelImpl", typeof (ChannelImpl));

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

		internal ChannelImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getBots' and count(parameter)=0]"
			[Register ("getBots", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getBots.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getId' and count(parameter)=0]"
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

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getLocalPerson' and count(parameter)=0]"
			[Register ("getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;", "")]
			get {
				const string __id = "getLocalPerson.()Lcom/ntt/skyway/core/channel/member/LocalPerson;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getMembers.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getMetadata' and count(parameter)=0]"
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

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "")]
			get {
				const string __id = "getNativePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getPublications.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Repository Repository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getRepository' and count(parameter)=0]"
			[Register ("getRepository", "()Lcom/ntt/skyway/core/channel/Repository;", "")]
			get {
				const string __id = "getRepository.()Lcom/ntt/skyway/core/channel/Repository;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Repository> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/Channel$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='ChannelImpl']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
