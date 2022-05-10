using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    GameObject clon;
    public int cloneAmount;
    public Text txtCloneAmount;
    public void MultiInstantiate()
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        

        for (int i = 0; i < cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 1);
        }
    }
}
