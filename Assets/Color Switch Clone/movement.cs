using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movement : MonoBehaviour
{
    // Start is called before the first frame update
	public float jumpforce = 10f;
	public Rigidbody2D rb;
	public string currentcolor;
	public Color colorblue;
	public Color coloryellow;
	public Color colormagenta;
	public Color colorpurple;
	public SpriteRenderer sr;
	public bool ismove = true;
    void Start()
    {
		sr = GetComponent<SpriteRenderer>();
        setcolor();
		ismove = true;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetMouseButtonDown(0))
		{ 
        rb.velocity = Vector2.up * jumpforce;
		ismove = false;
		}
		if ((transform.position.y <= -4.5) && ismove == true)
		{
		rb.velocity = Vector2.up * jumpforce;	
		}
    }
	void OnTriggerEnter2D(Collider2D col)
	{   if (col.tag == "colorchanger")
		{
			setcolor();
			Destroy(col.gameObject);
			
		}
		if(col.tag != currentcolor)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	void setcolor()
	{
		int no = Random.Range(0,4);
		switch (no)
		{
			case 0:
			currentcolor = "yellow";
			sr.color = coloryellow;
			break;
			
			case 1:
			currentcolor = "blue";
			sr.color = colorblue;
			break;
			
			case 2:
			currentcolor = "magenta";
			sr.color = colormagenta;
			break;
			
			case 3: 
			currentcolor = "purple";
			sr.color = colorpurple;
			break;
			
		}
		
	}
}
