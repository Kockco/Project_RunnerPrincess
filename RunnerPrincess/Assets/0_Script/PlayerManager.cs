using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D _rigid;

    // Player Speed
    public int _speed;

    // Horizontal , Vertical
    float h;
    float v;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlayerMove();
        PlayerRun();
    }

    private void PlayerMove()
    {
        h = Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime;
        v = Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime;
        _rigid.velocity = Vector2.zero;
        _rigid.AddForce(Vector3.zero * h * _speed * Time.deltaTime);
    }

    private void PlayerRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 2;            
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed = 3;
        }
        
    }

}
