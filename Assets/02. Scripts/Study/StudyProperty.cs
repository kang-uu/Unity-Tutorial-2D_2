using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    [Header("¼Óµµ")]
    [SerializeField] private float moveSpeed = 20f;

    [Space(10)]
    [Range(0f, 10f)]
    [SerializeField] private float MoveSpeed = 20f;

    //    private int number1 = 10;
    //    public int Number1
    //    {
    //        get { return number1; }
    //        set { number1 = value; }
    //    }
    //    public int Number2 { get; } = 20;

    //    public int Number3 { get; private set; } = 30;

    //    private float hp = 100f;
    //    public float Hp
    //    { get { return hp; } set {  hp = value; } }

    //    public void Hit(float damage)
    //    {
    //        Hp -= damage;
    //    }

    //    private void Start()
    //    {
    //        Number1 = 100;
    //        Number2 = 200;
    //        Number3 = 300;
    //    }
}
