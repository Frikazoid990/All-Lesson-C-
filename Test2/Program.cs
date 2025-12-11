namespace Test2;

class Program
{
    static void Main(string[] args)
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;
        cts.Cancel();
        DoWork(token);
        Run();

    }

   static void DoWork(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                return;
            }
            Thread.Sleep(1000);
        }
    }
    public static async Task DownloadFileAsync(string url, CancellationToken token)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url, token);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("File downloaded.");
        }
    }
    
    public static async Task Run()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        try
        {
            Task downloadTask = DownloadFileAsync("https://example.com/file", cts.Token);
            // Simulate user cancellation
            cts.CancelAfter(3000); // Cancel after 3 seconds
            await downloadTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Download cancelled.");
        }
    }
    
    
}