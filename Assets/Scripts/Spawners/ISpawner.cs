using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceDefender.Spawning
{    
    public interface ISpawner
    {
        public void StartSpawning();
        public void StopSpawning();
    }
}
