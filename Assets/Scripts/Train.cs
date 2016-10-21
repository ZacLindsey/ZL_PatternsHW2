using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

	public void moveRight()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(1000.0f, 0.0f, 0.0f));
    }
    public void moveLeft()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-1000.0f, 0.0f, 0.0f));
    }
    public void stop()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }
    public void up()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 5.0f, 0.0f);
    }
    public void random()
    {
        int randomChoiceOfType = UnityEngine.Random.Range(0, 3);
        switch (randomChoiceOfType)
        {
            case 0:
                moveRight();
                break;
            case 1:
                moveLeft();
                break;
            case 2:
                stop();
                break;
            default:
                stop();
                break;
        }
    }
}
