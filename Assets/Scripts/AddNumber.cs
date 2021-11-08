using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddNumber : MonoBehaviour
{
    private GameObject master;
    public void OnClick()
    {
        TextMeshProUGUI n = gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        Debug.Log(n.text);  // ログを出力
        master.GetComponent<ProblemsController>().checkAnswer(int.Parse(n.text));
    }
    
    // Start is called before the first frame update
    void Start()
    {
        master = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
