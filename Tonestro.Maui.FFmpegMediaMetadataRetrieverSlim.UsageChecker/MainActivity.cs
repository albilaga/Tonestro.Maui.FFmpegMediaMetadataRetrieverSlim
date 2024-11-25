namespace Tonestro.Maui.FFMpegMediaMetadataRetrieverSlim.UsageChecker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        var duration = Com.Tonestro.Ffmpegmediametadataretrieverslim.FFmpegMediaMetadataRetrieverSlim.GetDurationInMs(
            "https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/1080/Big_Buck_Bunny_1080_10s_1MB.mp4");
        Console.WriteLine($"This video duration is {duration} ms");
    }
}