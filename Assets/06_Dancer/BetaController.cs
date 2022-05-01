using UnityEngine;
using System.Collections;
 
public class BetaController : MonoBehaviour
{
	private Animator animator;
	[SerializeField] public int defaultState = 4;
 
	void Start ()
	{
		this.animator = this.GetComponent<Animator>();
		this.animator.SetInteger("AnimationType", defaultState);
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
			Debug.Log("Alpha1");
            this.animator.SetInteger("AnimationType", 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			Debug.Log("Alpha2");
            this.animator.SetInteger("AnimationType", 2);
		}
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			Debug.Log("Alpha3");
            this.animator.SetInteger("AnimationType", 3);
		}
        else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			Debug.Log("Alpha4");
            this.animator.SetInteger("AnimationType", 4);
		}
        else if (Input.GetKeyDown(KeyCode.Alpha5)) {
			Debug.Log("Alpha5");
            this.animator.SetInteger("AnimationType", 5);
		}
        else if (Input.GetKeyDown(KeyCode.Alpha6)) {
			Debug.Log("Alpha6");
            this.animator.SetInteger("AnimationType", 6);
		}
	}
}