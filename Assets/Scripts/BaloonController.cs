using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BaloonController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


    private static int score = 0;
    private float upSpeed = 3f;

    
    private AudioSource baloonPop;
    private Animator baloonPopAnim;
    // Start is called before the first frame update
    void Start()
    {
        baloonPop = GetComponent<AudioSource>();
        baloonPopAnim = GetComponent<Animator>();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(transform.position.y> 6f)
        {
            score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed * Time.deltaTime, 0);
    }
    private void OnMouseDown()
    {
        score++;
        UpdateScoreText(); 
        baloonPopAnim.SetTrigger("isPopped");
        baloonPop.Play();
    }

    private void ResetPosition()
    {
        baloonPopAnim.ResetTrigger("isPopped");
        baloonPopAnim.Play("Idle");
        float xPosition = Random.Range(-2.5f, 2.5f);
        float yPosition = Random.Range(-6f, -8.5f);
        transform.position = new Vector2(xPosition, yPosition);
    }
    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
