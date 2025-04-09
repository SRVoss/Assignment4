using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDircetion;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }
    private void MovePlayer()
    {
        //Cam Movement direction
        moveDircetion = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDircetion.normalized * moveSpeed * 5f, ForceMode.Force);
    }

}
