<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;

public class WirelessEarPhone3 : WirelessEarPhone2
{
    public enum NoiseCancelType {  off,On,Around}
    public NoiseCancelType noiseCancelType;
    private void Start()
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
﻿using UnityEngine;

public class WirelessEarPhone3 : WirelessEarPhone2
{
    public enum NoiseCancelType { Off, On, Around}
    public NoiseCancelType noiseCancelType;

    void Start()
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    {
        name = "AirPodPro2";
        price = 300f;
        releaseYear = 2015;
        batterySize = 150f;
    }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
    public void SetNoiseCancelType(NoiseCancelType type)
    { 
        noiseCancelType = type;
    }

    public override void NoiseCancelling()
    {
        SetNoiseCancelType(noiseCancelType);

        base.NoiseCancelling();
    }
}
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    
    public void SetNoiseCancelType(NoiseCancelType type)
    {
        noiseCancelType = type;
    }
    
    public override void NoiseCancelling()
    {
        SetNoiseCancelType(noiseCancelType);
        
        base.NoiseCancelling();
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
