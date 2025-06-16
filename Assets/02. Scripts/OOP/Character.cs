using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public IDropItem currentItem;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentItem.Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<IDropItem>() != null)
        {
            IDropItem item = other.GetComponent<IDropItem>();

            item.Grap();

            currentItem = item;
        }
    }
}




    //private void Update()
    //{
    //    Move();
    //}
    //public virtual void Attack()
    //{
    //    Debug.Log("����1");
    //    Debug.Log("����2");
    //    Debug.Log("����3");
    //    Debug.Log("����4");
    //    Debug.Log("����5");
    //}

    //public virtual void Move()
    //{
    //    Debug.Log("�̵�1");        // NPC ���� ����� �ȹޱ� ������ �״�� �� �ڵ带 ���� ��Ű�� �ȴ�.
    //    Debug.Log("�̵�1");
    //    Debug.Log("�̵�1");
    //    Debug.Log("�̵�1");
    //    Debug.Log("�̵�1");
    //}
}
