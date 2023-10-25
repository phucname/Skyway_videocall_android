

using Android.Content.PM;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Com.Ntt.Skyway.Core;
using Com.Ntt.Skyway.Core.Content.Local;
using Com.Ntt.Skyway.Core.Content.Local.Source;
using Com.Ntt.Skyway.Core.Content.Remote;
using Com.Ntt.Skyway.Core.Content.Sink;
using Com.Ntt.Skyway.Core.Util;
using Com.Ntt.Skyway.Room;
using Com.Ntt.Skyway.Room.Member;
using Com.Ntt.Skyway.Room.P2p;
using Kotlin.Coroutines;
using Skyway_videocall_android.module;

namespace Skyway_videocall_android
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private static String token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJhMjFiNTdkZS1mZjFmLTRlNjUtOGE3Yi05OGRjNTRkMDE1N2YiLCJpYXQiOjE2OTgxNzg2MzEsImV4cCI6MTY5ODI2NTAzMSwic2NvcGUiOnsiYXBwIjp7ImlkIjoiYTI2MTU2ODUtMjBjNi00YmZiLWE3NTgtOGNjMTk5NjhiNzZhIiwidHVybiI6dHJ1ZSwiYWN0aW9ucyI6WyJyZWFkIl0sImNoYW5uZWxzIjpbeyJpZCI6IioiLCJuYW1lIjoiKiIsImFjdGlvbnMiOlsid3JpdGUiXSwibWVtYmVycyI6W3siaWQiOiIqIiwibmFtZSI6IioiLCJhY3Rpb25zIjpbIndyaXRlIl0sInB1YmxpY2F0aW9uIjp7ImFjdGlvbnMiOlsid3JpdGUiXX0sInN1YnNjcmlwdGlvbiI6eyJhY3Rpb25zIjpbIndyaXRlIl19fV0sInNmdUJvdHMiOlt7ImFjdGlvbnMiOlsid3JpdGUiXSwiZm9yd2FyZGluZ3MiOlt7ImFjdGlvbnMiOlsid3JpdGUiXX1dfV19XX19fQ.1u5NeL5tyaPoG13gJqwLvGkWm1NWoUnjaixsghdarH8";

        SkyWayContext.Options options = new SkyWayContext.Options(token, Logger.LogLevel.Info, false, true, null, null, null, null, null, null);
        Continuation continuation = new Continuation();
        P2PRoomManager p2PRoomManager = new P2PRoomManager();
        Boolean checkConnect = false;
        RoomMember.Init memberInit;
        LocalVideoStream? localVideoStream = null;
        LocalDataStream localDataStream = null;
        RoomPublication publication = null;
        RoomSubscription roomSubscription = null;
        LocalRoomMember localRoomMember = null;
        P2PRoom room = null;
        RoomMember.Init member = new RoomMember.Init("phuc", null, 2);
        SurfaceViewRenderer remotesurfaceViewRenderer;
        SurfaceViewRenderer remosurfaceViewRenderer;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            CheckPermission();
            Task.Run(() =>
            {
                this.continuation.OnResumeWith += OnOnChanged_Continuation;
                this.continuation.OnRemoteVideoRender += OnRemoteVideoRender_Continuation;
                var check1 = SkyWayContext.Setup(Application.Context, options, null, continuation);
                //if (check1.GetType()==typeof(SkyWayContext))
                //{                  
                p2PRoomManager.isSkywayContextSetup = true;
                Console.WriteLine("Err:" + check1);
            });
            Button CreatRoom = (Button)FindViewById(Resource.Id.btnJoinP2PRoom);
            Button CreatRoom1 = (Button)FindViewById(Resource.Id.btnJoinSFURoom);
            CreatRoom1.Click += (s, e) =>
            {
                //subscribeToPublication();
                foreach (RoomPublication roomSubscription in room.Publications)
                {
                    subscribe(roomSubscription);

                }




            };
            CreatRoom.Click += (s, e) =>
            {
                CreateRoomP2p();

            };


        }

        private void CreateRoomP2p()
        {


            SurfaceViewRenderer surfaceViewRenderer = (SurfaceViewRenderer)FindViewById(Resource.Id.local_renderer);
            surfaceViewRenderer.InvokeSetup(SurfaceViewRenderer.LayoutParam.FillParent, SurfaceViewRenderer.LayoutParam.FillParent);
            remosurfaceViewRenderer = (SurfaceViewRenderer)FindViewById(Resource.Id.remote_renderer);
            remosurfaceViewRenderer.InvokeSetup(SurfaceViewRenderer.LayoutParam.FillParent, SurfaceViewRenderer.LayoutParam.FillParent);
            if (checkConnect == true)
            {
                Object room = P2PRoom.FindOrCreate("ccc", null, continuation);

            }
            CameraSource.CapturingOptions capturingOptions = new CameraSource.CapturingOptions(800, 800, 1);
            var device = CameraSource.GetFrontCameras(Application.ApplicationContext).First();
            CameraSource.StartCapturing(Application.ApplicationContext, device, capturingOptions);
            localVideoStream = CameraSource.Instance.CreateStream();
            // RFender render = new RFender();
            localVideoStream.AddRenderer(surfaceViewRenderer);





            //publishCameraVideoStream();
        }

        async private void subscribe(RoomPublication publication)
        {
            // Publicationをsubscribeします
            Object subscription = p2PRoomManager.localPerson.Subscribe(publication, null, continuation);
            //Object subscription = localRoomMember.Subscribe(publication, null, continuation);


        }

        private void OnRemoteVideoRender_Continuation(object? sender, RoomSubscription roomSubscription)
        {

            var remoteStream = roomSubscription.Stream;
            if (remoteStream.GetContentType != null)
            {
                // コンポーネントへの描画
                (remoteStream as RemoteVideoStream).AddRenderer(remosurfaceViewRenderer);

            }
        }


        private void subscribeToPublication()
        {
            //   roomSubscription = p2PRoomManager.localPerson.Subscribe(publications, null, continuation);
            Task.Run(() =>
            {
                object publish = p2PRoomManager.room.Publications;
                Object subscription = p2PRoomManager.localPerson.Subscribe(p2PRoomManager.room.Publications.First(), null, continuation);
                remotesurfaceViewRenderer = (SurfaceViewRenderer)FindViewById(Resource.Id.remote_renderer);
                remotesurfaceViewRenderer.InvokeSetup(SurfaceViewRenderer.LayoutParam.FillParent, SurfaceViewRenderer.LayoutParam.FillParent);
                if (roomSubscription.ContentType == Com.Ntt.Skyway.Core.Content.Stream.ContentType.Video)
                {

                    if (roomSubscription.Stream != null)
                    {
                        (roomSubscription.Stream as RemoteVideoStream).AddRenderer(remotesurfaceViewRenderer);
                    }
                }
            });



        }

        public void CheckPermission()
        {
            if (ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.Camera) == Permission.Granted)
            {
                var requiredPermissions = new string[] { Android.Manifest.Permission.AccessFineLocation };



            }
            else
            {
                ActivityCompat.RequestPermissions(this, new String[] { Android.Manifest.Permission.Camera }, 1);
            }
        }
        public class Continuation : Java.Lang.Object, IContinuation
        {
            public ICoroutineContext Context => EmptyCoroutineContext.Instance;
            public event EventHandler<Java.Lang.Object> OnResumeWith;
            public event EventHandler<RoomSubscription> OnRemoteVideoRender;

            public void ResumeWith(Java.Lang.Object result)
            {
                if (result != null)
                {
                    if (result.GetType() == typeof(RoomSubscription))
                    {
                        this.OnRemoteVideoRender(this, (RoomSubscription)result);

                    }
                    else if (OnResumeWith != null)
                    {
                        this.OnResumeWith(this, result);
                    }
                }




                // Boolean CheckConnect=  CoroutineDispatcher.ReferenceEquals(this, result);
                //  Console.WriteLine("đ" + CheckConnect);

            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [Android.Runtime.GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);


        }
        private void OnOnChanged_Continuation(object? sender, Java.Lang.Object e)
        {

            Console.WriteLine("CheckConnect:" + e);
            try
            {

                checkConnect = true;
                if (e.GetType() == typeof(SkyWayContext))
                {
                    Console.WriteLine("");

                }
                else if (e.GetType() == typeof(P2PRoom))
                {
                    p2PRoomManager.room = (P2PRoom)e;
                    room = (P2PRoom)e;
                    Object p2proom = p2PRoomManager.room.Join(member, continuation);


                }
                else if (e.GetType() == typeof(LocalP2PRoomMember))
                {
                    p2PRoomManager.localPerson = (LocalP2PRoomMember)e;
                    localRoomMember = (LocalP2PRoomMember)e;
                    // localRoomMember.Publish(localVideoStream, null, continuation);
                    // p2PRoomManager.localPerson.Publish(localVideoStream, null, continuation);
                    localRoomMember.Publish(localVideoStream, null, continuation);

                }
                else if (e.GetType() == typeof(RoomPublication))
                {

                    publication = (RoomPublication)e;


                }
                else if (e.GetType() == typeof(RoomSubscription))
                {
                    roomSubscription = (RoomSubscription)e;

                }


            }
            catch (Exception ex)
            {



                Console.WriteLine(typeof(P2PRoom));

            }

        }


    }

}