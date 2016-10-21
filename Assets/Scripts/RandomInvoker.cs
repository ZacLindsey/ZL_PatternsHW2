using UnityEngine;
using System.Collections;

public class RandomInvoker : MonoBehaviour {

    public GameObject clientHolder;
    public Commander1 client;
	void OnMouseDown()
    {
        Debug.Log("CLICKED");
        client = clientHolder.GetComponent<Commander1>();
        client.randomFunction();
    }
}
