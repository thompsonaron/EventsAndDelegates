using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += Fall;
    }
    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnDisable()
    {
        Main.onClick -= Fall;
    }
}
