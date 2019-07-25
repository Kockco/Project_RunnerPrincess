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
        transform.Translate(new Vector3(h, v, 0));
    }

    private void PlayerRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed *= 2;
            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                _speed = 3;
            }
        }
        
    }

}
