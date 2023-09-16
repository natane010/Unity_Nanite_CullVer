using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LineCreater : MonoBehaviour
{
    [SerializeField] int count = 5;
    [SerializeField] GameObject go = null;

    //static List<GameObject> Test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [ContextMenu("Instance")]
    void Instance()
    {
        //Test = new List<GameObject>();
        Vector3 pos = Vector3.zero;
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < count; k++)
                {
                    pos = new Vector3(2 * i, 2 * j, 2 * k);
                    var ob = Instantiate(go, pos, Quaternion.identity);
                    ob.transform.parent = this.gameObject.transform;
                    //Test.Add(ob);
                }
            }
        }
    }
    //[ContextMenu("Delete")]
    //void Delete()
    //{
    //    foreach (var item in this.gameObject.transform.c())
    //    {
    //        Destroy(item);
    //    }
    //}
}
