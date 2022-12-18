using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour
{
    public GameObject panel1;
    public GameObject Panel;
    public GameObject Canvas;
    public GameObject text;
    public int Size=80;
    public static panel pa ;
    

    GameObject Obj;
    
    // Start is called before the first frame update
    void Start()
    {
         if (pa == null)
        {
            pa = this;
        }

         Transform transform=this.transform;
         Vector3 pos= transform.position;
         Vector3 pos2=Canvas.transform.position;
         pos.x=pos2.x-Size;
        pos.y=pos2.y+Size;
        transform.position=pos;
        for(int n=0;n<3;n++){
          for(int i=0;i<3;i++){
           transform=this.transform;
           pos= transform.position;
             Obj = (GameObject)Instantiate (panel1, pos, Quaternion.identity);
             Obj.transform.SetParent (Panel.transform);
        
            

            pos.x+=Size;
            transform.position=pos;
            }
          pos.x-=Size*3;
          pos.y-=Size;
          transform.position=pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
