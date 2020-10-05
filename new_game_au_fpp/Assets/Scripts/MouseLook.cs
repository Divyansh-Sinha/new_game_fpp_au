using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] Transform camera_transfrom;
    public float mouse_sensitivity = 100f;

    float yRotation = 0.0f;

    [Header("For Camera Ease")]
    [SerializeField] Transform eye_transform;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        mouse_look();
        camera_ease();
    }
    void mouse_look()
    {
        float Mousex = Input.GetAxis("Mouse X") * mouse_sensitivity * Time.deltaTime;
        float Mousey = Input.GetAxis("Mouse Y") * mouse_sensitivity * Time.deltaTime;

        yRotation -= Mousey;
        yRotation = Mathf.Clamp(yRotation, -65f, 75f);

        camera_transfrom.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        this.gameObject.transform.Rotate(Vector3.up * Mousex);
    }
    void camera_ease()
    {
        camera_transfrom.position = Vector3.Lerp(camera_transfrom.position, eye_transform.position, 1.0f);
    }
}
