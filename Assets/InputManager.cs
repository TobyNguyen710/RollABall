using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        Vector3 inputVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector3.forward;
            Debug.Log("User Input: Forward (W)");
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector3.back;
            Debug.Log("User Input: Backward (S)");
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector3.left;
            Debug.Log("User Input: Left (A)");
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector3.right;
            Debug.Log("User Input: Right (D)");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            inputVector += Vector3.up;
            Debug.Log("User Input: Jump (Space)");
        }

        OnMove?.Invoke(inputVector);
    }
}
