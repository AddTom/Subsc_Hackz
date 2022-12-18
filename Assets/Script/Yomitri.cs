using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Windows.Forms;
using System.IO;

public class Yomitri : MonoBehaviour
{

    public static string   path;
    public static Yomitri yo ;

    // Start is called before the first frame update
    void Start()
    {
         if (yo == null)
        {
            yo = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        OpenFileDialog open_file_dialog = new OpenFileDialog();
         open_file_dialog.Filter = "画像ファイル|*.jpg;*.png*.gif;";
        open_file_dialog.ShowDialog();
        path = open_file_dialog.FileName;
        


    }
    

}
