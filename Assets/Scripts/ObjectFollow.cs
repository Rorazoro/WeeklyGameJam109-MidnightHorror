using UnityEngine;

public class ObjectFollow : MonoBehaviour {
    
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offsetOnRight;
    public Vector3 offsetOnLeft;

    public bool followOnY = true;

    private Vector3 desiredPosition;

    void FixedUpdate ()
    {
        if (target.position.x < transform.position.x)
        {
            desiredPosition = target.position + offsetOnRight;
        } else
        {
            desiredPosition = target.position + offsetOnLeft;
        }
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        if (followOnY)
        {
            transform.position = smoothedPosition;
        } else
        {
            transform.position = new Vector3(smoothedPosition.x, transform.position.y, smoothedPosition.z);
        }
        
    }

}
