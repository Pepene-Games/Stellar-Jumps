using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_character : MonoBehaviour
{
    public Transform target;
    public float FollowSpeed = 20f;

    void Start()
    {
        Vector3 newPos = new Vector3(0, 0, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
    void Update()
    {
        if (target.position.y > 0.0f) {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        } else {
            Vector3 newPos = new Vector3(target.position.x, 0, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        }
    }
}
