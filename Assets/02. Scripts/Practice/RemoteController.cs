using UnityEngine;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;

    public bool isOn = false;
    
    public void OnScreenPower()
    {
        if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true; // 현재 티비 On
        }
        else
        {
            videoScreen.SetActive(false);
            isOn = false;
        }
    }
}