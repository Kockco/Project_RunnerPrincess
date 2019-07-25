using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D _rigid;
    Vector3 Movement;

    // Player Speed
    public int _speed;
    public int _savespeed;

    // Horizontal , Vertical
    float h;
    float v;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlayerRun();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Movement.Set(h, v, 0);
        Movement = Movement.normalized * _speed * Time.deltaTime;
        _rigid.MovePosition(_rigid.transform.position + Movement);
    }

    private void PlayerRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 2;            
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed = _savespeed;
        }        
    }

}
