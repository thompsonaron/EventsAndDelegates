using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += TurnRed;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        Main.onClick -= TurnRed;
    }
}
