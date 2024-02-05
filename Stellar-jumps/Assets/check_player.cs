using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static player_movement_namespace.PlayerMovement;

public class TrapScript : MonoBehaviour
{
    public Animator trapAnimator;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") {
            trapAnimator.SetTrigger("trap");
            change_tramp();
        }
    }

}

