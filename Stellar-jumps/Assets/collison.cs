using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static player_movement_namespace.PlayerMovement;

public class collison : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D col)
    {
        change_is_in_air();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
    }
}
