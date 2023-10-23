using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel.Member {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']"
	[Register ("com/ntt/skyway/core/channel/member/Member", "", "Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker")]
	public partial interface IMember : IJavaObject, IJavaPeerable {
		global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/ntt/skyway/core/channel/Channel;", "GetGetChannelHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		long NativePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getNativePointer' and count(parameter)=0]"
			[Register ("getNativePointer", "()J", "GetGetNativePointerHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/List;", "GetGetPublicationsHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/List;", "GetGetSubscriptionsHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getSide' and count(parameter)=0]"
		[Register ("getSide", "()Lcom/ntt/skyway/core/channel/member/Member$Side;", "GetGetSideHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side GetSide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State GetState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/interface[@name='Member']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "GetGetTypeHandler:Com.Ntt.Skyway.Core.Channel.Member.IMemberInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type GetType ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$Dto", DoNotGenerateAcw=true)]
		public sealed partial class Dto : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$Dto", typeof (Dto));

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

			internal Dto (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/constructor[@name='Member.Dto' and count(parameter)=4 and parameter[1][@type='com.ntt.skyway.core.channel.Channel'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
			[Register (".ctor", "(Lcom/ntt/skyway/core/channel/Channel;Ljava/lang/String;Ljava/lang/String;J)V", "")]
			public unsafe Dto (global::Com.Ntt.Skyway.Core.Channel.IChannel channel, string id, string name, long nativePointer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/ntt/skyway/core/channel/Channel;Ljava/lang/String;Ljava/lang/String;J)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_id = JNIEnv.NewString ((string?)id);
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue (native_name);
					__args [3] = new JniArgumentValue (nativePointer);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					global::System.GC.KeepAlive (channel);
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Channel {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='getChannel' and count(parameter)=0]"
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

			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe long NativePointer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='getNativePointer' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Lcom/ntt/skyway/core/channel/Channel;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel Component1 ()
			{
				const string __id = "component1.()Lcom/ntt/skyway/core/channel/Channel;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Ljava/lang/String;", "")]
			public unsafe string Component3 ()
			{
				const string __id = "component3.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()J", "")]
			public unsafe long Component4 ()
			{
				const string __id = "component4.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Dto']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='com.ntt.skyway.core.channel.Channel'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
			[Register ("copy", "(Lcom/ntt/skyway/core/channel/Channel;Ljava/lang/String;Ljava/lang/String;J)Lcom/ntt/skyway/core/channel/member/Member$Dto;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto Copy (global::Com.Ntt.Skyway.Core.Channel.IChannel channel, string id, string name, long nativePointer)
			{
				const string __id = "copy.(Lcom/ntt/skyway/core/channel/Channel;Ljava/lang/String;Ljava/lang/String;J)Lcom/ntt/skyway/core/channel/member/Member$Dto;";
				IntPtr native_id = JNIEnv.NewString ((string?)id);
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue (native_name);
					__args [3] = new JniArgumentValue (nativePointer);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Dto> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_name);
					global::System.GC.KeepAlive (channel);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$Init", DoNotGenerateAcw=true)]
		public sealed partial class Init : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$Init", typeof (Init));

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

			internal Init (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/constructor[@name='Member.Init' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.ntt.skyway.core.channel.member.Member.Type'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ILcom/ntt/skyway/core/channel/member/Member$Type;Ljava/lang/String;)V", "")]
			public unsafe Init (string name, string? metadata, int keepAliveIntervalSec, global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type type, string subtype) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;ILcom/ntt/skyway/core/channel/member/Member$Type;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_subtype = JNIEnv.NewString ((string?)subtype);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue (keepAliveIntervalSec);
					__args [3] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [4] = new JniArgumentValue (native_subtype);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_subtype);
					global::System.GC.KeepAlive (type);
				}
			}

			public unsafe int KeepAliveIntervalSec {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='getKeepAliveIntervalSec' and count(parameter)=0]"
				[Register ("getKeepAliveIntervalSec", "()I", "")]
				get {
					const string __id = "getKeepAliveIntervalSec.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe string? Metadata {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='getMetadata' and count(parameter)=0]"
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

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe string Subtype {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='getSubtype' and count(parameter)=0]"
				[Register ("getSubtype", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getSubtype.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
				get {
					const string __id = "getType.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/lang/String;", "")]
			public unsafe string Component1 ()
			{
				const string __id = "component1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/lang/String;", "")]
			public unsafe string? Component2 ()
			{
				const string __id = "component2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()I", "")]
			public unsafe int Component3 ()
			{
				const string __id = "component3.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='component4' and count(parameter)=0]"
			[Register ("component4", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type Component4 ()
			{
				const string __id = "component4.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='component5' and count(parameter)=0]"
			[Register ("component5", "()Ljava/lang/String;", "")]
			public unsafe string Component5 ()
			{
				const string __id = "component5.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Init']/method[@name='copy' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.ntt.skyway.core.channel.member.Member.Type'] and parameter[5][@type='java.lang.String']]"
			[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;ILcom/ntt/skyway/core/channel/member/Member$Type;Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Init;", "")]
			public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init Copy (string name, string? metadata, int keepAliveIntervalSec, global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type type, string subtype)
			{
				const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;ILcom/ntt/skyway/core/channel/member/Member$Type;Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Init;";
				IntPtr native_name = JNIEnv.NewString ((string?)name);
				IntPtr native_metadata = JNIEnv.NewString ((string?)metadata);
				IntPtr native_subtype = JNIEnv.NewString ((string?)subtype);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_metadata);
					__args [2] = new JniArgumentValue (keepAliveIntervalSec);
					__args [3] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [4] = new JniArgumentValue (native_subtype);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Init> (__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_metadata);
					JNIEnv.DeleteLocalRef (native_subtype);
					global::System.GC.KeepAlive (type);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Side']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$Side", DoNotGenerateAcw=true)]
		public sealed partial class Side : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Side']/field[@name='LOCAL']"
			[Register ("LOCAL")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side? Local {
				get {
					const string __id = "LOCAL.Lcom/ntt/skyway/core/channel/member/Member$Side;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Side']/field[@name='REMOTE']"
			[Register ("REMOTE")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side? Remote {
				get {
					const string __id = "REMOTE.Lcom/ntt/skyway/core/channel/member/Member$Side;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$Side", typeof (Side));

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

			internal Side (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Side']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Side;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Side;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Side']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/member/Member$Side;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/member/Member$Side;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State']/field[@name='JOINED']"
			[Register ("JOINED")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State? Joined {
				get {
					const string __id = "JOINED.Lcom/ntt/skyway/core/channel/member/Member$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State? Left {
				get {
					const string __id = "LEFT.Lcom/ntt/skyway/core/channel/member/Member$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$State$Companion", typeof (Companion));

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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$State", typeof (State));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/member/Member$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/member/Member$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']/field[@name='BOT']"
			[Register ("BOT")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type? Bot {
				get {
					const string __id = "BOT.Lcom/ntt/skyway/core/channel/member/Member$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']/field[@name='PERSON']"
			[Register ("PERSON")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type? Person {
				get {
					const string __id = "PERSON.Lcom/ntt/skyway/core/channel/member/Member$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type? Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/ntt/skyway/core/channel/member/Member$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member$Type", typeof (Type));

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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/member/Member$Type;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel.member']/class[@name='Member.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/member/Member$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/member/Member", DoNotGenerateAcw=true)]
	internal partial class IMemberInvoker : global::Java.Lang.Object, IMember {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/member/Member", typeof (IMemberInvoker));

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

		public static IMember? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMember> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.member.Member'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMemberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.ToLocalJniHandle (__this.Publications);
		}
#pragma warning restore 0169

		IntPtr id_getPublications;
		public unsafe global::System.Collections.Generic.IList<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			get {
				if (id_getPublications == IntPtr.Zero)
					id_getPublications = JNIEnv.GetMethodID (class_ref, "getPublications", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublications), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getSubType;
#pragma warning disable 0169
		static Delegate GetGetSubTypeHandler ()
		{
			if (cb_getSubType == null)
				cb_getSubType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubType);
			return cb_getSubType;
		}

		static IntPtr n_GetSubType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SubType);
		}
#pragma warning restore 0169

		IntPtr id_getSubType;
		public unsafe string SubType {
			get {
				if (id_getSubType == IntPtr.Zero)
					id_getSubType = JNIEnv.GetMethodID (class_ref, "getSubType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubType), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getSide;
#pragma warning disable 0169
		static Delegate GetGetSideHandler ()
		{
			if (cb_getSide == null)
				cb_getSide = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSide);
			return cb_getSide;
		}

		static IntPtr n_GetSide (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetSide ());
		}
#pragma warning restore 0169

		IntPtr id_getSide;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side GetSide ()
		{
			if (id_getSide == IntPtr.Zero)
				id_getSide = JNIEnv.GetMethodID (class_ref, "getSide", "()Lcom/ntt/skyway/core/channel/member/Member$Side;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Side> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSide), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/member/Member$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef)!;
		}

	}
}
