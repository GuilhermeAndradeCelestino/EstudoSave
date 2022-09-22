using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Hud : MonoBehaviour
{
    public TextMeshProUGUI textColetavel1, textColetavel2, textColetavel3;
    Coletaveis go;


    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<Coletaveis>();
    }

    // Update is called once per frame
    void Update()
    {
        textColetavel1.text = "= " + go.coletavel1.ToString();
        textColetavel2.text = "= " + go.coletavel2.ToString();
        textColetavel3.text = "= " + go.coletavel3.ToString();
    }
}
