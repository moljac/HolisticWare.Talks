using Java.Interop;


namespace AppAndroid;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    static TextView? text_view_response;
    static string url = "https://api.github.com/orgs/dotnet/repos";
    private static readonly HttpClient client = new HttpClient();

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);

        /*
        https://docs.microsoft.com/en-us/dotnet/csharp/nullable-warnings

        add "!" to suppress

        warning CS8600: Converting null literal or possible null value to non-nullable type.            
        warning CS8602: Dereference of a possibly null reference.
        */

        text_view_response = this.FindViewById<TextView>(Resource.Id.text_view_response);

        Button? button_http_request_dotnet = this.FindViewById<Button>(Resource.Id.button_http_request_dotnet);
        button_http_request_dotnet!.Click += async (s,e)=>
                                            {
                                                text_view_response!.Text = "here be .NET HtttpClient response";

                                                client.DefaultRequestHeaders.Accept.Clear();
                                                client.DefaultRequestHeaders.Accept
                                                    .Add
                                                        (
                                                            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
                                                        );
                                                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                                                Task<string> stringTask = client.GetStringAsync(url);

                                                var msg = await stringTask; // add async

                                                Console.Write(msg);

                                                text_view_response.Text = msg;
                                            };        

        Button? button_http_request_android = this.FindViewById<Button>(Resource.Id.button_http_request_android);
        button_http_request_android!.SetOnClickListener( new ButttonClickListener()) ; 

        return;
    }

    public class ButttonClickListener : Java.Lang.Object, Android.Views.View.IOnClickListener
    {
        public void OnClick(Android.Views.View? v)
        {
            MainActivity.text_view_response!.Text = "Here be Android response";

            // Volley.ICache cache = new Volley.Toolbox.NoCache();

            // // Set up the network to use HttpURLConnection as the HTTP client.
            // Volley.Toolbox.BasicNetwork? network = new Volley.Toolbox.BasicNetwork(new Volley.Toolbox.HurlStack());

            // // Instantiate the RequestQueue with the cache and network.
            // Volley.RequestQueue queue = new Volley.RequestQueue(cache, network);

            // // Request a string response from the provided URL.
            // var stringRequest = new Volley.Toolbox.StringRequest
            //                                             (
            //                                                 url,
            //                                                 new VolleyResponseListener(),
            //                                                 new VolleyErrorListener()
            //                                             );

            // // Add the request to the RequestQueue.
            // queue.Add(stringRequest);

               Square.OkHttp.OkHttpClient client = new Square.OkHttp.OkHttpClient();

                // Create request for remote resource.
                Square.OkHttp.Request request = new Square.OkHttp.Request
                                                                    .Builder()
                                                                    .Url(url)
                                                                    .Build();

                // Execute the request and retrieve the response.
                Square.OkHttp.Response response = client.NewCall(request).Execute();

                // Deserialize HTTP response to concrete type.
				string body = response.Body().String();

                MainActivity.text_view_response!.Text = body;
                
            return;
        }
    }

    public class VolleyResponseListener : Java.Lang.Object, Volley.Response.IListener
    {
        public IntPtr Handle => throw new NotImplementedException();

        public int JniIdentityHashCode => throw new NotImplementedException();

        public JniObjectReference PeerReference => throw new NotImplementedException();

        public JniPeerMembers JniPeerMembers => throw new NotImplementedException();

        public JniManagedPeerStates JniManagedPeerState => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public void OnResponse(Java.Lang.Object p0)
        {
            text_view_response!.Text = (string) p0;
        }

        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }
    }

    public class VolleyErrorListener : Java.Lang.Object, Volley.Response.IErrorListener
    {
        public IntPtr Handle => throw new NotImplementedException();

        public int JniIdentityHashCode => throw new NotImplementedException();

        public JniObjectReference PeerReference => throw new NotImplementedException();

        public JniPeerMembers JniPeerMembers => throw new NotImplementedException();

        public JniManagedPeerStates JniManagedPeerState => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public void OnErrorResponse(Volley.VolleyError p0)
        {
            text_view_response.Text = "Volley Error";

            return;
        }

        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }
    }
}