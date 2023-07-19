using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static Util;

public class Define
{
    public enum Scene
    {
        Unknown,
        TitleScene,
        LobbyScene,
        GameScene,
    }

    public enum Sound
    {
        Bgm,
        SubBgm,
        Effect,
        Max,
    }

    public enum UIEvent
    {
        Click,
        Pressed,
        PoinerDown,
        PoinerUp,
        BeginDrag,
        Drag,
        EndDrag,
    }

    public enum ObjectType
    {
        Player,
        Monster,
    }
}
