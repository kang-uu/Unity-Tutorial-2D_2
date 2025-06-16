<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;

public class TownGuard : MonoBehaviour,IAttack
{
    public float hp;
    public float speed = 10f;
    public void Move()
    {
        Debug.Log("Move");
        transform.position += transform.right * speed * Time.deltaTime;
        transform.position = Vector3.fwd * speed * Time.deltaTime;
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
﻿using UnityEngine;

public class TownGuard : NPC, IMove, IAttack
{
    public void Move()
    {
        
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
    }

    public void Attack()
    {
<<<<<<< Updated upstream
        
    }
}
=======
<<<<<<< HEAD
<<<<<<< HEAD
        Debug.Log("Attack");
    }
}
=======
        
    }
}
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
=======
        
    }
}
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
