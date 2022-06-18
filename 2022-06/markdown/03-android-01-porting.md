### 3.1 .NET For Android Porting

<small>

*   porting

    *   Java and C# very similar, but

    *   Java idioms != C# idioms

```csharp
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
```
</small>