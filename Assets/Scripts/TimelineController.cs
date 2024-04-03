using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    private PlayableDirector director;
    [SerializeField] PathFollower cameraPathScript;
    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        director.played += DirectorPlayed;
        director.stopped += DirectorStopped;
        
    }

    private void DirectorPlayed(PlayableDirector obj)
    {
        cameraPathScript.enabled = false;
    }
    
    private void DirectorStopped(PlayableDirector obj)
    {
        cameraPathScript.enabled = true;
    }

    
}
