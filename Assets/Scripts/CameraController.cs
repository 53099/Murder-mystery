using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float angle, rotationTime, radius;
    float speed;
    [SerializeField] Transform pivot, target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = target.position - pivot.position;

        speed = (Mathf.PI * 2) / rotationTime;
        angle = Vector3.SignedAngle(targetDir, pivot.forward, Vector3.up); //speed * Time.deltaTime;
        angle *= Mathf.Deg2Rad;
        float x = Mathf.Sin(-angle) * radius;
        float z = Mathf.Cos(angle) * radius;

        transform.position = new Vector3(x, transform.position.y, z);
        transform.rotation = Quaternion.LookRotation(transform.position - pivot.position);

    }
}
