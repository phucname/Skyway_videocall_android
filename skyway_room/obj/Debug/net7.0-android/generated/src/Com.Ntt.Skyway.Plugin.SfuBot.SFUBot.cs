using Android.Runtime;
using Com.Ntt.Skyway.Core.Channel;
using Com.Ntt.Skyway.Core.Channel.Member;
using Java.Interop;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Com.Ntt.Skyway.Plugin.SfuBot
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']"
    [global::Android.Runtime.Register("com/ntt/skyway/plugin/sfuBot/SFUBot", DoNotGenerateAcw = true)]
    public sealed partial class SFUBot : global::Com.Ntt.Skyway.Core.Channel.Member.RemoteMember
    {
        // Metadata.xml XPath class reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot.Companion']"
        [global::Android.Runtime.Register("com/ntt/skyway/plugin/sfuBot/SFUBot$Companion", DoNotGenerateAcw = true)]
        public sealed partial class Companion : global::Java.Lang.Object
        {
            static readonly JniPeerMembers _members = new XAPeerMembers("com/ntt/skyway/plugin/sfuBot/SFUBot$Companion", typeof(Companion));

            internal static IntPtr class_ref
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            internal Companion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot.Companion']/constructor[@name='SFUBot.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
            [Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
            public unsafe Companion(global::Kotlin.Jvm.Internal.DefaultConstructorMarker? _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object)_constructor_marker).Handle);
                    var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                    SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                    _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
                }
                finally
                {
                    global::System.GC.KeepAlive(_constructor_marker);
                }
            }

            // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot.Companion']/method[@name='createBot' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Channel'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.plugin.sfuBot.SFUBot&gt;']]"
            [Register("createBot", "(Lcom/ntt/skyway/core/channel/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
            public unsafe global::Java.Lang.Object? CreateBot(global::Com.Ntt.Skyway.Core.Channel.IChannel channel, global::Kotlin.Coroutines.IContinuation _completion)
            {
                const string __id = "createBot.(Lcom/ntt/skyway/core/channel/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                    __args[0] = new JniArgumentValue((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object)channel).Handle);
                    __args[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object)_completion).Handle);
                    var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                    global::System.GC.KeepAlive(channel);
                    global::System.GC.KeepAlive(_completion);
                }
            }

        }

        static readonly JniPeerMembers _members = new XAPeerMembers("com/ntt/skyway/plugin/sfuBot/SFUBot", typeof(SFUBot));

        internal static new IntPtr class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        internal SFUBot(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public unsafe global::System.Collections.Generic.ICollection<global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding> Forwardings
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='getForwardings' and count(parameter)=0]"
            [Register("getForwardings", "()Ljava/util/Set;", "")]
            get
            {
                const string __id = "getForwardings.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                }
            }
        }

        public override unsafe string SubType
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='getSubType' and count(parameter)=0]"
            [Register("getSubType", "()Ljava/lang/String;", "")]
            get
            {
                const string __id = "getSubType.()Ljava/lang/String;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                }
            }
        }

        public unsafe global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type Type
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='getType' and count(parameter)=0]"
            [Register("getType", "()Lcom/ntt/skyway/core/channel/member/Member$Type;", "")]
            get
            {
                const string __id = "getType.()Lcom/ntt/skyway/core/channel/member/Member$Type;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::Com.Ntt.Skyway.Core.Channel.Member.IMember.Type>(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                }
            }
        }

        public override IChannel Channel => throw new NotImplementedException();

        public override string Id => throw new NotImplementedException();

        public override string Metadata => throw new NotImplementedException();

        public override string Name => throw new NotImplementedException();

        public override long NativePointer => throw new NotImplementedException();

        public override IFunction0? OnLeftHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IFunction1? OnMetadataUpdatedHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IFunction0? OnPublicationListChangedHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IFunction0? OnSubscriptionListChangedHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override IList<IPublication> Publications => throw new NotImplementedException();

        public override IList<ISubscription> Subscriptions => throw new NotImplementedException();

        // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='createBot' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.core.channel.Channel'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.plugin.sfuBot.SFUBot&gt;']]"
        [Register("createBot", "(Lcom/ntt/skyway/core/channel/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
        public static unsafe global::Java.Lang.Object? CreateBot(global::Com.Ntt.Skyway.Core.Channel.IChannel channel, global::Kotlin.Coroutines.IContinuation _completion)
        {
            const string __id = "createBot.(Lcom/ntt/skyway/core/channel/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object)channel).Handle);
                __args[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object)_completion).Handle);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(channel);
                global::System.GC.KeepAlive(_completion);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='startForwarding' and count(parameter)=3 and parameter[1][@type='com.ntt.skyway.core.channel.Publication'] and parameter[2][@type='com.ntt.skyway.plugin.sfuBot.Forwarding.Configure'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super com.ntt.skyway.plugin.sfuBot.Forwarding&gt;']]"
        [Register("startForwarding", "(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
        public unsafe global::Java.Lang.Object? StartForwarding(global::Com.Ntt.Skyway.Core.Channel.IPublication publication, global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding.Configure? configure, global::Kotlin.Coroutines.IContinuation _completion)
        {
            const string __id = "startForwarding.(Lcom/ntt/skyway/core/channel/Publication;Lcom/ntt/skyway/plugin/sfuBot/Forwarding$Configure;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((publication == null) ? IntPtr.Zero : ((global::Java.Lang.Object)publication).Handle);
                __args[1] = new JniArgumentValue((configure == null) ? IntPtr.Zero : ((global::Java.Lang.Object)configure).Handle);
                __args[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object)_completion).Handle);
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(publication);
                global::System.GC.KeepAlive(configure);
                global::System.GC.KeepAlive(_completion);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.ntt.skyway.plugin.sfuBot']/class[@name='SFUBot']/method[@name='stopForwarding' and count(parameter)=2 and parameter[1][@type='com.ntt.skyway.plugin.sfuBot.Forwarding'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
        [Register("stopForwarding", "(Lcom/ntt/skyway/plugin/sfuBot/Forwarding;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
        public unsafe global::Java.Lang.Object? StopForwarding(global::Com.Ntt.Skyway.Plugin.SfuBot.Forwarding forwarding, global::Kotlin.Coroutines.IContinuation _completion)
        {
            const string __id = "stopForwarding.(Lcom/ntt/skyway/plugin/sfuBot/Forwarding;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((forwarding == null) ? IntPtr.Zero : ((global::Java.Lang.Object)forwarding).Handle);
                __args[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((global::Java.Lang.Object)_completion).Handle);
                var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(forwarding);
                global::System.GC.KeepAlive(_completion);
            }
        }

        public override IMember.State GetState()
        {
            throw new NotImplementedException();
        }

        public override IMember.Type GetType()
        {
            throw new NotImplementedException();
        }

        public override Java.Lang.Object? Leave(IContinuation p0)
        {
            throw new NotImplementedException();
        }

        public override Java.Lang.Object? UpdateMetadata(string metadata, IContinuation p1)
        {
            throw new NotImplementedException();
        }
    }
}
