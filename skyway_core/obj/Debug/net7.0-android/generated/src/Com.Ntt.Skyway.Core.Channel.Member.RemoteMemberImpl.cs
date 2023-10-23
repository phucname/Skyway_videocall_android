using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel.Member {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']"
	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/RemoteMemberImpl", DoNotGenerateAcw=true)]
	public abstract partial class RemoteMemberImpl : global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/RemoteMemberImpl", typeof (RemoteMemberImpl));

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

		protected RemoteMemberImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/constructor[@name='RemoteMemberImpl' and count(parameter)=1 and parameter[1][@type='com.ntt.skyway.core.channel.member.Member.Dto']]"
		[Register (".ctor", "(Lcom/ntt/skyway/core/channel/member/Member$Dto;)V", "")]
		public unsafe RemoteMemberImpl (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto dto) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/ntt/skyway/core/channel/member/Member$Dto;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dto == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dto).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dto);
			}
		}

		public override unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "")]
			get {
				const string __id = "getChannel.()Lcom/ntt/skyway/core/channel/Channel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Metadata);
		}
#pragma warning restore 0169

		public override unsafe string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		static Delegate? cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		public override unsafe long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getNativePointer' and count(parameter)=0]"
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

		static Delegate? cb_getPublications;
#pragma warning disable 0169
		static Delegate GetGetPublicationsHandler ()
		{
			if (cb_getPublications == null)
				cb_getPublications = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPublications);
			return cb_getPublications;
		}

		static IntPtr n_GetPublications (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.ToLocalJniHandle (__this.Publications);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "GetGetPublicationsHandler")]
			get {
				const string __id = "getPublications.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lcom/ntt/skyway/core/channel/member/Member$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMemberImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMemberImpl']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler")]
			get {
				const string __id = "getSubscriptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/RemoteMemberImpl", DoNotGenerateAcw=true)]
	internal partial class RemoteMemberImplInvoker : RemoteMemberImpl {
		public RemoteMemberImplInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/RemoteMemberImpl", typeof (RemoteMemberImplInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='RemoteMember']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler")]
			get {
				const string __id = "getSubType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "GetGetStateHandler")]
		public override unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State GetState ()
		{
			const string __id = "getState.()Lcom/ntt/skyway/core/channel/member/Member$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "GetGetTypeHandler")]
		public override unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type GetType ()
		{
			const string __id = "getType.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
			} finally {
			}
		}

	}
}
