using UnityEngine;

public class PlayerMovementRB : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        movement = new Vector3(Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        
    }
}

