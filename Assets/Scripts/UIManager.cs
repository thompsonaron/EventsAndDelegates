using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void UpdateHealth(int health)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Current health: ");
        sb.Append(health);

        Debug.Log(sb.ToString());
    }

    private void OnEnable()
    {
        Player.OnDamageReceived += UpdateHealth;
    }
}
