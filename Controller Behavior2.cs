using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControllerBehavior2 : MonoBehaviour
{
        private Player thePlayer;
            public TextMeshPro tm;
    void Start()
    {
        this.thePlayer = new Player ("Barnical");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
            
    }

    private void FixedUpdate()
    {
        this.thePlayer.display();

        /*if(MySingleton.player1Turn == true)
        {
        print("Love Player 2 : " + MySingleton.counter+ "****");
        MySingleton.count++;
        MySingleton.count = MySingleton.count + 1;
        }
        */
    }
}
