using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float angle, rotationTime, radius;
    float speed;

    [SerializeField] Transform pivot, target;

    [SerializeField] Camera cam;
    [SerializeField] float zoomFOV = 40f;

    void Start()
    {
        cam.fieldOfView = zoomFOV;
    }

    void Update()
    {
        speed = (Mathf.PI * 2f) / rotationTime;
        angle += speed * Time.deltaTime;

        float x = Mathf.Sin(angle) * radius;
        float z = Mathf.Cos(angle) * radius;

        Vector3 offset = new Vector3(x, 0f, z);
        transform.position = pivot.position + offset;

        transform.LookAt(pivot.position);
    }
}