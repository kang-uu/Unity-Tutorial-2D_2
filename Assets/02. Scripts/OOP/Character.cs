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
    //    Debug.Log("공격1");
    //    Debug.Log("공격2");
    //    Debug.Log("공격3");
    //    Debug.Log("공격4");
    //    Debug.Log("공격5");
    //}

    //public virtual void Move()
    //{
    //    Debug.Log("이동1");        // NPC 등은 상속을 안받기 때문에 그대로 이 코드를 실행 시키면 된다.
    //    Debug.Log("이동1");
    //    Debug.Log("이동1");
    //    Debug.Log("이동1");
    //    Debug.Log("이동1");
    //}
}
