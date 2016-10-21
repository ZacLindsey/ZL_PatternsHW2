using UnityEngine;
using System.Collections;

//get train instance
public abstract class Command
{
    public abstract void execute();
}

public class MoveRightCommand : Command
{
    public override void execute()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Train>().moveRight();
    }
}

public class MoveLeftCommand : Command
{
    public override void execute()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Train>().moveLeft();
    }
}

public class StopCommand : Command
{
    public override void execute()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Train>().stop();
    }
}

public class RandomCommand : Command
{
    public override void execute()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Train>().random();
    }
}

public class UpCommand : Command
{
    public override void execute()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Train>().up();
    }
}

public class Commander1 : MonoBehaviour
{
    Command moveRight, moveLeft, stop, random, up;
    Commander1()
    {
        moveRight = new MoveRightCommand();
        moveLeft = new MoveLeftCommand();
        stop = new StopCommand();
        random = new RandomCommand();
        up = new UpCommand();
    }
    public void moveRightFunction()
    {
        moveRight.execute();
    }
    public void moveLeftFunction()
    {
        moveLeft.execute();
    }
    public void stopFunction()
    {
        stop.execute();
    }
    public void randomFunction()
    {
        random.execute();
    }
    public void upFunction()
    {
        up.execute();
    }
}

