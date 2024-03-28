using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 0f;
    [SerializeField]
    private float initialVelocity = 0f;
    [SerializeField]
    private float Y = -1f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ForceToAdd = new Vector2(0f, Y * acceleration * Time.deltaTime);

        ourRigidbody.AddForce(ForceToAdd);
    }
}