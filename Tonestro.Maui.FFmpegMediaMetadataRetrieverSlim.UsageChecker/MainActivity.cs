namespace Tonestro.Maui.FFMpegMediaMetadataRetrieverSlim.UsageChecker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        var textView = this.FindViewById<TextView>(Resource.Id.label);
        if (textView is null)
        {
            throw new NullReferenceException(nameof(textView));
        }

        try
        {
            const string videoUrl =
                "https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/1080/Big_Buck_Bunny_1080_10s_1MB.mp4";
            var duration = Com.Tonestro.Ffmpegmediametadataretrieverslim.FFmpegMediaMetadataRetrieverSlim
                .GetDurationInMs(videoUrl);
            textView.Text = $"Duration: {duration}";
        }
        catch (Exception e)
        {
            textView.Text = e.ToString();
        }
    }
}