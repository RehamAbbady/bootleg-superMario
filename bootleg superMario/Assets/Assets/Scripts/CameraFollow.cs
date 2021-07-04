using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float DistanceFromPlayer = 7.0f;
    

    public float  CameraY = 5.0f;
    Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //lerp interpolated between two points
        // transform.position = Vector3.Lerp(transform.position, TargetCamPos, smoothing * Time.deltaTime);

        //Moves the transform in the direction and distance of translation.
        cameraPosition.x = Target.position.x + 5;
        cameraPosition.z = Target.position.z - DistanceFromPlayer;
        //transform.Translate(Target.position.x, 0, Target.position.z-DistanceFromPlayer);
        transform.position=cameraPosition;
    }
    private void LateUpdate()
    {
        cameraPosition.y= CameraY;
        transform.position=cameraPosition;

    }
}
