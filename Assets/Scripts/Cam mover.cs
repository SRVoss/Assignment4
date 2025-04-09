using UnityEngine;

public class Cammover : MonoBehaviour
{
    public Transform cameraPosition;
   
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
