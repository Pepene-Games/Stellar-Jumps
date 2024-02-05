using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

namespace player_movement_namespace {
    public class PlayerMovement : MonoBehaviour
    {
        public static int is_in_air = 0;
        public static int tramp_jump = 0;
        public Sprite Up;
        public Sprite Down;
        public Sprite Right;
        public Sprite Left;
        public float deplacement_speed_player;
        public float jump_speed_player;
        public float tramp_speed_player;
        private float speed = 0.1f;
        public static void change_is_in_air()
        {
            is_in_air = 0;
        }

        public static void change_tramp()
        {
            tramp_jump = 1;
        }
        public Rigidbody2D mrigidbody;
        void Update()
        {
            Vector3 move = transform.position;
            Quaternion rota = transform.rotation;
            rota.z = 0.0f;

            if (tramp_jump == 1)
            {
                GetComponent<SpriteRenderer>().sprite = Up;
                mrigidbody.velocity = Vector2.up * tramp_speed_player;
                tramp_jump = 0;
                is_in_air = 1;
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && is_in_air == 0)
            {
                GetComponent<SpriteRenderer>().sprite = Up;
                mrigidbody.velocity = Vector2.up * jump_speed_player;
                tramp_jump = 0;
                is_in_air = 1;
            }
            if (Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<SpriteRenderer>().sprite = Left;
                GetComponent<SpriteRenderer>().flipX = true;
                move.x -= speed * Time.deltaTime * deplacement_speed_player;
            }
            if (Input.GetKey(KeyCode.D) ||Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<SpriteRenderer>().sprite = Right;
                GetComponent<SpriteRenderer>().flipX = false;
                move.x += speed * Time.deltaTime * deplacement_speed_player;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                GetComponent<SpriteRenderer>().sprite = Down;
                move.x = -15.48f;
                is_in_air = 1;
                move.y = -2.364f;
            }
            transform.position = move;
            transform.rotation = rota;
        }
    }
}
