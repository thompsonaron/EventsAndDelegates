using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;

    public void UpdateDeathCount()
    {
        StringBuilder sb = new StringBuilder();
        deathCount++;
        sb.Append("Death Count: ");
        sb.Append(deathCount);
        deathCountText.text = sb.ToString();
    }

    public void OnEnable()
    {
        Player.onDeath += UpdateDeathCount;
    }

    private void OnDisable()
    {
        Player.onDeath -= UpdateDeathCount;
    }
}
