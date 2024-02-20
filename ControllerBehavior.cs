using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControllerBehavior : MonoBehaviour
{
  private Player thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    private float speed = 1.0f;
    
    void Start()
    {
        this.thePlayer = new Player("Brian");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
    }
    private void Update()
    {
        if(Vector3.Distance(this.gameObject.transform.position, this.destinationGO.transform.position) > 1.0f)
        {
            this.gameObject.transform.position = Vector3.Slerp(this.gameObject.transform.position, this.destinationGO.transform.position, this.speed * Time.deltaTime);
        }
    }
}
