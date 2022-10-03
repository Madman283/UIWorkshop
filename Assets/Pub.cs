using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pub : MonoBehaviour
{

    [SerializeField] Text textToChange;

    int count = 0;



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //textToChange.text = $"you have cuaght {count}/50 cats";
        //if (count > 50)
        //{

        //}
    }
    private void OnMouseDown()
    {
        textToChange.text = count.ToString();
        count++;
    }
}
