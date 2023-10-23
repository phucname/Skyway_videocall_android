using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ntt.Skyway.Core.Channel {

	[Register ("com/ntt/skyway/core/channel/Channel", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Ntt.Skyway.Core.Channel.IChannel' type. This class will be removed in a future release.")]
	public abstract class Channel : Java.Lang.Object {
		internal Channel ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']"
	[Register ("com/ntt/skyway/core/channel/Channel", "", "Com.Ntt.Skyway.Core.Channel.IChannelInvoker")]
	public partial interface IChannel : IJavaObject, IJavaPeerable {
		private static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel", typeof (IChannel), isInterface: true);

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getBots' and count(parameter)=0]"
			[Register ("getBots", "()Ljava/util/Set;", "GetGetBotsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getLocalPerson' and count(parameter)=0]"
			[Register ("getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;", "GetGetLocalPersonHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/Set;", "GetGetMembersHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		string Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/lang/String;", "GetGetMetadataHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getPublications' and count(parameter)=0]"
			[Register ("getPublications", "()Ljava/util/Set;", "GetGetPublicationsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getSubscriptions' and count(parameter)=0]"
			[Register ("getSubscriptions", "()Ljava/util/Set;", "GetGetSubscriptionsHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/interface[@name='Channel']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/ntt/skyway/core/channel/Channel$State;", "GetGetStateHandler:Com.Ntt.Skyway.Core.Channel.IChannelInvoker, skyway_core")]
		global::Com.Ntt.Skyway.Core.Channel.IChannel.State GetState ();

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.Companion']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$Companion", typeof (Companion));

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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']"
		[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IChannel.State? Closed {
				get {
					const string __id = "CLOSED.Lcom/ntt/skyway/core/channel/Channel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/field[@name='OPENED']"
			[Register ("OPENED")]
			public static global::Com.Ntt.Skyway.Core.Channel.IChannel.State? Opened {
				get {
					const string __id = "OPENED.Lcom/ntt/skyway/core/channel/Channel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State.Companion']"
			[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel$State$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$State$Companion", typeof (Companion));

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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel$State", typeof (State));

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State? ValueOf (string? value)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/ntt/skyway/core/channel/Channel$State;";
				IntPtr native_value = JNIEnv.NewString ((string?)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.core.channel']/class[@name='Channel.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ntt/skyway/core/channel/Channel$State;", "")]
			public static unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State[]? Values ()
			{
				const string __id = "values.()[Lcom/ntt/skyway/core/channel/Channel$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Ntt.Skyway.Core.Channel.IChannel.State[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ntt.Skyway.Core.Channel.IChannel.State));
				} finally {
				}
			}

		}

	}

	[global::Android.Runtime.Register ("com/ntt/skyway/core/channel/Channel", DoNotGenerateAcw=true)]
	internal partial class IChannelInvoker : global::Java.Lang.Object, IChannel {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/ntt/skyway/core/channel/Channel", typeof (IChannelInvoker));

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

		public static IChannel? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.ntt.skyway.core.channel.Channel'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getBots;
#pragma warning disable 0169
		static Delegate GetGetBotsHandler ()
		{
			if (cb_getBots == null)
				cb_getBots = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBots);
			return cb_getBots;
		}

		static IntPtr n_GetBots (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.ToLocalJniHandle (__this.Bots);
		}
#pragma warning restore 0169

		IntPtr id_getBots;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Bots {
			get {
				if (id_getBots == IntPtr.Zero)
					id_getBots = JNIEnv.GetMethodID (class_ref, "getBots", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBots), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getLocalPerson;
#pragma warning disable 0169
		static Delegate GetGetLocalPersonHandler ()
		{
			if (cb_getLocalPerson == null)
				cb_getLocalPerson = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalPerson);
			return cb_getLocalPerson;
		}

		static IntPtr n_GetLocalPerson (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LocalPerson);
		}
#pragma warning restore 0169

		IntPtr id_getLocalPerson;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson? LocalPerson {
			get {
				if (id_getLocalPerson == IntPtr.Zero)
					id_getLocalPerson = JNIEnv.GetMethodID (class_ref, "getLocalPerson", "()Lcom/ntt/skyway/core/channel/member/LocalPerson;");
				return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.LocalPerson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalPerson), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getMembers;
#pragma warning disable 0169
		static Delegate GetGetMembersHandler ()
		{
			if (cb_getMembers == null)
				cb_getMembers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMembers);
			return cb_getMembers;
		}

		static IntPtr n_GetMembers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.ToLocalJniHandle (__this.Members);
		}
#pragma warning restore 0169

		IntPtr id_getMembers;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.Member.IMember> Members {
			get {
				if (id_getMembers == IntPtr.Zero)
					id_getMembers = JNIEnv.GetMethodID (class_ref, "getMembers", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.Member.IMember>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembers), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.ToLocalJniHandle (__this.Publications);
		}
#pragma warning restore 0169

		IntPtr id_getPublications;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.IPublication> Publications {
			get {
				if (id_getPublications == IntPtr.Zero)
					id_getPublications = JNIEnv.GetMethodID (class_ref, "getPublications", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.IPublication>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublications), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.ToLocalJniHandle (__this.Subscriptions);
		}
#pragma warning restore 0169

		IntPtr id_getSubscriptions;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Core.Channel.ISubscription> Subscriptions {
			get {
				if (id_getSubscriptions == IntPtr.Zero)
					id_getSubscriptions = JNIEnv.GetMethodID (class_ref, "getSubscriptions", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Core.Channel.ISubscription>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptions), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Ntt.Skyway.Core.Channel.IChannel.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/ntt/skyway/core/channel/Channel$State;");
			return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.IChannel.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef)!;
		}

	}
}
