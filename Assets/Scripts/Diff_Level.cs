using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public enum Difficulty_enum
    {
        easy = 0,
        medium = 1,
        hard = 2
    }

public class Diff_Level : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
public void changediff_easy(){

    Set_int(Difficulty_enum.easy);
   
}
public void changediff_medium(){
    Set_int(Difficulty_enum.medium);
}
 
public void changediff_hard(){

    Set_int(Difficulty_enum.hard);
}

 void Set_int(Difficulty_enum diff){
     
 PlayerPrefs.SetInt("difficulty",(int)diff );
 }

}
