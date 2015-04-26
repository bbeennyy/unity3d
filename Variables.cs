using UnityEngine;
using System.Collections;


public class Variables:MonoBehavior{

    public float speed;             //can be accesed anywhere in this "project"
    public int myAge;
    public bool isCool = true;
    
    private float anyFloat = 23,5f; //can be accesed only in thise file
    
    void start(){
    
    //execute the code while game is starting
    isCool = false;
    
    }
    
    void update(){
    
    // execute the code while game is running
    
    }
}
