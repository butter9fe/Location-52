using Common.DesignPatterns;
using Environment;
using Mobs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters.Player
{
    /// <summary>
    /// This class is the container storing all the individual components of the player character
    /// </summary>
    public class PlayerManager : SingletonPersistent<PlayerManager>
    {
        #region movement and controls

        // Movement and Camera
        public PlayerMovement Movement;
        public PlayerCamera Camera;
        public AudioDistractionCue PlayerNoiseLevel;
        public PlayerHealth Health;

        #endregion

        #region Aesthetics and miscellaneous

        public PlayerArms Arms;

        #endregion

        public SpawnPointID CurrentSpawnPointID;

        // Start is called before the first frame update
        void Start()
        {

        }

        
    }
}
