using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender
{
    public enum GameTags
    {
        None,
        Player,
        Enemy,
        Laser,
        DeadZone
    }
    public enum GameStatus
    {
        Menu,
        Playing,
        GameOver
    }
}