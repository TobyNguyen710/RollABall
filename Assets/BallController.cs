using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float ballJumpForce = 0.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveBall(Vector3 inputVector)
    {
        Vector3 inputXZPlane = new Vector3(0, inputVector.y * ballJumpForce, 0);
        Vector3 inputXZPlaneJump = new Vector3(inputVector.x, 0, inputVector.z);
        
        // Debug.Log("Resultant Vector: " + inputVector);
        // Debug.Log("Resultant 3D Vector: " + inputVector);
        if(IsGrounded())
        {
            sphereRigidbody.AddForce(inputXZPlane * ballSpeed, ForceMode.Impulse);
            sphereRigidbody.AddForce(inputXZPlaneJump * ballSpeed);
        }
        else
        {
            sphereRigidbody.AddForce(inputXZPlaneJump * ballSpeed);
        }
    }
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.51f);
    }
}
