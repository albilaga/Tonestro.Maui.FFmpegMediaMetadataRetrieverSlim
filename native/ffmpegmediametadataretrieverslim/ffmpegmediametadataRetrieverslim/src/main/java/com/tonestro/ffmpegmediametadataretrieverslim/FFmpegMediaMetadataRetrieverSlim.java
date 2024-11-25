package com.tonestro.ffmpegmediametadataretrieverslim;

import wseemann.media.FFmpegMediaMetadataRetriever;

public class FFmpegMediaMetadataRetrieverSlim {
    public static long getDurationInMs(String videoUri) {
        FFmpegMediaMetadataRetriever retriever = new FFmpegMediaMetadataRetriever();
        retriever.setDataSource(videoUri);
        String duration = retriever.extractMetadata(FFmpegMediaMetadataRetriever.METADATA_KEY_DURATION);
        retriever.release();
        return Long.parseLong(duration);
    }
}
