<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine;

public class TownPerson : MonoBehaviour,ITalk
{
    public float hp;
    public float speed;

    public void Move()
    {
        Debug.Log("Move");
        transform.position += transform.right * speed * Time.deltaTime;
    }
    
    public void Talk()
    {
        Debug.Log("Talk");
    }

    private void Update()
    {
        Move();
    }
}
=======
=======
>>>>>>> 23284bc4e9dbe30272a606d42cd2bef75a652015
>>>>>>> Stashed changes
﻿using UnityEngine;

public class TownPerson : NPC, IMove, ITalk
{
    public void Move()
    {
        
    }

    public void Talk()
    {
        
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
