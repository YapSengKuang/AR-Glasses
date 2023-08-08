using UnityEngine;
using Vuforia;

public class ImageTargetBehaviour : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;
    public GameObject model; // The 3D model that will be displayed when the image is recognized

    void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (trackableBehaviour)
        {
            trackableBehaviour.RegisterTrackableEventHandler(this);
        }

        if (model)
        {
            model.SetActive(false); // Initially, the model should be disabled
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // The image is recognized, so we enable the model
            if (model)
            {
                model.SetActive(true);
            }
        }
        else
        {
            // The image is lost, so we disable the model
            if (model)
            {
                model.SetActive(false);
            }
        }
    }
}