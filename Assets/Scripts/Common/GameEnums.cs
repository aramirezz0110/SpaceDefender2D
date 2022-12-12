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
        Collectable
    }
    public enum GameStatus
    {
        Menu,
        Playing,
        GameOver
    }
    public enum Direction 
    {
        None, 
        Left,
        Right,
        Up,
        Down
    }
}