using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProblemsController : MonoBehaviour
{
    public int score = 0;
    
    public int initTime = 60;
    public GameObject g_cur_val1, g_cur_val2, g_cur_op1, g_cur_op2, g_cur_ans;
    
    public GameObject g_prev_val1, g_prev_val2, g_prev_op1, g_prev_op2, g_prev_ans;
    public GameObject g_new_val1, g_new_val2, g_new_op1, g_new_op2, g_new_ans;

    public GameObject correct, incorrect, score_text;

    public struct Problem
    {
        public int val1;
        public int val2;
        public string op1;
        public string op2;
        public int ans;
    };

    public Problem problem_new, problem_cur, problem_prev;
    
    // Start is called before the first frame update

    void createNewProblem()
    {
        problem_new.val1 = Random.Range(1, 5);
        problem_new.val2 = Random.Range(1, 5);
        problem_new.op1 = "+";
    }

    void moveProblems()
    {
        problem_prev = problem_cur;
        problem_cur = problem_new;
    }

    void updateProblems()
    {
        g_new_val1.GetComponent<TextMeshProUGUI>().text = problem_new.val1.ToString();
        g_new_val2.GetComponent<TextMeshProUGUI>().text = problem_new.val2.ToString();
        g_new_op1.GetComponent<TextMeshProUGUI>().text = problem_new.op1;
        g_new_ans.GetComponent<TextMeshProUGUI>().text = (problem_new.val1 + problem_new.val2).ToString(); 
        
        g_cur_val1.GetComponent<TextMeshProUGUI>().text = problem_cur.val1.ToString();
        g_cur_val2.GetComponent<TextMeshProUGUI>().text = problem_cur.val2.ToString();
        g_cur_op1.GetComponent<TextMeshProUGUI>().text = problem_cur.op1;
        g_cur_ans.GetComponent<TextMeshProUGUI>().text = (problem_cur.val1 + problem_cur.val2).ToString(); 
        
        g_prev_val1.GetComponent<TextMeshProUGUI>().text = problem_prev.val1.ToString();
        g_prev_val2.GetComponent<TextMeshProUGUI>().text = problem_prev.val2.ToString();
        g_prev_op1.GetComponent<TextMeshProUGUI>().text = problem_prev.op1;
        g_prev_ans.GetComponent<TextMeshProUGUI>().text = (problem_prev.val1 + problem_prev.val2).ToString(); 
    }
    
    
    public void checkAnswer(int ans)
    {
        if (problem_cur.val1 + problem_cur.val2 == ans)
        {
            Debug.Log("Correct!");
            correct.SetActive(true);
            incorrect.SetActive(false);
            score++;
            score_text.GetComponent<TextMeshProUGUI>().text = score.ToString();
        }
        else
        {
            Debug.Log("Incorrect...");
            
            correct.SetActive(false);
            incorrect.SetActive(true);
        }

        moveProblems();
        createNewProblem();
        updateProblems();

    }
    void Start()
    {
        createNewProblem();
        updateProblems();

        correct.SetActive(false);
        incorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
