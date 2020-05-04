using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private void Start()
    {
        Main.onTeleport += ChangePosition;
    }

    public void ChangePosition(Vector3 pos)
    {
        this.transform.position = pos;
    }

    // It is IMPORTANT to DEREGISTER the methods that register
    private void OnDisable()
    {
        Main.onTeleport -= ChangePosition;
    }
}
