using UnityEngine;

// Player
public class StudyOverloading : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Attack(true);

        Attack(false);

        Attack(10f);

        GameObject monsterObj = new GameObject("����");

        Attack(10, monsterObj);

    }


    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("���� ����");
        else
            Debug.Log("�⺻ ����");
    }

    public void Attack(float damage)
    {
        Debug.Log($"{damage} ������ ��ŭ ����");
    }

    public void Attack(float damage, GameObject target)
    {
        Debug.Log($"{target.name}���� {damage} ������ ��ŭ ����");
    }

}
