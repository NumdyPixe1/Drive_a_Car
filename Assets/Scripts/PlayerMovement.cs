using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float movespeed = 10f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0f).normalized;
        controller.Move(direction * movespeed * Time.deltaTime);
    }
}
