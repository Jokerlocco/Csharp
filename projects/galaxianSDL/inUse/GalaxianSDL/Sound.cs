
// Sound.cs - A simple sound player using SdlMixer

// Version + Date   Author + Changes
// --------------   --------------------------------------
// 030, 15-May-19   Nacho: First version

using System;
using Tao.Sdl;

public class Sound
{

    private IntPtr internalPointer;

    public Sound(string fileName)
    {
        internalPointer = SdlMixer.Mix_LoadMUS(fileName);
    }

    // To play a song at a particular time
    public void PlayOnce()
    {
        SdlMixer.Mix_PlayMusic(internalPointer, 1);
    }

    // To continuously play song (background music)
    public void BackgroundPlay()
    {
        SdlMixer.Mix_PlayMusic(internalPointer, -1);
    }

    // To stop the music
    public void StopMusic()
    {
        SdlMixer.Mix_HaltMusic();
    }

}
