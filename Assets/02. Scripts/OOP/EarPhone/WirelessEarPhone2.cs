<<<<<<< Updated upstream
ï»¿using UnityEngine;
=======
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;
=======
ï»¿using UnityEngine;
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
ï»¿using UnityEngine;
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes

public class WirelessEarPhone2 : WirelessEarPhone
{
    public bool isNoiseCancelling;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
    private void Start()
    {
        name = "AirPod2";
        price = 150f;
        releaseYear = 2012;
        batterySize = 100f;
    }
    public virtual void NoiseCancelling()
    {
        isNoiseCancelling = !isNoiseCancelling;

        string msg = isNoiseCancelling ? "³ëÀÌÁî Äµ½½¸µ  On" : "³ëÀÌÁî Äµ½½¸µ Off";
        Debug.Log(msg);
    }
}
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes

    void Start()
    {
        name = "AirPod2";
        price = 150f;
        releaseYear = 2010;
        batterySize = 100f;
    }
    
    public virtual void NoiseCancelling()
    {
        isNoiseCancelling = !isNoiseCancelling;
        
        string msg = isNoiseCancelling ? "ë…¸ì´ì¦ˆ ìº”ìŠ¬ë§ On" : "ë…¸ì´ì¦ˆ ìº”ìŠ¬ë§ Off";
        Debug.Log(msg);
    }
<<<<<<< Updated upstream
}
=======
<<<<<<< HEAD
}
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
}
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
