using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform mPlayer;

    void Start()
    {
        mPlayer = GameObject.FindObjectOfType<PlayerBehaviour>().gameObject.transform;
    }

    void Update()
    {
        transform.position = mPlayer.transform.position + new Vector3(0.0f, 0.0f, -10.0f);
    }
}
