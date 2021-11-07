﻿using RaceControl.Common.Enums;
using RaceControl.Core.Settings;
using RaceControl.Services.Interfaces.F1TV.Api;
using System.Collections.ObjectModel;

namespace RaceControl.Interfaces
{
    public interface IMediaPlayer
    {
        bool IsStarting { get; }

        bool IsStarted { get; }

        bool IsPlaying { get; }

        bool IsPaused { get; }

        bool IsRecording { get; }

        int MaxVolume { get; }

        int Volume { get; set; }

        bool IsMuted { get; }

        int Zoom { get; set; }

        VideoQuality VideoQuality { get; set; }

        ObservableCollection<IAspectRatio> AspectRatios { get; }

        ObservableCollection<IAudioDevice> AudioDevices { get; }

        ObservableCollection<IMediaTrack> AudioTracks { get; }

        IAspectRatio AspectRatio { get; set; }

        IAudioDevice AudioDevice { get; set; }

        IMediaTrack AudioTrack { get; set; }

        void StartPlayback(string streamUrl, bool isLive, PlayToken playToken, VideoDialogSettings settings);

        void StartRecording(string filename);

        void StopRecording();

        void TogglePause();

        void ToggleMute(bool? mute);

        long GetCurrentTime();

        void SetCurrentTime(long time);

        void FastForward(long seconds);
    }
}