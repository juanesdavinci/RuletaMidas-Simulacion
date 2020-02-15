using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour
{

    [Range(0, 100)] public float rpm;

    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hertz = 1 / rpm;

        float angles = 360 * Time.deltaTime * hertz;

        transform.Rotate(rotation * angles);
    }
}
