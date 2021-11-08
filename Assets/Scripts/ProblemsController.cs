using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProblemsController : MonoBehaviour
{
    public int score = 0;
    
    public int initTime = 60;

    private int current_answer;

    private int val1, val2;

    public GameObject g_val1, g_val2, g_op1, g_op2, g_ans;

    private string op1;
    // Start is called before the first frame update

    void createProblem()
    {
        val1 = Random.Range(1, 5);
        val2 = Random.Range(1, 5);
        op1 = "+";
        g_val1.GetComponent<TextMeshProUGUI>().text = val1.ToString();
        g_val2.GetComponent<TextMeshProUGUI>().text = val2.ToString();
        g_op1.GetComponent<TextMeshProUGUI>().text = op1;
        g_ans.GetComponent<TextMeshProUGUI>().text = (val1 + val2).ToString();


    }

    public void checkAnswer(int ans)
    {
        if (val1 + val2 == ans)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Incorrect...");
        }

        createProblem();

    }
    void Start()
    {
        createProblem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
