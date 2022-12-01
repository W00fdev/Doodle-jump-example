using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.y < Target.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, Target.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}
