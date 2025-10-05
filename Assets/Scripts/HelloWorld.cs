using UnityEngine;
using UnityEngine.InputSystem;

public class HelloWorld : MonoBehaviour
{

    public float jumpForce = 5f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, GameDev!");
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody found on this GameObject. Please add a Rigidbody component.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
