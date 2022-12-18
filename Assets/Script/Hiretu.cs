using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hiretu : MonoBehaviour
{
    static public GameObject[] piece=new GameObject[9];
    public GameObject[] piec=new GameObject[9];
    public GameObject Canvas;
     public GameObject Panel;
    public static Hiretu hi ;

    GameObject Obj;
    
 
    void Start()
    {
        if (hi == null)
        {
            hi = this;
        }

        Vector3 pos2=Canvas.transform.position;
        
        for (int i=0;i<9;i++){
            float x = Random.Range(pos2.x-200,pos2.x+200);
            float y = Random.Range(pos2.y-100, (pos2.y+100));
            Vector3 pos = new Vector3(x, y, 0.0f);
            Obj=(GameObject)Instantiate(piec[i], pos, Quaternion.identity);
            Obj.transform.SetParent (Panel.transform);
            piec[i]=piece[i];
        }
    }


    // Update is called once per frame
    void Update()
    {
        

        
    }

   
}
