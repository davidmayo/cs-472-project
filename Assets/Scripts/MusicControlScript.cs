using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControlScript : MonoBehaviour
{
    public static MusicControlScript instance; // Creates a static varible for a MusicControlScript instance

    private void Awake() // Runs before void Start()
    {
        DontDestroyOnLoad(this.gameObject); // Don't destroy this gameObject when loading different scenes

        if (instance == null) // If the MusicControlScript instance variable is null
        {
            instance = this; // Set this object as the instance
        }
        else // If there is already a MusicControlScript instance active
        {
            Destroy(gameObject); // Destroy this gameObject
        }
    }
}
// All of this is to ensure that the game object using the music is not destroyed between scences 
// AND that it is not duplicated when it is reload
