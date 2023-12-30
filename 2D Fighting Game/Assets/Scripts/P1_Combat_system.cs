using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public static CombatManager instance;

    private void Awake()
    {
       instance=this; 
    }
    public bool CanReceiveInput;
    public bool InputReceived;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public void Attack(){

        if(Input.GetButtonDown("P1_Light"))
        {
            if(CanReceiveInput)
            {
                InputReceived=true;
                CanReceiveInput=false;
            }
        }else
        {
            return;
        }
    }
    public void InputManager(){
        if(!CanReceiveInput)
        {
            CanReceiveInput=true;
        }else
        {
            CanReceiveInput=false;
        }
    }
}
