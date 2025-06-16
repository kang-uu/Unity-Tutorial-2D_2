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

public class WirelessEarPhone : EarPhone
{
    public float batterySize;
    public bool isWirelessCharged;

<<<<<<< Updated upstream
    void Start()
=======
<<<<<<< HEAD
<<<<<<< HEAD
    private void Start()
=======
    void Start()
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
    void Start()
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    {
        name = "AirPod1";
        price = 100f;
        releaseYear = 2007;
        batterySize = 70f;
    }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
    public void Charged()
    {
        string msg = isWirelessCharged ? "¹«¼± ÃæÀü" : "À¯¼± ÃæÀü";
        Debug.Log(msg);
        //if (isWirelessCharged)
        //    Debug.Log("¹«¼± ÃæÀü");
        //else
        //    Debug.Log("À¯¼± ÃæÀü");
    }
}
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    
    public void Charged()
    {
        string msg = isWirelessCharged ? "ë¬´ì„  ì¶©ì „" : "ìœ ì„  ì¶©ì „";
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
