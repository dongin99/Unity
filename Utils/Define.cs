using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Layer
    {
        Monster = 3,
        Ground = 6,
        Block = 7,
    }
    public enum Scene
    {
        Unknown,
        LogIn,
        Lobby,
        Game,
    }
    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount,
    }
    public enum UIEvent
    {
        Click,
        Drag,
    }
    public enum MouseEvent
    {
        Click,
        Press
    }
    public enum CameraMode
    {
        QuarterView,

    }

    
}
