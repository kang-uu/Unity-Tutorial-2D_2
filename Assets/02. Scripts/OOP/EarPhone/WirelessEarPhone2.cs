<<<<<<< Updated upstream
﻿using UnityEngine;
=======
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
﻿using UnityEngine;
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

        string msg = isNoiseCancelling ? "������ ĵ����  On" : "������ ĵ���� Off";
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
        
        string msg = isNoiseCancelling ? "노이즈 캔슬링 On" : "노이즈 캔슬링 Off";
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
