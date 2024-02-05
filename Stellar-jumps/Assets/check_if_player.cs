using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_if_player : MonoBehaviour
{    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") {
            Application.Quit();
        }
    }
}
