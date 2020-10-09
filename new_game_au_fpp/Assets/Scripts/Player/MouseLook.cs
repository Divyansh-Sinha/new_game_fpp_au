<<<<<<< HEAD:new_game_au_fpp/Assets/Scripts/Player/MouseLook.cs
﻿using UnityEngine;
using Mirror;
=======
﻿using Mirror;
using UnityEngine;
>>>>>>> 4441c97dca05073d7e73775ea9cfe6113089a334:new_game_au_fpp/Assets/Scripts/MouseLook.cs

public class MouseLook : NetworkBehaviour
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
    public override void OnStartAuthority()
    {
        camera_transfrom.gameObject.SetActive(true);
        
        enabled = true;
    }
    private void Update()
    {
        if (!isLocalPlayer) { return; }

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
