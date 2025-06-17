using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;
    public bool isLight = false;
    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
       


        Debug.Log("손전등을 주웠다.");
    }


    public void Use()
    {
        if (isLight)
        {
            lightObj.SetActive(false);
        }
        else
        {
            lightObj.SetActive(true); 
        }

        // lightObj.SetActive(!lightObj.activeSelf);

    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.position = Vector3.zero;
    }
}
