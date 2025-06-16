using JetBrains.Annotations;
using UnityEngine;

public class Monster : MonoBehaviour, IDamageable
{
    public float hp = 10f;
    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0f)
        {
            Death();
        }
    }
        public void Death()
        {
            Debug.Log("몬스터 다운");
        }


    
}
