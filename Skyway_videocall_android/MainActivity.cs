

using Android.Content.PM;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Com.Ntt.Skyway.Core;
using Com.Ntt.Skyway.Core.Content.Local;
using Com.Ntt.Skyway.Core.Content.Local.Source;
using Com.Ntt.Skyway.Core.Content.Sink;
using Com.Ntt.Skyway.Core.Util;
using Com.Ntt.Skyway.Room.Member;
using Com.Ntt.Skyway.Room.P2p;
using Kotlin.Coroutines;
using Skyway_videocall_android.module;

namespace Skyway_videocall_android
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private static String token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJhOGZmYTgzNy0xZmE4LTQyMWQtOWQyNy0xYWU5OTkzYzg1ZDYiLCJpYXQiOjE2OTgxMTAzMjQsImV4cCI6MTY5ODE5NjcyNCwic2NvcGUiOnsiYXBwIjp7ImlkIjoiYTI2MTU2ODUtMjBjNi00YmZiLWE3NTgtOGNjMTk5NjhiNzZhIiwidHVybiI6dHJ1ZSwiYWN0aW9ucyI6WyJyZWFkIl0sImNoYW5uZWxzIjpbeyJpZCI6IioiLCJuYW1lIjoiKiIsImFjdGlvbnMiOlsid3JpdGUiXSwibWVtYmVycyI6W3siaWQiOiIqIiwibmFtZSI6IioiLCJhY3Rpb25zIjpbIndyaXRlIl0sInB1YmxpY2F0aW9uIjp7ImFjdGlvbnMiOlsid3JpdGUiXX0sInN1YnNjcmlwdGlvbiI6eyJhY3Rpb25zIjpbIndyaXRlIl19fV0sInNmdUJvdHMiOlt7ImFjdGlvbnMiOlsid3JpdGUiXSwiZm9yd2FyZGluZ3MiOlt7ImFjdGlvbnMiOlsid3JpdGUiXX1dfV19XX19fQ.iBsFin-tAWpG70zrnmw2THO4HhHmF2jgwykDo0XH7iY";

        SkyWayContext.Options options = new SkyWayContext.Options(token, Logger.LogLevel.Info, false, true, null, null, null, null, null, null);
        Continuation continuation = new Continuation();
        P2PRoomManager p2PRoomManager = new P2PRoomManager();
        Boolean checkConnect = false;
        RoomMember.Init memberInit;
        LocalVideoStream? localVideoStream = null;
        LocalDataStream? localDataStream = null;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            CheckPermission();
            Task.Run(() =>
            {
                this.continuation.OnResumeWith += OnOnChanged_Continuation;
                var check1 = SkyWayContext.Setup(Application.Context, options, null, continuation);
                //if (check1.GetType()==typeof(SkyWayContext))
                //{                  
                p2PRoomManager.isSkywayContextSetup = true;
                Console.WriteLine("Err:" + check1);
            });
            Button CreatRoom = (Button)FindViewById(Resource.Id.btnJoinP2PRoom);
            CreatRoom.Click += (s, e) =>
            {
                CreateRoomP2p();

            };

        }

        private void CreateRoomP2p()
        {
            SurfaceViewRenderer surfaceViewRenderer = (SurfaceViewRenderer)FindViewById(Resource.Id.local_renderer);
            surfaceViewRenderer.Setup = true;
            if (checkConnect == true)
            {
                Object room = P2PRoom.FindOrCreate("ccj", null, continuation);
                Console.WriteLine(room.GetType());

            }

            //p2PRoomManager.localPerson = (LocalP2PRoomMember)p2PRoomManager.room.Join(memberInit, continuation);
            //Intent intent = new Intent(this, typeof(Activity1));
            //StartActivity(intent);
            CameraSource.CapturingOptions capturingOptions = new CameraSource.CapturingOptions(800, 800, 1);
            var device = CameraSource.GetFrontCameras(Application.ApplicationContext).First();
            CameraSource.StartCapturing(Application.ApplicationContext, device, capturingOptions);
            localVideoStream = CameraSource.Instance.CreateStream();
            // Render render = new Render();
            //  render.Setup = true;
            localVideoStream.AddRenderer(surfaceViewRenderer);
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

            public void ResumeWith(Java.Lang.Object result)
            {

                if (result.GetType() == typeof(P2PRoom))
                {
                    Console.WriteLine("");
                }
                if (OnResumeWith != null)
                {
                    this.OnResumeWith(this, result);
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
            // Console.WriteLine("CheckConnect:" + e);
            try
            {

                checkConnect = (bool)e;
                if (checkConnect == true)
                {
                    // Intent intent = new Intent(this, typeof(ActivityP2PRoom));
                    //StartActivity(intent

                }

            }
            catch (Exception ex)
            {

                try
                {
                    p2PRoomManager.room = (P2PRoom)e;
                    Console.WriteLine("dsd:" + p2PRoomManager.room);
                }
                catch (Exception ex2)
                {

                }

            }

        }
        public class RFender : Java.Lang.Object, IRenderer
        {
            public bool Setup
            {
                get => throw new NotImplementedException();
                set => throw new NotImplementedException();
            }
        }

    }

}