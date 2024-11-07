using Unity.VisualScripting;
using UnityEngine;

public class NudgeObject : MonoBehaviour
{
    [SerializeField]
    private float minScale = 0.05f;
    [SerializeField]
    private float maxScale = 1.15f;

    private int nudgeIndexStart = 1;
    private float nudgeAmount;

    private void Start()
    {
        ChangeNudgeAmount(nudgeIndexStart);
    }

    public void ChangeScale(float val)
    {
        float scale = Mathf.Lerp(minScale, maxScale, val);
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

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
        gameObject.transform.position += new Vector3(-nudgeAmount, 0, 0);
    }

    public void NudgeRight()
    {
        gameObject.transform.position += new Vector3(nudgeAmount, 0, 0);
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
