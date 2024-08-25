using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float srafeSpeed = 5f;
    public float boundaryX = 10f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // простое перемещение вперед
        Vector3 forwardMovement = Vector3.forward * moveSpeed * Time.deltaTime;

        float hotizontalInput = Input.GetAxis("Horizontal");
        Vector3 strafeMovement = Vector3.right * hotizontalInput * srafeSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + forwardMovement + strafeMovement);

        rb.position = new Vector3(Mathf.Clamp(rb.position.x, -boundaryX, boundaryX), rb.position.y, rb.position.z);
    }
}
