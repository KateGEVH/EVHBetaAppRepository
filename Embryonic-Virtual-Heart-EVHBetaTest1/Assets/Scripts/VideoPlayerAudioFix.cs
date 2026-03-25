using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

/// <summary>
/// Automatically fixes VideoPlayer audio on iOS for every scene.
/// No manual setup required — runs on app start and on every scene load.
/// 
/// Fixes two iOS-specific issues:
/// 1. VideoPlayer "Direct" audio mode doesn't work reliably on iOS — switches to AudioSource mode.
/// 2. iOS audio session defaults to "Ambient" which respects the silent switch — overrides to "Playback".
/// </summary>
public class VideoPlayerAudioFix
{
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void UnitySetAudioSessionCategory(int category);
#endif

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        SetIOSAudioSession();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private static void SetIOSAudioSession()
    {
#if UNITY_IOS && !UNITY_EDITOR
        // Category 1 = AVAudioSessionCategoryPlayback — ignores the silent switch
        try
        {
            UnitySetAudioSessionCategory(1);
        }
        catch (System.Exception e)
        {
            Debug.LogWarning("VideoPlayerAudioFix: Could not set iOS audio session: " + e.Message);
        }
#endif
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FixAllVideoPlayersInScene();
    }

    private static void FixAllVideoPlayersInScene()
    {
        VideoPlayer[] videoPlayers = Object.FindObjectsByType<VideoPlayer>(FindObjectsSortMode.None);
        foreach (VideoPlayer videoPlayer in videoPlayers)
        {
            bool wasPlaying = videoPlayer.isPlaying;

            // Stop playback so we can reconfigure audio
            if (wasPlaying)
                videoPlayer.Stop();

            // Ensure an AudioSource exists on the same GameObject
            AudioSource audioSource = videoPlayer.GetComponent<AudioSource>();
            if (audioSource == null)
                audioSource = videoPlayer.gameObject.AddComponent<AudioSource>();

            audioSource.playOnAwake = false;

            // Switch from Direct mode to AudioSource mode (Direct doesn't work on iOS)
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.SetTargetAudioSource(0, audioSource);

            // Restart if it was playing before we reconfigured
            if (wasPlaying)
                videoPlayer.Play();
        }
    }
}
