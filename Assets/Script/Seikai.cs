using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seikai : MonoBehaviour
{
    public InputField inputField;
    public Text text;
     int [] flag =new int [9];
    string seikai="正解!";
    string  no="不正解~";
    GameObject clickedGameObject;
    GameObject[] a=new GameObject[9];
    int k;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<9;i++)
            flag[i] =0;
        inputField = inputField.GetComponent<InputField> ();
        text = text.GetComponent<Text> ();
        for (int i=0;i<9;i++){
            a[i]=Hiretu.piece[i];
        }
    }
    
    // Update is called once per frame
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {

                clickedGameObject = hit.collider.gameObject;


            }
        }

    }

public void InputText(){
         
       
        k=int.Parse(inputField.text);

}

     public void setText(){
         
       
        k=int.Parse(inputField.text);

        if(a[k]==clickedGameObject&&flag [k]!=1){
            text.text = seikai;
            flag [k]=1;
           Vector3 Pos=Hiretu.piece[k].transform.position;
           Pos.x=-80.0f;
           Pos.y=80.0f;
           Hiretu.piece[k].transform.position=Pos;
           
        }
        else if (Hiretu.piece[k]!=clickedGameObject)
            text.text = no;
        else if(flag[k]==0)
            text.text = "それはもう答えたよ";
        else
            text.text="0~8の数字を入れてね";
        

        
    }
}
