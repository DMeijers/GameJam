using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rb;

    private float horizontal = 0f;
    private float vertical = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }

    void FixedUpdate(){
        Vector3 origin = Vector3.zero;
        Quaternion hq = Quaternion.AngleAxis(-horizontal, Vector3.up);
        Quaternion vq = Quaternion.AngleAxis(vertical, Vector3.right);

        Quaternion q = hq * vq;

        rb.MovePosition(q * (rb.transform.position - origin) + origin);
        transform.LookAt(Vector3.zero);
    }
}
