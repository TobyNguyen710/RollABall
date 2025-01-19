using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveBall(Vector2 inputVector)
    {
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputVector);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
