﻿using UnityEngine;
using System.Collections;

public class RightInvoker : MonoBehaviour {

    public GameObject clientHolder;
    public Commander1 client;
	void OnMouseDown()
    {
        Debug.Log("CLICKED");
        client = clientHolder.GetComponent<Commander1>();
        client.moveRightFunction();
    }
}
