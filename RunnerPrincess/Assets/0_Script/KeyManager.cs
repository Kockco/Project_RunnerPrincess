using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private static KeyManager _instance;
    public static KeyManager Instance { get { return _instance; } }

    private void Awake()
    {
        _instance = this;
    }

    public KeyCode Up = KeyCode.W;
    public KeyCode Left = KeyCode.A;
    public KeyCode Down = KeyCode.S;
    public KeyCode Right = KeyCode.D;



}
