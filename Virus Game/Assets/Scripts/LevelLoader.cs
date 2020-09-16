using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LoadMainScene()
    {
        StartCoroutine(LoadAnim(0));

    }

    public void LoadResearchScene()
    {
        StartCoroutine(LoadAnim(1));
        
    }

    IEnumerator LoadAnim(int buildIndex)
    {
        anim.SetTrigger("CrossFade");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(buildIndex);
    }
}
