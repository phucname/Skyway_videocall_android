using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/LocalPersonImpl", DoNotGenerateAcw=true)]
	public sealed partial class LocalPersonImpl : global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/field[@name='PUBLISH_TIMEOUT_SEC']"
		[Register ("PUBLISH_TIMEOUT_SEC")]
		[global::System.Obsolete (@"deprecated")]
		public const long PublishTimeoutSec = (long) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/field[@name='SUBSCRIBE_TIMEOUT_SEC']"
		[Register ("SUBSCRIBE_TIMEOUT_SEC")]
		[global::System.Obsolete (@"deprecated")]
		public const long SubscribeTimeoutSec = (long) 10000;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/LocalPersonImpl", typeof (LocalPersonImpl));

		internal static new IntPtr class_ref {
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

		internal LocalPersonImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/constructor[@name='LocalPersonImpl' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Dto'] and parameter[2][@type='com.ntt.skyway.core.channel.Repository']]"
		[Register (".ctor", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;Lcom/ntt/skyway/core/channel/Repository;)V", "")]
		public unsafe LocalPersonImpl (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto, global::Com.Ntt.Skyway.Core.Channel.Repository repository) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ntt/skyway/core/channel/member/Member$Dto;Lcom/ntt/skyway/core/channel/Repository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dto).Handle);
				__args [1] = new JniArgumentValue ((repository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) repository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dto);
				global::System.GC.KeepAlive (repository);
			}
		}

		public override unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getChannel' and count(parameter)=0]"
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

		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getId' and count(parameter)=0]"
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

		public override unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getMetadata' and count(parameter)=0]"
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

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getName' and count(parameter)=0]"
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

		public override unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getNativePointer' and count(parameter)=0]"
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

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "")]
			get {
				const string __id = "getPublications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/member/Member$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='LocalPersonImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
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

	}
}
