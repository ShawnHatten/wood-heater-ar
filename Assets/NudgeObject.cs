using UnityEngine;

public class NudgeObject : MonoBehaviour
{
    private float nudgeAmount = 0.01f;


    public void ChangeNudgeAmount(int val)
    {
        if (val == 0)
        {
            nudgeAmount = 0.1f;
        }
        else if (val == 1)
        {
            nudgeAmount = 0.01f;
        }
        else if (val == 2)
        {
            nudgeAmount = 0.001f;
        }
    }

    public void NudgeLeft()
    {
        gameObject.transform.position += new Vector3(nudgeAmount, 0, 0);
    }

    public void NudgeRight()
    {
        gameObject.transform.position += new Vector3(-nudgeAmount, 0, 0);
    }

    public void NudgeIn()
    {
        gameObject.transform.position += new Vector3(0, 0, nudgeAmount);
    }

    public void NudgeOut()
    {
        gameObject.transform.position += new Vector3(0, 0, -nudgeAmount);
    }
}
