using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        text.text = player.position.z.ToString("0");
    }
}
