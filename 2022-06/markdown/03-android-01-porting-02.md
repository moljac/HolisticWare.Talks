### 3.1 .NET For Android Porting

<small>

real world porting

```csharp
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
```
</small>