using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] Animator player_anim;
    [SerializeField] float character_mov_speeed_fwd = 20f;
    [SerializeField] float character_mov_speed_sidew = 5f;

    private void Update()
    {
        movement();
        apply_animation();
    }
    void movement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x * character_mov_speed_sidew + transform.forward * z * character_mov_speeed_fwd;

        controller.Move(move * Time.deltaTime);
    }
    void apply_animation()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        player_anim.SetFloat("Input X", inputX);
        player_anim.SetFloat("Input Y", inputY);
    }
}
