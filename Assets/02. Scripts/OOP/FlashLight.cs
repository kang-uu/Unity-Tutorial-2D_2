using UnityEngine;

public class FlashLight : MonoBehaviour,IDropItem
{
    public void Grab()
    {
        Debug.Log("�������� �ֿ���.");
    }

    public void Use()
    {
        Debug.Log("�������� �Ҵ�.");
    }

    public void Drop()
    {
        Debug.Log("�������� ���ȴ�.");
    }
}
