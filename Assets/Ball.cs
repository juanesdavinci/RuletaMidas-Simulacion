using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Ball : MonoBehaviour
{

    [Range(0, 100000)] public float InitialSpeed;
    public Rigidbody rb;
    public float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
        StartCoroutine(startForce());

    }

    private IEnumerator startForce()
    {
        yield return new WaitForSeconds(1);
        rb.isKinematic = false;
        GetComponent<Rigidbody>().AddRelativeForce(transform.right * InitialSpeed);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position,transform.right);
    }

    private void FixedUpdate3()
    {
        angle = Mathf.Atan(transform.position.x / transform.position.y);
        angle += Mathf.PI / 2;
        GetComponent<Rigidbody>().AddRelativeForce(transform.right * InitialSpeed);
    }
}
