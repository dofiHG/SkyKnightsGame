using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CleverEnemyMover : MonoBehaviour
{
    private float speed = 2f;
    private Transform player;

    public int direction;

    void Start() => player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    private void Update()
    {
        if(Math.Abs(transform.position.x - player.transform.position.x) <= 8) { Move(); }
        else { gameObject.GetComponent<Animator>().SetBool("Walk", false); }
    }

    private void Move()
    {
        gameObject.GetComponent<Animator>().SetBool("Walk", true);
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if (transform.position.x >= player.position.x) { gameObject.GetComponent<SpriteRenderer>().flipX = true; direction = -1; }
        else { gameObject.GetComponent<SpriteRenderer>().flipX = false; direction = 1; }
    }
}
