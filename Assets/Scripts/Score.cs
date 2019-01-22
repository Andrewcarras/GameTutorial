using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = player.position.z.ToString("0");
    }
}
