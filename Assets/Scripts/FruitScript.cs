using UnityEngine;


public class FruitScript : MonoBehaviour
{
    private float _launchForce = 12f;
    int waardeHit = 100;
    void Start()
    {


            this.gameObject.GetComponent<Rigidbody2D>().AddForce(this.gameObject.transform.up * _launchForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.Instance.AddScore(waardeHit);
            Destroy(gameObject);
        }
        Destroy(gameObject, 3f);

    }

}

            // Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 
            // Collider2D hit = Physics2D.OverlapPoint(mousePosition);
            // if(hit != null )
            // {
            //     if (hit.gameObject.CompareTag("Fruit"))
            //     {
            //          Destroy(hit.gameObject);
            //     }
            //      Debug.Log(hit.gameObject.tag);
                
            // }