using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class Module : MonoBehaviour
{
    // 1. Клас Collider
    // 2. Дано вектор (4,-5,7) та (-2,0,6). Знайти та довжину їх суми.
    
    
    // 1. Клас Collider дозволяє дізнатись чи відбулось зіткнення між обʼєктами на сцені. Він має методи, які дозволяють 
    // дізнатись чи сталося зіткнення між обʼєктами та обробити цю подію. Також Collider дозволяє надати обʼєкту властивість 
    // тригеру
    // Start is called before the first frame update
    
    // 2. Дано вектор (4,-5,7) та (-2,0,6). Знайти та довжину їх суми.

    void Start()
    {
        GetVectorsSumaLength();
    }

    private void GetVectorsSumaLength()
    {
        Vector3 vector1 = new Vector3(4, -5, 7);
        Vector3 vector2 = new Vector3(-2, 0, 6);

        Vector3 sum = vector1 + vector2;

        Debug.Log($"Сума векторів: {sum}");
        Debug.Log($"Довжина суми векторів: {sum.Length()}");
    }
}
