using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playertransform ;
    public float offset ;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 camerapos = transform.position ;
        camerapos.z = playertransform.position.z + offset ;
        transform.position = camerapos ;
    }
}
