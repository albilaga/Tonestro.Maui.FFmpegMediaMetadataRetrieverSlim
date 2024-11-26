package com.tonestro.ffmpegmediametadataretrieverslim;

import wseemann.media.FFmpegMediaMetadataRetriever;

public class FFmpegMediaMetadataRetrieverSlim {
    public static long getDurationInMs(String videoUri) {
        FFmpegMediaMetadataRetriever retriever = new FFmpegMediaMetadataRetriever();
        long durationInMs;
        try {
            retriever.setDataSource(videoUri);
            String duration = retriever.extractMetadata(FFmpegMediaMetadataRetriever.METADATA_KEY_DURATION);
            durationInMs = Long.parseLong(duration);
        } finally {
            retriever.release();
        }
        return durationInMs;
    }
}
