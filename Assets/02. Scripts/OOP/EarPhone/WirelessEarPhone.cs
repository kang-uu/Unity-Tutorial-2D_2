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
        string msg = isWirelessCharged ? "���� ����" : "���� ����";
        Debug.Log(msg);
        //if (isWirelessCharged)
        //    Debug.Log("���� ����");
        //else
        //    Debug.Log("���� ����");
    }
}
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    
    public void Charged()
    {
        string msg = isWirelessCharged ? "무선 충전" : "유선 충전";
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
