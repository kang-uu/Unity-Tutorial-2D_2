using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public void Grab()
    {
        Debug.Log("손전등을 주웠다.");
        Destroy(gameObject);
    }

    public void Use()
    {
        Debug.Log("라이트를 켠다.");
    }

    public void Drop()
    {
        Debug.Log("손전등을 버렸다.");
    }
}